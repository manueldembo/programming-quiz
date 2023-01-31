namespace programming_quiz
{
    partial class frmPerdeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerdeu));
            this.lblTexto = new System.Windows.Forms.Label();
            this.cmdVoltar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(65, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(170, 33);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Você perdeu!!!";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.ActiveBorderThickness = 1;
            this.cmdVoltar.ActiveCornerRadius = 20;
            this.cmdVoltar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdVoltar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdVoltar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdVoltar.BackColor = System.Drawing.Color.Navy;
            this.cmdVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdVoltar.BackgroundImage")));
            this.cmdVoltar.ButtonText = "VOLTAR";
            this.cmdVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVoltar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdVoltar.ForeColor = System.Drawing.Color.White;
            this.cmdVoltar.IdleBorderThickness = 1;
            this.cmdVoltar.IdleCornerRadius = 20;
            this.cmdVoltar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdVoltar.IdleForecolor = System.Drawing.Color.White;
            this.cmdVoltar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdVoltar.Location = new System.Drawing.Point(100, 186);
            this.cmdVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(100, 50);
            this.cmdVoltar.TabIndex = 3;
            this.cmdVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::programming_quiz.Properties.Resources.emoji_medio1;
            this.pictureBox1.Location = new System.Drawing.Point(100, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPerdeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPerdeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPerdeu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTexto;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdVoltar;
    }
}