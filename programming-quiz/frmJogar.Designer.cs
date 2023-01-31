namespace programming_quiz
{
    partial class frmJogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogar));
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblRespondidas = new System.Windows.Forms.Label();
            this.cmdOpcaoD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdOpcaoC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdOpcaoB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdOpcaoA = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdAjudaMostrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdAjudaPular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdAjudaDuas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdMinimizar = new System.Windows.Forms.Button();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.areaJogo = new System.Windows.Forms.Panel();
            this.pbTemporizador = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.areaJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblPergunta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.White;
            this.lblPergunta.Location = new System.Drawing.Point(12, 105);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(660, 100);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "label1";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRespondidas
            // 
            this.lblRespondidas.AutoSize = true;
            this.lblRespondidas.BackColor = System.Drawing.Color.Transparent;
            this.lblRespondidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondidas.ForeColor = System.Drawing.Color.White;
            this.lblRespondidas.Location = new System.Drawing.Point(522, 59);
            this.lblRespondidas.Name = "lblRespondidas";
            this.lblRespondidas.Size = new System.Drawing.Size(122, 26);
            this.lblRespondidas.TabIndex = 8;
            this.lblRespondidas.Text = "Pontos: 0pt";
            // 
            // cmdOpcaoD
            // 
            this.cmdOpcaoD.ActiveBorderThickness = 1;
            this.cmdOpcaoD.ActiveCornerRadius = 60;
            this.cmdOpcaoD.ActiveFillColor = System.Drawing.Color.Gold;
            this.cmdOpcaoD.ActiveForecolor = System.Drawing.Color.White;
            this.cmdOpcaoD.ActiveLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoD.BackColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdOpcaoD.BackgroundImage")));
            this.cmdOpcaoD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpcaoD.ButtonText = "";
            this.cmdOpcaoD.CausesValidation = false;
            this.cmdOpcaoD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpcaoD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpcaoD.ForeColor = System.Drawing.Color.White;
            this.cmdOpcaoD.IdleBorderThickness = 1;
            this.cmdOpcaoD.IdleCornerRadius = 60;
            this.cmdOpcaoD.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdOpcaoD.IdleForecolor = System.Drawing.Color.White;
            this.cmdOpcaoD.IdleLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdOpcaoD.Location = new System.Drawing.Point(92, 407);
            this.cmdOpcaoD.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOpcaoD.Name = "cmdOpcaoD";
            this.cmdOpcaoD.Size = new System.Drawing.Size(500, 60);
            this.cmdOpcaoD.TabIndex = 4;
            this.cmdOpcaoD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdOpcaoD.Click += new System.EventHandler(this.cmdOpcaoD_Click);
            // 
            // cmdOpcaoC
            // 
            this.cmdOpcaoC.ActiveBorderThickness = 1;
            this.cmdOpcaoC.ActiveCornerRadius = 60;
            this.cmdOpcaoC.ActiveFillColor = System.Drawing.Color.Gold;
            this.cmdOpcaoC.ActiveForecolor = System.Drawing.Color.White;
            this.cmdOpcaoC.ActiveLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoC.BackColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdOpcaoC.BackgroundImage")));
            this.cmdOpcaoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpcaoC.ButtonText = "";
            this.cmdOpcaoC.CausesValidation = false;
            this.cmdOpcaoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpcaoC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpcaoC.ForeColor = System.Drawing.Color.White;
            this.cmdOpcaoC.IdleBorderThickness = 1;
            this.cmdOpcaoC.IdleCornerRadius = 60;
            this.cmdOpcaoC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdOpcaoC.IdleForecolor = System.Drawing.Color.White;
            this.cmdOpcaoC.IdleLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdOpcaoC.Location = new System.Drawing.Point(92, 347);
            this.cmdOpcaoC.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOpcaoC.Name = "cmdOpcaoC";
            this.cmdOpcaoC.Size = new System.Drawing.Size(500, 60);
            this.cmdOpcaoC.TabIndex = 3;
            this.cmdOpcaoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdOpcaoC.Click += new System.EventHandler(this.cmdOpcaoC_Click);
            // 
            // cmdOpcaoB
            // 
            this.cmdOpcaoB.ActiveBorderThickness = 1;
            this.cmdOpcaoB.ActiveCornerRadius = 60;
            this.cmdOpcaoB.ActiveFillColor = System.Drawing.Color.Gold;
            this.cmdOpcaoB.ActiveForecolor = System.Drawing.Color.White;
            this.cmdOpcaoB.ActiveLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoB.BackColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdOpcaoB.BackgroundImage")));
            this.cmdOpcaoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpcaoB.ButtonText = "";
            this.cmdOpcaoB.CausesValidation = false;
            this.cmdOpcaoB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpcaoB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpcaoB.ForeColor = System.Drawing.Color.White;
            this.cmdOpcaoB.IdleBorderThickness = 1;
            this.cmdOpcaoB.IdleCornerRadius = 60;
            this.cmdOpcaoB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdOpcaoB.IdleForecolor = System.Drawing.Color.White;
            this.cmdOpcaoB.IdleLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdOpcaoB.Location = new System.Drawing.Point(92, 287);
            this.cmdOpcaoB.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOpcaoB.Name = "cmdOpcaoB";
            this.cmdOpcaoB.Size = new System.Drawing.Size(500, 60);
            this.cmdOpcaoB.TabIndex = 2;
            this.cmdOpcaoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdOpcaoB.Click += new System.EventHandler(this.cmdOpcaoB_Click);
            // 
            // cmdOpcaoA
            // 
            this.cmdOpcaoA.ActiveBorderThickness = 1;
            this.cmdOpcaoA.ActiveCornerRadius = 60;
            this.cmdOpcaoA.ActiveFillColor = System.Drawing.Color.Gold;
            this.cmdOpcaoA.ActiveForecolor = System.Drawing.Color.White;
            this.cmdOpcaoA.ActiveLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoA.BackColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdOpcaoA.BackgroundImage")));
            this.cmdOpcaoA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdOpcaoA.ButtonText = "";
            this.cmdOpcaoA.CausesValidation = false;
            this.cmdOpcaoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpcaoA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpcaoA.ForeColor = System.Drawing.Color.White;
            this.cmdOpcaoA.IdleBorderThickness = 1;
            this.cmdOpcaoA.IdleCornerRadius = 60;
            this.cmdOpcaoA.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.cmdOpcaoA.IdleForecolor = System.Drawing.Color.White;
            this.cmdOpcaoA.IdleLineColor = System.Drawing.Color.Transparent;
            this.cmdOpcaoA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdOpcaoA.Location = new System.Drawing.Point(92, 227);
            this.cmdOpcaoA.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOpcaoA.Name = "cmdOpcaoA";
            this.cmdOpcaoA.Size = new System.Drawing.Size(500, 60);
            this.cmdOpcaoA.TabIndex = 1;
            this.cmdOpcaoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdOpcaoA.Click += new System.EventHandler(this.cmdOpcaoA_Click);
            // 
            // cmdAjudaMostrar
            // 
            this.cmdAjudaMostrar.ActiveBorderThickness = 1;
            this.cmdAjudaMostrar.ActiveCornerRadius = 20;
            this.cmdAjudaMostrar.ActiveFillColor = System.Drawing.Color.Lime;
            this.cmdAjudaMostrar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdAjudaMostrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaMostrar.BackColor = System.Drawing.Color.Transparent;
            this.cmdAjudaMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAjudaMostrar.BackgroundImage")));
            this.cmdAjudaMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAjudaMostrar.ButtonText = "MOSTRAR";
            this.cmdAjudaMostrar.CausesValidation = false;
            this.cmdAjudaMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAjudaMostrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjudaMostrar.ForeColor = System.Drawing.Color.White;
            this.cmdAjudaMostrar.IdleBorderThickness = 1;
            this.cmdAjudaMostrar.IdleCornerRadius = 20;
            this.cmdAjudaMostrar.IdleFillColor = System.Drawing.Color.Chartreuse;
            this.cmdAjudaMostrar.IdleForecolor = System.Drawing.Color.White;
            this.cmdAjudaMostrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaMostrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdAjudaMostrar.Location = new System.Drawing.Point(183, 465);
            this.cmdAjudaMostrar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdAjudaMostrar.Name = "cmdAjudaMostrar";
            this.cmdAjudaMostrar.Size = new System.Drawing.Size(100, 50);
            this.cmdAjudaMostrar.TabIndex = 5;
            this.cmdAjudaMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAjudaMostrar.Click += new System.EventHandler(this.cmdAjudaMostrar_Click_1);
            // 
            // cmdAjudaPular
            // 
            this.cmdAjudaPular.ActiveBorderThickness = 1;
            this.cmdAjudaPular.ActiveCornerRadius = 20;
            this.cmdAjudaPular.ActiveFillColor = System.Drawing.Color.Lime;
            this.cmdAjudaPular.ActiveForecolor = System.Drawing.Color.White;
            this.cmdAjudaPular.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaPular.BackColor = System.Drawing.Color.Transparent;
            this.cmdAjudaPular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAjudaPular.BackgroundImage")));
            this.cmdAjudaPular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAjudaPular.ButtonText = "PULAR";
            this.cmdAjudaPular.CausesValidation = false;
            this.cmdAjudaPular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAjudaPular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjudaPular.ForeColor = System.Drawing.Color.White;
            this.cmdAjudaPular.IdleBorderThickness = 1;
            this.cmdAjudaPular.IdleCornerRadius = 20;
            this.cmdAjudaPular.IdleFillColor = System.Drawing.Color.Chartreuse;
            this.cmdAjudaPular.IdleForecolor = System.Drawing.Color.White;
            this.cmdAjudaPular.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaPular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdAjudaPular.Location = new System.Drawing.Point(293, 465);
            this.cmdAjudaPular.Margin = new System.Windows.Forms.Padding(5);
            this.cmdAjudaPular.Name = "cmdAjudaPular";
            this.cmdAjudaPular.Size = new System.Drawing.Size(100, 50);
            this.cmdAjudaPular.TabIndex = 6;
            this.cmdAjudaPular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAjudaPular.Click += new System.EventHandler(this.cmdAjudaPular_Click_1);
            // 
            // cmdAjudaDuas
            // 
            this.cmdAjudaDuas.ActiveBorderThickness = 1;
            this.cmdAjudaDuas.ActiveCornerRadius = 20;
            this.cmdAjudaDuas.ActiveFillColor = System.Drawing.Color.Lime;
            this.cmdAjudaDuas.ActiveForecolor = System.Drawing.Color.White;
            this.cmdAjudaDuas.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaDuas.BackColor = System.Drawing.Color.Transparent;
            this.cmdAjudaDuas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAjudaDuas.BackgroundImage")));
            this.cmdAjudaDuas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAjudaDuas.ButtonText = "50/50";
            this.cmdAjudaDuas.CausesValidation = false;
            this.cmdAjudaDuas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAjudaDuas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjudaDuas.ForeColor = System.Drawing.Color.White;
            this.cmdAjudaDuas.IdleBorderThickness = 1;
            this.cmdAjudaDuas.IdleCornerRadius = 20;
            this.cmdAjudaDuas.IdleFillColor = System.Drawing.Color.Chartreuse;
            this.cmdAjudaDuas.IdleForecolor = System.Drawing.Color.White;
            this.cmdAjudaDuas.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.cmdAjudaDuas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdAjudaDuas.Location = new System.Drawing.Point(403, 465);
            this.cmdAjudaDuas.Margin = new System.Windows.Forms.Padding(5);
            this.cmdAjudaDuas.Name = "cmdAjudaDuas";
            this.cmdAjudaDuas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAjudaDuas.Size = new System.Drawing.Size(100, 50);
            this.cmdAjudaDuas.TabIndex = 7;
            this.cmdAjudaDuas.Tag = "";
            this.cmdAjudaDuas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAjudaDuas.Click += new System.EventHandler(this.cmdAjudaDuas_Click_1);
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
            this.panel1.TabIndex = 17;
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
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // areaJogo
            // 
            this.areaJogo.BackColor = System.Drawing.Color.Transparent;
            this.areaJogo.Controls.Add(this.lblTempo);
            this.areaJogo.Controls.Add(this.lblPergunta);
            this.areaJogo.Controls.Add(this.pbTemporizador);
            this.areaJogo.Controls.Add(this.cmdOpcaoD);
            this.areaJogo.Controls.Add(this.cmdOpcaoC);
            this.areaJogo.Controls.Add(this.cmdOpcaoB);
            this.areaJogo.Controls.Add(this.cmdOpcaoA);
            this.areaJogo.Controls.Add(this.lblRespondidas);
            this.areaJogo.Controls.Add(this.cmdAjudaDuas);
            this.areaJogo.Controls.Add(this.cmdAjudaPular);
            this.areaJogo.Controls.Add(this.cmdAjudaMostrar);
            this.areaJogo.Location = new System.Drawing.Point(0, 30);
            this.areaJogo.Margin = new System.Windows.Forms.Padding(0);
            this.areaJogo.Name = "areaJogo";
            this.areaJogo.Size = new System.Drawing.Size(684, 522);
            this.areaJogo.TabIndex = 18;
            // 
            // pbTemporizador
            // 
            this.pbTemporizador.animated = true;
            this.pbTemporizador.animationIterval = 5;
            this.pbTemporizador.animationSpeed = 300;
            this.pbTemporizador.BackColor = System.Drawing.Color.Transparent;
            this.pbTemporizador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTemporizador.BackgroundImage")));
            this.pbTemporizador.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.pbTemporizador.ForeColor = System.Drawing.Color.DarkBlue;
            this.pbTemporizador.LabelVisible = false;
            this.pbTemporizador.LineProgressThickness = 8;
            this.pbTemporizador.LineThickness = 5;
            this.pbTemporizador.Location = new System.Drawing.Point(287, 0);
            this.pbTemporizador.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.pbTemporizador.MaxValue = 30;
            this.pbTemporizador.Name = "pbTemporizador";
            this.pbTemporizador.ProgressBackColor = System.Drawing.Color.DodgerBlue;
            this.pbTemporizador.ProgressColor = System.Drawing.Color.DarkBlue;
            this.pbTemporizador.Size = new System.Drawing.Size(110, 110);
            this.pbTemporizador.TabIndex = 9;
            this.pbTemporizador.Value = 0;
            // 
            // temporizador
            // 
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTempo.Location = new System.Drawing.Point(316, 39);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(46, 38);
            this.lblTempo.TabIndex = 10;
            this.lblTempo.Text = "0s";
            // 
            // frmJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::programming_quiz.Properties.Resources.imagem_fundo_jogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 550);
            this.Controls.Add(this.areaJogo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmJogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming-Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJogar_FormClosing);
            this.Shown += new System.EventHandler(this.frmJogar_Shown);
            this.panel1.ResumeLayout(false);
            this.areaJogo.ResumeLayout(false);
            this.areaJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblRespondidas;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdAjudaPular;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdAjudaMostrar;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdOpcaoA;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdOpcaoB;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdOpcaoC;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdOpcaoD;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdAjudaDuas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdMinimizar;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Panel areaJogo;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbTemporizador;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Label lblTempo;
    }
}