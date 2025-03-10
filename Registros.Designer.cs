namespace Checador_Forms
{
    partial class Registros
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
            this.TablaEmpleadosDGV = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarBtn = new MaterialSkin.Controls.MaterialButton();
            this.EliminarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ActualizarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ControlesGB = new System.Windows.Forms.GroupBox();
            this.EditarGB = new System.Windows.Forms.GroupBox();
            this.HuellaText = new MaterialSkin.Controls.MaterialTextBox();
            this.CancelarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarRegistroBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarRegistroBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarHuellaBtn = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.EncargadoCB = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoUsuarioCB = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido2Text = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Apellido1Text = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreText = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleadosDGV)).BeginInit();
            this.ControlesGB.SuspendLayout();
            this.EditarGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaEmpleadosDGV
            // 
            this.TablaEmpleadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEmpleadosDGV.Location = new System.Drawing.Point(6, 67);
            this.TablaEmpleadosDGV.Name = "TablaEmpleadosDGV";
            this.TablaEmpleadosDGV.Size = new System.Drawing.Size(836, 184);
            this.TablaEmpleadosDGV.TabIndex = 0;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarBtn.Depth = 0;
            this.AgregarBtn.HighEmphasis = true;
            this.AgregarBtn.Icon = null;
            this.AgregarBtn.Location = new System.Drawing.Point(7, 22);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarBtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarBtn.UseAccentColor = false;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarBtn.Depth = 0;
            this.ModificarBtn.HighEmphasis = true;
            this.ModificarBtn.Icon = null;
            this.ModificarBtn.Location = new System.Drawing.Point(103, 22);
            this.ModificarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModificarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarBtn.UseAccentColor = false;
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarBtn.Depth = 0;
            this.EliminarBtn.HighEmphasis = true;
            this.EliminarBtn.Icon = null;
            this.EliminarBtn.Location = new System.Drawing.Point(210, 22);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EliminarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EliminarBtn.Size = new System.Drawing.Size(88, 36);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarBtn.UseAccentColor = false;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActualizarBtn.Depth = 0;
            this.ActualizarBtn.HighEmphasis = true;
            this.ActualizarBtn.Icon = null;
            this.ActualizarBtn.Location = new System.Drawing.Point(306, 22);
            this.ActualizarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActualizarBtn.Size = new System.Drawing.Size(109, 36);
            this.ActualizarBtn.TabIndex = 4;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActualizarBtn.UseAccentColor = false;
            this.ActualizarBtn.UseVisualStyleBackColor = true;
            this.ActualizarBtn.Click += new System.EventHandler(this.ActualizarBtn_Click);
            // 
            // ControlesGB
            // 
            this.ControlesGB.Controls.Add(this.AgregarBtn);
            this.ControlesGB.Controls.Add(this.ActualizarBtn);
            this.ControlesGB.Controls.Add(this.ModificarBtn);
            this.ControlesGB.Controls.Add(this.EliminarBtn);
            this.ControlesGB.Location = new System.Drawing.Point(217, 257);
            this.ControlesGB.Name = "ControlesGB";
            this.ControlesGB.Size = new System.Drawing.Size(423, 73);
            this.ControlesGB.TabIndex = 5;
            this.ControlesGB.TabStop = false;
            // 
            // EditarGB
            // 
            this.EditarGB.Controls.Add(this.HuellaText);
            this.EditarGB.Controls.Add(this.CancelarBtn);
            this.EditarGB.Controls.Add(this.ModificarRegistroBtn);
            this.EditarGB.Controls.Add(this.AgregarRegistroBtn);
            this.EditarGB.Controls.Add(this.AgregarHuellaBtn);
            this.EditarGB.Controls.Add(this.label5);
            this.EditarGB.Controls.Add(this.EncargadoCB);
            this.EditarGB.Controls.Add(this.label4);
            this.EditarGB.Controls.Add(this.TipoUsuarioCB);
            this.EditarGB.Controls.Add(this.label3);
            this.EditarGB.Controls.Add(this.Apellido2Text);
            this.EditarGB.Controls.Add(this.label2);
            this.EditarGB.Controls.Add(this.Apellido1Text);
            this.EditarGB.Controls.Add(this.label1);
            this.EditarGB.Controls.Add(this.NombreText);
            this.EditarGB.Location = new System.Drawing.Point(26, 357);
            this.EditarGB.Name = "EditarGB";
            this.EditarGB.Size = new System.Drawing.Size(783, 382);
            this.EditarGB.TabIndex = 20;
            this.EditarGB.TabStop = false;
            // 
            // HuellaText
            // 
            this.HuellaText.AnimateReadOnly = false;
            this.HuellaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HuellaText.Depth = 0;
            this.HuellaText.Enabled = false;
            this.HuellaText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HuellaText.LeadingIcon = null;
            this.HuellaText.Location = new System.Drawing.Point(262, 248);
            this.HuellaText.MaxLength = 50;
            this.HuellaText.MouseState = MaterialSkin.MouseState.OUT;
            this.HuellaText.Multiline = false;
            this.HuellaText.Name = "HuellaText";
            this.HuellaText.Size = new System.Drawing.Size(299, 50);
            this.HuellaText.TabIndex = 34;
            this.HuellaText.Text = "";
            this.HuellaText.TrailingIcon = null;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelarBtn.Depth = 0;
            this.CancelarBtn.HighEmphasis = true;
            this.CancelarBtn.Icon = null;
            this.CancelarBtn.Location = new System.Drawing.Point(465, 328);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelarBtn.Size = new System.Drawing.Size(96, 36);
            this.CancelarBtn.TabIndex = 33;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelarBtn.UseAccentColor = false;
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ModificarRegistroBtn
            // 
            this.ModificarRegistroBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarRegistroBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarRegistroBtn.Depth = 0;
            this.ModificarRegistroBtn.HighEmphasis = true;
            this.ModificarRegistroBtn.Icon = null;
            this.ModificarRegistroBtn.Location = new System.Drawing.Point(358, 328);
            this.ModificarRegistroBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModificarRegistroBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarRegistroBtn.Name = "ModificarRegistroBtn";
            this.ModificarRegistroBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarRegistroBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarRegistroBtn.TabIndex = 32;
            this.ModificarRegistroBtn.Text = "Modificar";
            this.ModificarRegistroBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarRegistroBtn.UseAccentColor = false;
            this.ModificarRegistroBtn.UseVisualStyleBackColor = true;
            this.ModificarRegistroBtn.Click += new System.EventHandler(this.ModificarRegistroBtn_Click);
            // 
            // AgregarRegistroBtn
            // 
            this.AgregarRegistroBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarRegistroBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarRegistroBtn.Depth = 0;
            this.AgregarRegistroBtn.HighEmphasis = true;
            this.AgregarRegistroBtn.Icon = null;
            this.AgregarRegistroBtn.Location = new System.Drawing.Point(262, 328);
            this.AgregarRegistroBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarRegistroBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarRegistroBtn.Name = "AgregarRegistroBtn";
            this.AgregarRegistroBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarRegistroBtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarRegistroBtn.TabIndex = 31;
            this.AgregarRegistroBtn.Text = "Agregar";
            this.AgregarRegistroBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarRegistroBtn.UseAccentColor = false;
            this.AgregarRegistroBtn.UseVisualStyleBackColor = true;
            this.AgregarRegistroBtn.Click += new System.EventHandler(this.AgregarRegistroBtn_Click);
            // 
            // AgregarHuellaBtn
            // 
            this.AgregarHuellaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarHuellaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarHuellaBtn.Depth = 0;
            this.AgregarHuellaBtn.HighEmphasis = true;
            this.AgregarHuellaBtn.Icon = null;
            this.AgregarHuellaBtn.Location = new System.Drawing.Point(339, 203);
            this.AgregarHuellaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarHuellaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarHuellaBtn.Name = "AgregarHuellaBtn";
            this.AgregarHuellaBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarHuellaBtn.Size = new System.Drawing.Size(146, 36);
            this.AgregarHuellaBtn.TabIndex = 30;
            this.AgregarHuellaBtn.Text = "Agregar Huella";
            this.AgregarHuellaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarHuellaBtn.UseAccentColor = false;
            this.AgregarHuellaBtn.UseVisualStyleBackColor = true;
            this.AgregarHuellaBtn.Click += new System.EventHandler(this.AgregarHuellaBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Encargado";
            // 
            // EncargadoCB
            // 
            this.EncargadoCB.AutoResize = false;
            this.EncargadoCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EncargadoCB.Depth = 0;
            this.EncargadoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EncargadoCB.DropDownHeight = 174;
            this.EncargadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncargadoCB.DropDownWidth = 121;
            this.EncargadoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EncargadoCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EncargadoCB.FormattingEnabled = true;
            this.EncargadoCB.IntegralHeight = false;
            this.EncargadoCB.ItemHeight = 43;
            this.EncargadoCB.Location = new System.Drawing.Point(401, 144);
            this.EncargadoCB.MaxDropDownItems = 4;
            this.EncargadoCB.MouseState = MaterialSkin.MouseState.OUT;
            this.EncargadoCB.Name = "EncargadoCB";
            this.EncargadoCB.Size = new System.Drawing.Size(223, 49);
            this.EncargadoCB.StartIndex = 0;
            this.EncargadoCB.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Usuario";
            // 
            // TipoUsuarioCB
            // 
            this.TipoUsuarioCB.AutoResize = false;
            this.TipoUsuarioCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoUsuarioCB.Depth = 0;
            this.TipoUsuarioCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TipoUsuarioCB.DropDownHeight = 174;
            this.TipoUsuarioCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoUsuarioCB.DropDownWidth = 121;
            this.TipoUsuarioCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TipoUsuarioCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoUsuarioCB.FormattingEnabled = true;
            this.TipoUsuarioCB.IntegralHeight = false;
            this.TipoUsuarioCB.ItemHeight = 43;
            this.TipoUsuarioCB.Location = new System.Drawing.Point(172, 145);
            this.TipoUsuarioCB.MaxDropDownItems = 4;
            this.TipoUsuarioCB.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoUsuarioCB.Name = "TipoUsuarioCB";
            this.TipoUsuarioCB.Size = new System.Drawing.Size(223, 49);
            this.TipoUsuarioCB.StartIndex = 0;
            this.TipoUsuarioCB.TabIndex = 26;
            this.TipoUsuarioCB.SelectedIndexChanged += new System.EventHandler(this.TipoUsuarioCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "2do Apellido";
            // 
            // Apellido2Text
            // 
            this.Apellido2Text.AnimateReadOnly = false;
            this.Apellido2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido2Text.Depth = 0;
            this.Apellido2Text.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido2Text.LeadingIcon = null;
            this.Apellido2Text.Location = new System.Drawing.Point(523, 58);
            this.Apellido2Text.MaxLength = 50;
            this.Apellido2Text.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido2Text.Multiline = false;
            this.Apellido2Text.Name = "Apellido2Text";
            this.Apellido2Text.Size = new System.Drawing.Size(223, 50);
            this.Apellido2Text.TabIndex = 24;
            this.Apellido2Text.Text = "";
            this.Apellido2Text.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "1er Apellido";
            // 
            // Apellido1Text
            // 
            this.Apellido1Text.AnimateReadOnly = false;
            this.Apellido1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido1Text.Depth = 0;
            this.Apellido1Text.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Apellido1Text.LeadingIcon = null;
            this.Apellido1Text.Location = new System.Drawing.Point(294, 58);
            this.Apellido1Text.MaxLength = 50;
            this.Apellido1Text.MouseState = MaterialSkin.MouseState.OUT;
            this.Apellido1Text.Multiline = false;
            this.Apellido1Text.Name = "Apellido1Text";
            this.Apellido1Text.Size = new System.Drawing.Size(223, 50);
            this.Apellido1Text.TabIndex = 22;
            this.Apellido1Text.Text = "";
            this.Apellido1Text.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // NombreText
            // 
            this.NombreText.AnimateReadOnly = false;
            this.NombreText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreText.Depth = 0;
            this.NombreText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreText.LeadingIcon = null;
            this.NombreText.Location = new System.Drawing.Point(65, 58);
            this.NombreText.MaxLength = 50;
            this.NombreText.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreText.Multiline = false;
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(223, 50);
            this.NombreText.TabIndex = 20;
            this.NombreText.Text = "";
            this.NombreText.TrailingIcon = null;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 774);
            this.Controls.Add(this.EditarGB);
            this.Controls.Add(this.ControlesGB);
            this.Controls.Add(this.TablaEmpleadosDGV);
            this.MaximizeBox = false;
            this.Name = "Registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleadosDGV)).EndInit();
            this.ControlesGB.ResumeLayout(false);
            this.ControlesGB.PerformLayout();
            this.EditarGB.ResumeLayout(false);
            this.EditarGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaEmpleadosDGV;
        private MaterialSkin.Controls.MaterialButton AgregarBtn;
        private MaterialSkin.Controls.MaterialButton ModificarBtn;
        private MaterialSkin.Controls.MaterialButton EliminarBtn;
        private MaterialSkin.Controls.MaterialButton ActualizarBtn;
        private System.Windows.Forms.GroupBox ControlesGB;
        private System.Windows.Forms.GroupBox EditarGB;
        private MaterialSkin.Controls.MaterialButton CancelarBtn;
        private MaterialSkin.Controls.MaterialButton ModificarRegistroBtn;
        private MaterialSkin.Controls.MaterialButton AgregarRegistroBtn;
        private MaterialSkin.Controls.MaterialButton AgregarHuellaBtn;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox EncargadoCB;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox TipoUsuarioCB;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox Apellido2Text;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox Apellido1Text;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox NombreText;
        private MaterialSkin.Controls.MaterialTextBox HuellaText;
    }
}