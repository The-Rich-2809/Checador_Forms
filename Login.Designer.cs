namespace Checador_Forms
{
    partial class Login
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
            this.CorreoText = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrasenaText = new MaterialSkin.Controls.MaterialTextBox();
            this.LoginBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CorreoText
            // 
            this.CorreoText.AnimateReadOnly = false;
            this.CorreoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorreoText.Depth = 0;
            this.CorreoText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CorreoText.LeadingIcon = null;
            this.CorreoText.Location = new System.Drawing.Point(33, 101);
            this.CorreoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CorreoText.MaxLength = 50;
            this.CorreoText.MouseState = MaterialSkin.MouseState.OUT;
            this.CorreoText.Multiline = false;
            this.CorreoText.Name = "CorreoText";
            this.CorreoText.Size = new System.Drawing.Size(397, 50);
            this.CorreoText.TabIndex = 0;
            this.CorreoText.Text = "";
            this.CorreoText.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // ContrasenaText
            // 
            this.ContrasenaText.AnimateReadOnly = false;
            this.ContrasenaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaText.Depth = 0;
            this.ContrasenaText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenaText.LeadingIcon = null;
            this.ContrasenaText.Location = new System.Drawing.Point(33, 184);
            this.ContrasenaText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContrasenaText.MaxLength = 50;
            this.ContrasenaText.MouseState = MaterialSkin.MouseState.OUT;
            this.ContrasenaText.Multiline = false;
            this.ContrasenaText.Name = "ContrasenaText";
            this.ContrasenaText.Password = true;
            this.ContrasenaText.Size = new System.Drawing.Size(397, 50);
            this.ContrasenaText.TabIndex = 2;
            this.ContrasenaText.Text = "";
            this.ContrasenaText.TrailingIcon = null;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginBtn.Depth = 0;
            this.LoginBtn.HighEmphasis = true;
            this.LoginBtn.Icon = null;
            this.LoginBtn.Location = new System.Drawing.Point(177, 240);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginBtn.Size = new System.Drawing.Size(128, 36);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Iniciar Sesión";
            this.LoginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginBtn.UseAccentColor = false;
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 312);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContrasenaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorreoText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox CorreoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox ContrasenaText;
        private MaterialSkin.Controls.MaterialButton LoginBtn;
    }
}