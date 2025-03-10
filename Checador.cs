using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador_Forms.Clases;

namespace Checador_Forms
{
    public partial class Checador : MaterialSkin.Controls.MaterialForm, DPFP.Capture.EventHandler
    {
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capturer;
        Checador_SQL checador = new Checador_SQL();
        public SoundPlayer PlayerCorrect, PlayerIncorrect;
        public Checador()
        {
            InitializeComponent();
            PlayerCorrect = new SoundPlayer(Properties.Resources.correct);
            PlayerIncorrect = new SoundPlayer(Properties.Resources.incorrect);
        }
        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    ReportText.Text = "No se pudo iniciar la operación de captura";
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Verificator = new DPFP.Verification.Verification();
        }

        protected void Process(DPFP.Sample Sample)
        {
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                Stream stream;

                DataTable data = checador.Mostrar_Empleados();
                DataTable data2 = checador.Mostrar_EmpleadoSite();
                int i = 0;

                foreach (DataRow empleado in data.Rows)
                {
                    if (empleado[5].ToString() == Datos.IdSite.ToString())
                    {
                        if (empleado[4] != null)
                        {
                            stream = new MemoryStream((byte[])empleado[4]);
                            template = new DPFP.Template(stream);

                            Verificator.Verify(features, template, ref result);
                            if (result.Verified)
                            {
                                Datos.IdEmpleado = empleado[0].ToString();
                                Datos.IdEncargado = Convert.ToInt32(empleado[7]);
                                Datos.Registro = DateTime.Now;
                                this.Invoke(new Function(delegate () {
                                    Desplegar(empleado[1].ToString(), empleado[2].ToString(), empleado[3].ToString(), empleado[6].ToString());
                                }));
                                i = 1;
                                break;
                            }
                            else
                            {
                                i = 2;
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow site in data2.Rows)
                        {
                            if (empleado[0].ToString() == site[0].ToString())
                            {
                                if (empleado[4] != null)
                                {
                                    stream = new MemoryStream((byte[])empleado[4]);
                                    template = new DPFP.Template(stream);

                                    Verificator.Verify(features, template, ref result);
                                    if (result.Verified)
                                    {
                                        Datos.IdEmpleado = empleado[0].ToString();
                                        this.Invoke(new Function(delegate () {
                                            Desplegar(empleado[1].ToString(), empleado[2].ToString(), empleado[3].ToString(), empleado[6].ToString());
                                            
                                        }));
                                        i = 1;
                                        break;

                                    }
                                    else
                                    {
                                        i = 2;
                                    }
                                }
                            }
                            
                        }
                    }
                    if (i == 1)
                    {
                        break;
                    }
                }
                if (i == 2)
                {
                    ChecarTimer.Stop();
                    this.Invoke(new Function(delegate ()
                    {
                        NombreText.Text = "";
                        Apellido1Text.Text = "";
                        Apellido2Text.Text = "";
                        TipoEmpleadoText.Text = "";
                        ReportText.Text = "No se encontró el empleado";
                    }));
                    CheckPB.Image = Properties.Resources.error;
                    PlayerIncorrect.Play();
                    ChecarTimer.Start();
                }
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    ReportText.Text = "Escanea tu huella usando el lector";
                }
                catch
                {
                    ReportText.Text = "No se puede iniciar la captura";
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    ReportText.Text = "No se puede terminar la captura";
                }
            }
        }

        private void Checador_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void Checador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        public void Desplegar(string Nombre, string Apellido1, string Apellido2, string TipoEmpleado)
        {
            ChecarTimer.Stop();
            NombreText.Text = Nombre;
            Apellido1Text.Text = Apellido1;
            Apellido2Text.Text = Apellido2;
            TipoEmpleadoText.Text = TipoEmpleado;
            checador.RegistroChecar();
            CheckPB.Image = Properties.Resources.check;
            PlayerCorrect.Play();
            ChecarTimer.Start();

        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            this.Invoke(new Function(delegate () {
                ReportText.Text = "La muestra ha sido capturada";
                StatusText.Text = "Escanea tu misma huella otra vez";
                Process(Sample);
            }));
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Function(delegate () {
                ReportText.Text = "La huella fue removida del lector";
            }));
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Function(delegate () {
                ReportText.Text = "El lector fue tocado";
            }));
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Function(delegate () {
                ReportText.Text = "El Lector de huellas ha sido conectado";
            }));
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            this.Invoke(new Function(delegate () {
                ReportText.Text = "El Lector de huellas ha sido desconectado";
            }));
            
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            //this.Invoke(new Function(delegate () {
            //    if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            //        ReportText.Text = "La calidad de la muestra es BUENA";
            //    else
            //        ReportText.Text = "La calidad de la muestra es MALA";
            //}));
        }
        #endregion

        private void ChecarTimer_Tick(object sender, EventArgs e)
        {
            CheckPB.Image = null;
            NombreText.Text = "";
            Apellido1Text.Text = "";
            Apellido2Text.Text = "";
            TipoEmpleadoText.Text = "";
            ChecarTimer.Stop();
        }
    }
}
