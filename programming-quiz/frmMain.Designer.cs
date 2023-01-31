namespace programming_quiz
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdMinimizar = new System.Windows.Forms.Button();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.cmdJogar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdPontuacao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programming-Quiz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.cmdMinimizar);
            this.panel1.Controls.Add(this.cmdFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 30);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cmdMinimizar
            // 
            this.cmdMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdMinimizar.FlatAppearance.BorderSize = 0;
            this.cmdMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizar.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.cmdMinimizar.ForeColor = System.Drawing.Color.White;
            this.cmdMinimizar.Location = new System.Drawing.Point(604, -23);
            this.cmdMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.cmdMinimizar.Name = "cmdMinimizar";
            this.cmdMinimizar.Size = new System.Drawing.Size(40, 54);
            this.cmdMinimizar.TabIndex = 1;
            this.cmdMinimizar.Text = "-";
            this.cmdMinimizar.UseVisualStyleBackColor = false;
            this.cmdMinimizar.Click += new System.EventHandler(this.cmdMinimizar_Click);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFechar.FlatAppearance.BorderSize = 0;
            this.cmdFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFechar.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFechar.ForeColor = System.Drawing.Color.White;
            this.cmdFechar.Location = new System.Drawing.Point(644, 0);
            this.cmdFechar.Margin = new System.Windows.Forms.Padding(0);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(40, 30);
            this.cmdFechar.TabIndex = 0;
            this.cmdFechar.Text = "X";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click_1);
            // 
            // cmdJogar
            // 
            this.cmdJogar.ActiveBorderThickness = 1;
            this.cmdJogar.ActiveCornerRadius = 20;
            this.cmdJogar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdJogar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdJogar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdJogar.BackColor = System.Drawing.Color.Blue;
            this.cmdJogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdJogar.BackgroundImage")));
            this.cmdJogar.ButtonText = "JOGAR";
            this.cmdJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdJogar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdJogar.ForeColor = System.Drawing.Color.White;
            this.cmdJogar.IdleBorderThickness = 1;
            this.cmdJogar.IdleCornerRadius = 20;
            this.cmdJogar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdJogar.IdleForecolor = System.Drawing.Color.White;
            this.cmdJogar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdJogar.Location = new System.Drawing.Point(267, 293);
            this.cmdJogar.Margin = new System.Windows.Forms.Padding(0);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(150, 60);
            this.cmdJogar.TabIndex = 4;
            this.cmdJogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdJogar.Click += new System.EventHandler(this.cmdJogar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.ActiveBorderThickness = 1;
            this.cmdSair.ActiveCornerRadius = 20;
            this.cmdSair.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdSair.ActiveForecolor = System.Drawing.Color.White;
            this.cmdSair.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdSair.BackColor = System.Drawing.Color.Blue;
            this.cmdSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSair.BackgroundImage")));
            this.cmdSair.ButtonText = "SAIR";
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdSair.ForeColor = System.Drawing.Color.White;
            this.cmdSair.IdleBorderThickness = 1;
            this.cmdSair.IdleCornerRadius = 20;
            this.cmdSair.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdSair.IdleForecolor = System.Drawing.Color.White;
            this.cmdSair.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdSair.Location = new System.Drawing.Point(267, 429);
            this.cmdSair.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(150, 60);
            this.cmdSair.TabIndex = 6;
            this.cmdSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdPontuacao
            // 
            this.cmdPontuacao.ActiveBorderThickness = 1;
            this.cmdPontuacao.ActiveCornerRadius = 20;
            this.cmdPontuacao.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdPontuacao.ActiveForecolor = System.Drawing.Color.White;
            this.cmdPontuacao.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdPontuacao.BackColor = System.Drawing.Color.Blue;
            this.cmdPontuacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPontuacao.BackgroundImage")));
            this.cmdPontuacao.ButtonText = "PONTUAÇÃO";
            this.cmdPontuacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPontuacao.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdPontuacao.ForeColor = System.Drawing.Color.White;
            this.cmdPontuacao.IdleBorderThickness = 1;
            this.cmdPontuacao.IdleCornerRadius = 20;
            this.cmdPontuacao.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdPontuacao.IdleForecolor = System.Drawing.Color.White;
            this.cmdPontuacao.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdPontuacao.Location = new System.Drawing.Point(267, 361);
            this.cmdPontuacao.Margin = new System.Windows.Forms.Padding(0);
            this.cmdPontuacao.Name = "cmdPontuacao";
            this.cmdPontuacao.Size = new System.Drawing.Size(150, 60);
            this.cmdPontuacao.TabIndex = 5;
            this.cmdPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdPontuacao.Click += new System.EventHandler(this.cmdPontuacao_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::programming_quiz.Properties.Resources.imagem_fundo;
            this.pictureBox2.Location = new System.Drawing.Point(417, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 518);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::programming_quiz.Properties.Resources.imagem_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdJogar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdPontuacao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming-Quiz";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdJogar;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdPontuacao;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdMinimizar;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

