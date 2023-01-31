namespace programming_quiz
{
    partial class frmPontuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPontuacao));
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblTerceiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdMinimizar = new System.Windows.Forms.Button();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.cmdVoltar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.cmdLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimeiro.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiro.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiro.Location = new System.Drawing.Point(144, 178);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(327, 50);
            this.lblPrimeiro.TabIndex = 0;
            this.lblPrimeiro.Text = "label1";
            this.lblPrimeiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSegundo
            // 
            this.lblSegundo.BackColor = System.Drawing.Color.Blue;
            this.lblSegundo.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.White;
            this.lblSegundo.Location = new System.Drawing.Point(144, 292);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(327, 50);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "label2";
            this.lblSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTerceiro
            // 
            this.lblTerceiro.BackColor = System.Drawing.Color.Blue;
            this.lblTerceiro.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerceiro.ForeColor = System.Drawing.Color.White;
            this.lblTerceiro.Location = new System.Drawing.Point(144, 406);
            this.lblTerceiro.Name = "lblTerceiro";
            this.lblTerceiro.Size = new System.Drawing.Size(327, 50);
            this.lblTerceiro.TabIndex = 2;
            this.lblTerceiro.Text = "label3";
            this.lblTerceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Consolas", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "RECORDES";
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
            this.panel1.TabIndex = 6;
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
            this.cmdFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.ActiveBorderThickness = 1;
            this.cmdVoltar.ActiveCornerRadius = 20;
            this.cmdVoltar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdVoltar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdVoltar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdVoltar.BackColor = System.Drawing.Color.Blue;
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
            this.cmdVoltar.Location = new System.Drawing.Point(521, 476);
            this.cmdVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(150, 60);
            this.cmdVoltar.TabIndex = 5;
            this.cmdVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Image = global::programming_quiz.Properties.Resources.estrelas;
            this.pictureBox1.Location = new System.Drawing.Point(50, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Image = global::programming_quiz.Properties.Resources.estrelas;
            this.pictureBox2.Location = new System.Drawing.Point(499, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblP
            // 
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.White;
            this.lblP.Location = new System.Drawing.Point(477, 178);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(194, 50);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "label1";
            this.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblS
            // 
            this.lblS.BackColor = System.Drawing.Color.Blue;
            this.lblS.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.White;
            this.lblS.Location = new System.Drawing.Point(477, 292);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(194, 50);
            this.lblS.TabIndex = 1;
            this.lblS.Text = "label2";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblT
            // 
            this.lblT.BackColor = System.Drawing.Color.Blue;
            this.lblT.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(477, 406);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(194, 50);
            this.lblT.TabIndex = 2;
            this.lblT.Text = "label3";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.ActiveBorderThickness = 1;
            this.cmdLimpar.ActiveCornerRadius = 20;
            this.cmdLimpar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdLimpar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdLimpar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdLimpar.BackColor = System.Drawing.Color.Blue;
            this.cmdLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdLimpar.BackgroundImage")));
            this.cmdLimpar.ButtonText = "LIMPAR";
            this.cmdLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdLimpar.ForeColor = System.Drawing.Color.White;
            this.cmdLimpar.IdleBorderThickness = 1;
            this.cmdLimpar.IdleCornerRadius = 20;
            this.cmdLimpar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdLimpar.IdleForecolor = System.Drawing.Color.White;
            this.cmdLimpar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdLimpar.Location = new System.Drawing.Point(363, 476);
            this.cmdLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(150, 60);
            this.cmdLimpar.TabIndex = 5;
            this.cmdLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // frmPontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::programming_quiz.Properties.Resources.fundo_pontuacao2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTerceiro);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblPrimeiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPontuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontuações";
            this.Load += new System.EventHandler(this.frmPontuacao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblTerceiro;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Button cmdMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblT;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdLimpar;
    }
}