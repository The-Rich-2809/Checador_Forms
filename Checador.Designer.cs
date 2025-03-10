namespace Checador_Forms
{
    partial class Checador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusText = new System.Windows.Forms.Label();
            this.ReportText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreText = new MaterialSkin.Controls.MaterialTextBox();
            this.Apellido1Text = new MaterialSkin.Controls.MaterialTextBox();
            this.Apellido2Text = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoEmpleadoText = new MaterialSkin.Controls.MaterialTextBox();
            this.ChecarTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPB)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(88, 485);
            this.StatusText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(35, 13);
            this.StatusText.TabIndex = 0;
            this.StatusText.Text = "label1";
            // 
            // ReportText
            // 
            this.ReportText.AutoSize = true;
            this.ReportText.Location = new System.Drawing.Point(309, 485);
            this.ReportText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportText.Name = "ReportText";
            this.ReportText.Size = new System.Drawing.Size(35, 13);
            this.ReportText.TabIndex = 1;
            this.ReportText.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Primer Apellido";
            // 
            // NombreText
            // 
            this.NombreText.AnimateReadOnly = false;
            this.NombreText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreText.Depth = 0;
            this.NombreText.Enabled = false;
            this.NombreText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreText.LeadingIcon = null;
            this.NombreText.Location = new System.Drawing.Point(212, 98);
            this.NombreText.MaxLength = 50;
            this.NombreText.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreText.Multiline = false;
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(223, 50);
            this.NombreText.TabIndex = 22;
            this.NombreText.Text = "";
            this.NombreText.TrailingIcon = null;
            // 
            // Apellido1Text
            // 
            this.Apellido1Text.AnimateReadOnly = false;
            this.Apellido1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido1Text.Depth = 0;
            this.Apellido1Text.Enabled = false;
            this.Apellido1Text.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido1Text.LeadingIcon = null;
            this.Apellido1Text.Location = new System.Drawing.Point(212, 154);
            this.Apellido1Text.MaxLength = 50;
            this.Apellido1Text.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido1Text.Multiline = false;
            this.Apellido1Text.Name = "Apellido1Text";
            this.Apellido1Text.Size = new System.Drawing.Size(223, 50);
            this.Apellido1Text.TabIndex = 24;
            this.Apellido1Text.Text = "";
            this.Apellido1Text.TrailingIcon = null;
            // 
            // Apellido2Text
            // 
            this.Apellido2Text.AnimateReadOnly = false;
            this.Apellido2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido2Text.Depth = 0;
            this.Apellido2Text.Enabled = false;
            this.Apellido2Text.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido2Text.LeadingIcon = null;
            this.Apellido2Text.Location = new System.Drawing.Point(212, 210);
            this.Apellido2Text.MaxLength = 50;
            this.Apellido2Text.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido2Text.Multiline = false;
            this.Apellido2Text.Name = "Apellido2Text";
            this.Apellido2Text.Size = new System.Drawing.Size(223, 50);
            this.Apellido2Text.TabIndex = 26;
            this.Apellido2Text.Text = "";
            this.Apellido2Text.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tipo Empleado";
            // 
            // TipoEmpleadoText
            // 
            this.TipoEmpleadoText.AnimateReadOnly = false;
            this.TipoEmpleadoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipoEmpleadoText.Depth = 0;
            this.TipoEmpleadoText.Enabled = false;
            this.TipoEmpleadoText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TipoEmpleadoText.LeadingIcon = null;
            this.TipoEmpleadoText.Location = new System.Drawing.Point(212, 266);
            this.TipoEmpleadoText.MaxLength = 50;
            this.TipoEmpleadoText.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoEmpleadoText.Multiline = false;
            this.TipoEmpleadoText.Name = "TipoEmpleadoText";
            this.TipoEmpleadoText.Size = new System.Drawing.Size(223, 50);
            this.TipoEmpleadoText.TabIndex = 28;
            this.TipoEmpleadoText.Text = "";
            this.TipoEmpleadoText.TrailingIcon = null;
            // 
            // ChecarTimer
            // 
            this.ChecarTimer.Interval = 3000;
            this.ChecarTimer.Tick += new System.EventHandler(this.ChecarTimer_Tick);
            // 
            // CheckPB
            // 
            this.CheckPB.Location = new System.Drawing.Point(277, 334);
            this.CheckPB.Name = "CheckPB";
            this.CheckPB.Size = new System.Drawing.Size(100, 83);
            this.CheckPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckPB.TabIndex = 30;
            this.CheckPB.TabStop = false;
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 500);
            this.Controls.Add(this.CheckPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoEmpleadoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido2Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Apellido1Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.ReportText);
            this.Controls.Add(this.StatusText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checador";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "Checador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Checador_FormClosed);
            this.Load += new System.EventHandler(this.Checador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label ReportText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox NombreText;
        private MaterialSkin.Controls.MaterialTextBox Apellido1Text;
        private MaterialSkin.Controls.MaterialTextBox Apellido2Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox TipoEmpleadoText;
        private System.Windows.Forms.Timer ChecarTimer;
        private System.Windows.Forms.PictureBox CheckPB;
    }
}