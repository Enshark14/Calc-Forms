namespace Calc_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnC = new Button();
            btnApaga = new Button();
            btnCE = new Button();
            btnPorcento = new Button();
            btnDivide = new Button();
            btnVezes = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnMenos = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnMais = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btnZero = new Button();
            btnMaisMenos = new Button();
            panel1 = new Panel();
            Painel = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnC.Location = new Point(172, 194);
            btnC.Name = "btnC";
            btnC.Size = new Size(71, 44);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnApaga
            // 
            btnApaga.BackColor = SystemColors.ActiveCaption;
            btnApaga.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnApaga.Location = new Point(16, 144);
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(308, 44);
            btnApaga.TabIndex = 5;
            btnApaga.Text = "<--";
            btnApaga.UseVisualStyleBackColor = false;
            btnApaga.Click += btnApaga_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCE.Location = new Point(95, 194);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(71, 44);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnPorcento
            // 
            btnPorcento.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPorcento.Location = new Point(16, 194);
            btnPorcento.Name = "btnPorcento";
            btnPorcento.Size = new Size(65, 44);
            btnPorcento.TabIndex = 0;
            btnPorcento.Text = "%";
            btnPorcento.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDivide.Location = new Point(253, 194);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(71, 46);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperacao_Click;
            // 
            // btnVezes
            // 
            btnVezes.BackColor = SystemColors.ActiveCaption;
            btnVezes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVezes.Location = new Point(253, 246);
            btnVezes.Name = "btnVezes";
            btnVezes.Size = new Size(71, 50);
            btnVezes.TabIndex = 13;
            btnVezes.Text = "x";
            btnVezes.UseVisualStyleBackColor = false;
            btnVezes.Click += btnOperacao_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.ButtonShadow;
            btnNove.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNove.Location = new Point(172, 246);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(71, 50);
            btnNove.TabIndex = 12;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNumber_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.ButtonShadow;
            btnOito.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnOito.Location = new Point(91, 246);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(71, 50);
            btnOito.TabIndex = 11;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnNumber_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.ButtonShadow;
            btnSete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSete.Location = new Point(16, 246);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(65, 50);
            btnSete.TabIndex = 10;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnNumber_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = SystemColors.ActiveCaption;
            btnMenos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMenos.Location = new Point(253, 302);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(71, 39);
            btnMenos.TabIndex = 17;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnOperacao_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.ButtonShadow;
            btnSeis.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSeis.Location = new Point(172, 302);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(71, 39);
            btnSeis.TabIndex = 16;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnNumber_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.ButtonShadow;
            btnCinco.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCinco.Location = new Point(91, 302);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(71, 39);
            btnCinco.TabIndex = 15;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnNumber_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.ButtonShadow;
            btnQuatro.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnQuatro.Location = new Point(16, 302);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(65, 39);
            btnQuatro.TabIndex = 14;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnNumber_Click;
            // 
            // btnMais
            // 
            btnMais.BackColor = SystemColors.ActiveCaption;
            btnMais.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMais.Location = new Point(253, 347);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(71, 45);
            btnMais.TabIndex = 21;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            btnMais.Click += btnOperacao_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.ButtonShadow;
            btnTres.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTres.Location = new Point(172, 347);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(71, 45);
            btnTres.TabIndex = 20;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnNumber_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.ButtonShadow;
            btnDois.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDois.Location = new Point(91, 347);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(71, 45);
            btnDois.TabIndex = 19;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnNumber_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.ButtonShadow;
            btnUm.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnUm.Location = new Point(16, 347);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(65, 45);
            btnUm.TabIndex = 18;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnNumber_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.HotTrack;
            btnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnIgual.Location = new Point(253, 398);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(71, 40);
            btnIgual.TabIndex = 25;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVirgula.Location = new Point(172, 398);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(71, 40);
            btnVirgula.TabIndex = 24;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ButtonShadow;
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnZero.Location = new Point(91, 398);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(71, 40);
            btnZero.TabIndex = 23;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnNumber_Click;
            // 
            // btnMaisMenos
            // 
            btnMaisMenos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMaisMenos.Location = new Point(16, 398);
            btnMaisMenos.Name = "btnMaisMenos";
            btnMaisMenos.Size = new Size(65, 40);
            btnMaisMenos.TabIndex = 22;
            btnMaisMenos.Text = "+/-";
            btnMaisMenos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.receita_federal_1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Painel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 126);
            panel1.TabIndex = 26;
            // 
            // Painel
            // 
            Painel.BorderStyle = BorderStyle.None;
            Painel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            Painel.Location = new Point(4, 31);
            Painel.Name = "Painel";
            Painel.Size = new Size(320, 45);
            Painel.TabIndex = 1;
            Painel.Text = "0";
            Painel.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 13);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Leão___Samurai_Cop;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(351, 450);
            Controls.Add(panel1);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnMaisMenos);
            Controls.Add(btnMais);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnMenos);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnVezes);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnDivide);
            Controls.Add(btnApaga);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnPorcento);
            Name = "Form1";
            Text = "Receita_Federal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnC;
        private Button btnApaga;
        private Button btnCE;
        private Button btnPorcento;
        private Button btnDivide;
        private Button btnVezes;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnMenos;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnMais;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnZero;
        private Button btnMaisMenos;
        private Panel panel1;
        private TextBox Painel;
        private Label label1;
    }
}
