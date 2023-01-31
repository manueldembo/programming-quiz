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
            this.cmd_jogar = new System.Windows.Forms.Button();
            this.cmd_pontuacao = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_jogar
            // 
            this.cmd_jogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_jogar.BackgroundImage")));
            this.cmd_jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_jogar.FlatAppearance.BorderSize = 0;
            this.cmd_jogar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd_jogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_jogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_jogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_jogar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_jogar.ForeColor = System.Drawing.Color.White;
            this.cmd_jogar.Location = new System.Drawing.Point(167, 187);
            this.cmd_jogar.Name = "cmd_jogar";
            this.cmd_jogar.Size = new System.Drawing.Size(150, 50);
            this.cmd_jogar.TabIndex = 0;
            this.cmd_jogar.Text = "Jogar";
            this.cmd_jogar.UseVisualStyleBackColor = true;
            this.cmd_jogar.Click += new System.EventHandler(this.cmd_jogar_Click);
            // 
            // cmd_pontuacao
            // 
            this.cmd_pontuacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_pontuacao.BackgroundImage")));
            this.cmd_pontuacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_pontuacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pontuacao.FlatAppearance.BorderSize = 0;
            this.cmd_pontuacao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd_pontuacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_pontuacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_pontuacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_pontuacao.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_pontuacao.ForeColor = System.Drawing.Color.White;
            this.cmd_pontuacao.Location = new System.Drawing.Point(167, 243);
            this.cmd_pontuacao.Name = "cmd_pontuacao";
            this.cmd_pontuacao.Size = new System.Drawing.Size(150, 50);
            this.cmd_pontuacao.TabIndex = 1;
            this.cmd_pontuacao.Text = "Pontuacao";
            this.cmd_pontuacao.UseVisualStyleBackColor = true;
            this.cmd_pontuacao.Click += new System.EventHandler(this.cmd_pontuacao_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_sair.BackgroundImage")));
            this.cmd_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_sair.FlatAppearance.BorderSize = 0;
            this.cmd_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cmd_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_sair.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sair.ForeColor = System.Drawing.Color.White;
            this.cmd_sair.Location = new System.Drawing.Point(167, 299);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(150, 50);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programming-Quiz";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pontuacao);
            this.Controls.Add(this.cmd_jogar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming-Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_jogar;
        private System.Windows.Forms.Button cmd_pontuacao;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label1;
    }
}

