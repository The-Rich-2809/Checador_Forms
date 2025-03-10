namespace Checador_Forms
{
    partial class Lobby
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
            this.ChecadorBtn = new MaterialSkin.Controls.MaterialButton();
            this.RegistrarBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ChecadorBtn
            // 
            this.ChecadorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChecadorBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChecadorBtn.Depth = 0;
            this.ChecadorBtn.HighEmphasis = true;
            this.ChecadorBtn.Icon = null;
            this.ChecadorBtn.Location = new System.Drawing.Point(230, 164);
            this.ChecadorBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChecadorBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChecadorBtn.Name = "ChecadorBtn";
            this.ChecadorBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChecadorBtn.Size = new System.Drawing.Size(98, 36);
            this.ChecadorBtn.TabIndex = 0;
            this.ChecadorBtn.Text = "Checador";
            this.ChecadorBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChecadorBtn.UseAccentColor = false;
            this.ChecadorBtn.UseVisualStyleBackColor = true;
            this.ChecadorBtn.Click += new System.EventHandler(this.ChecadorBtn_Click);
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegistrarBtn.Depth = 0;
            this.RegistrarBtn.HighEmphasis = true;
            this.RegistrarBtn.Icon = null;
            this.RegistrarBtn.Location = new System.Drawing.Point(229, 202);
            this.RegistrarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegistrarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegistrarBtn.Size = new System.Drawing.Size(99, 36);
            this.RegistrarBtn.TabIndex = 1;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegistrarBtn.UseAccentColor = false;
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            this.RegistrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 384);
            this.Controls.Add(this.RegistrarBtn);
            this.Controls.Add(this.ChecadorBtn);
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ChecadorBtn;
        private MaterialSkin.Controls.MaterialButton RegistrarBtn;
    }
}