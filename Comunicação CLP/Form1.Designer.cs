namespace Comunicação_CLP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.BTNligar = new System.Windows.Forms.Button();
            this.BTNdesligar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CBXescolha = new System.Windows.Forms.ComboBox();
            this.LBLtitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Controls.Add(this.Maximizar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Fechar
            // 
            this.Fechar.BackgroundImage = global::Comunicação_CLP.Properties.Resources.fechar_icon;
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Location = new System.Drawing.Point(755, 12);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(33, 33);
            this.Fechar.TabIndex = 1;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            this.Fechar.MouseLeave += new System.EventHandler(this.Fechar_MouseLeave);
            this.Fechar.MouseHover += new System.EventHandler(this.Fechar_MouseHover);
            // 
            // Maximizar
            // 
            this.Maximizar.BackgroundImage = global::Comunicação_CLP.Properties.Resources.maximizar_icon;
            this.Maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximizar.Enabled = false;
            this.Maximizar.Location = new System.Drawing.Point(704, 12);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(33, 33);
            this.Maximizar.TabIndex = 2;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            this.Maximizar.MouseLeave += new System.EventHandler(this.Maximizar_MouseLeave);
            this.Maximizar.MouseHover += new System.EventHandler(this.Maximizar_MouseHover);
            // 
            // Minimizar
            // 
            this.Minimizar.BackgroundImage = global::Comunicação_CLP.Properties.Resources.minimizar_icon;
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.Location = new System.Drawing.Point(653, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(33, 33);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            this.Minimizar.MouseLeave += new System.EventHandler(this.Minimizar_MouseLeave);
            this.Minimizar.MouseHover += new System.EventHandler(this.Minimizar_MouseHover);
            // 
            // BTNligar
            // 
            this.BTNligar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNligar.Location = new System.Drawing.Point(85, 336);
            this.BTNligar.Name = "BTNligar";
            this.BTNligar.Size = new System.Drawing.Size(269, 56);
            this.BTNligar.TabIndex = 2;
            this.BTNligar.Text = "Ligar";
            this.BTNligar.UseVisualStyleBackColor = false;
            this.BTNligar.Click += new System.EventHandler(this.BTNligar_Click);
            this.BTNligar.MouseLeave += new System.EventHandler(this.BTNligar_MouseLeave);
            this.BTNligar.MouseHover += new System.EventHandler(this.BTNligar_MouseHover);
            // 
            // BTNdesligar
            // 
            this.BTNdesligar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNdesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdesligar.Location = new System.Drawing.Point(497, 336);
            this.BTNdesligar.Name = "BTNdesligar";
            this.BTNdesligar.Size = new System.Drawing.Size(240, 56);
            this.BTNdesligar.TabIndex = 3;
            this.BTNdesligar.Text = "Desligar";
            this.BTNdesligar.UseVisualStyleBackColor = false;
            this.BTNdesligar.Click += new System.EventHandler(this.button2_Click);
            this.BTNdesligar.MouseLeave += new System.EventHandler(this.BTNdesligar_MouseLeave);
            this.BTNdesligar.MouseHover += new System.EventHandler(this.BTNdesligar_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CBXescolha
            // 
            this.CBXescolha.FormattingEnabled = true;
            this.CBXescolha.Location = new System.Drawing.Point(295, 166);
            this.CBXescolha.Name = "CBXescolha";
            this.CBXescolha.Size = new System.Drawing.Size(221, 21);
            this.CBXescolha.TabIndex = 5;
            // 
            // LBLtitle
            // 
            this.LBLtitle.AutoSize = true;
            this.LBLtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtitle.Location = new System.Drawing.Point(213, 111);
            this.LBLtitle.Name = "LBLtitle";
            this.LBLtitle.Size = new System.Drawing.Size(375, 37);
            this.LBLtitle.TabIndex = 6;
            this.LBLtitle.Text = "SELECIONE UMA PEÇA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLtitle);
            this.Controls.Add(this.CBXescolha);
            this.Controls.Add(this.BTNdesligar);
            this.Controls.Add(this.BTNligar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button BTNligar;
        private System.Windows.Forms.Button BTNdesligar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CBXescolha;
        private System.Windows.Forms.Label LBLtitle;
    }
}

