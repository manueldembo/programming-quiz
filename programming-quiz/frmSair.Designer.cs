namespace programming_quiz
{
    partial class frmSair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSair));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cmdNao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdSim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(42, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sair";
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 43);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(276, 66);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Deseja sair do jogo?";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdNao
            // 
            this.cmdNao.ActiveBorderThickness = 1;
            this.cmdNao.ActiveCornerRadius = 20;
            this.cmdNao.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdNao.ActiveForecolor = System.Drawing.Color.White;
            this.cmdNao.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdNao.BackColor = System.Drawing.Color.Navy;
            this.cmdNao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdNao.BackgroundImage")));
            this.cmdNao.ButtonText = "NÃO";
            this.cmdNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNao.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdNao.ForeColor = System.Drawing.Color.White;
            this.cmdNao.IdleBorderThickness = 1;
            this.cmdNao.IdleCornerRadius = 20;
            this.cmdNao.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdNao.IdleForecolor = System.Drawing.Color.White;
            this.cmdNao.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdNao.Location = new System.Drawing.Point(154, 114);
            this.cmdNao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdNao.Name = "cmdNao";
            this.cmdNao.Size = new System.Drawing.Size(100, 50);
            this.cmdNao.TabIndex = 4;
            this.cmdNao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdNao.Click += new System.EventHandler(this.cmdNao_Click);
            // 
            // cmdSim
            // 
            this.cmdSim.ActiveBorderThickness = 1;
            this.cmdSim.ActiveCornerRadius = 20;
            this.cmdSim.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.cmdSim.ActiveForecolor = System.Drawing.Color.White;
            this.cmdSim.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdSim.BackColor = System.Drawing.Color.Navy;
            this.cmdSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSim.BackgroundImage")));
            this.cmdSim.ButtonText = "SIM";
            this.cmdSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSim.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmdSim.ForeColor = System.Drawing.Color.White;
            this.cmdSim.IdleBorderThickness = 1;
            this.cmdSim.IdleCornerRadius = 20;
            this.cmdSim.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdSim.IdleForecolor = System.Drawing.Color.White;
            this.cmdSim.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdSim.Location = new System.Drawing.Point(46, 114);
            this.cmdSim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSim.Name = "cmdSim";
            this.cmdSim.Size = new System.Drawing.Size(100, 50);
            this.cmdSim.TabIndex = 4;
            this.cmdSim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdSim.Click += new System.EventHandler(this.cmdSim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.cmdFechar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 30);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFechar.FlatAppearance.BorderSize = 0;
            this.cmdFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFechar.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFechar.ForeColor = System.Drawing.Color.White;
            this.cmdFechar.Location = new System.Drawing.Point(260, 0);
            this.cmdFechar.Margin = new System.Windows.Forms.Padding(0);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(40, 30);
            this.cmdFechar.TabIndex = 0;
            this.cmdFechar.Text = "X";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // frmSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdSim);
            this.Controls.Add(this.cmdNao);
            this.Controls.Add(this.lblTexto);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSair";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdNao;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdSim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdFechar;
    }
}