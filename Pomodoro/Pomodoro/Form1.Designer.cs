namespace Pomodoro
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
            components = new System.ComponentModel.Container();
            lbl_Tempo = new Label();
            lbl_TimerView = new Label();
            btn_IniciarCiclo = new Button();
            btn_PausarRelogio = new Button();
            btn_Resetar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Continuar = new Button();
            pb_LuzVerde = new PictureBox();
            pb_LuzVermelha = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            pb_Vermelho_Primeiro25 = new PictureBox();
            pb_Vermelho_Primeiro5 = new PictureBox();
            pb_Vermelho_Segundo25 = new PictureBox();
            pb_Vermelho_Segundo5 = new PictureBox();
            label2 = new Label();
            pb_Verde_Primeiro25 = new PictureBox();
            pb_Verde_Primeiro5 = new PictureBox();
            pb_Verde_Segundo25 = new PictureBox();
            pb_Verde_Segundo5 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_ContinuarCiclo = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_LuzVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_LuzVermelha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Primeiro25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Primeiro5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Segundo25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Segundo5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Primeiro25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Primeiro5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Segundo25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Segundo5).BeginInit();
            SuspendLayout();
            // 
            // lbl_Tempo
            // 
            lbl_Tempo.AutoSize = true;
            lbl_Tempo.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tempo.Location = new Point(12, 35);
            lbl_Tempo.Name = "lbl_Tempo";
            lbl_Tempo.Size = new Size(278, 86);
            lbl_Tempo.TabIndex = 0;
            lbl_Tempo.Text = "Tempo -";
            // 
            // lbl_TimerView
            // 
            lbl_TimerView.AutoSize = true;
            lbl_TimerView.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TimerView.Location = new Point(275, 52);
            lbl_TimerView.Name = "lbl_TimerView";
            lbl_TimerView.Size = new Size(142, 65);
            lbl_TimerView.TabIndex = 1;
            lbl_TimerView.Text = "00:00";
            // 
            // btn_IniciarCiclo
            // 
            btn_IniciarCiclo.Location = new Point(22, 155);
            btn_IniciarCiclo.Name = "btn_IniciarCiclo";
            btn_IniciarCiclo.Size = new Size(114, 41);
            btn_IniciarCiclo.TabIndex = 2;
            btn_IniciarCiclo.Text = "Iniciar Ciclo";
            btn_IniciarCiclo.UseVisualStyleBackColor = true;
            btn_IniciarCiclo.Click += btn_IniciarCiclo_Click;
            // 
            // btn_PausarRelogio
            // 
            btn_PausarRelogio.Location = new Point(22, 212);
            btn_PausarRelogio.Name = "btn_PausarRelogio";
            btn_PausarRelogio.Size = new Size(114, 41);
            btn_PausarRelogio.TabIndex = 3;
            btn_PausarRelogio.Text = "Pausar Relógio";
            btn_PausarRelogio.UseVisualStyleBackColor = true;
            btn_PausarRelogio.Click += btn_PausarRelogio_Click;
            // 
            // btn_Resetar
            // 
            btn_Resetar.Location = new Point(684, 226);
            btn_Resetar.Name = "btn_Resetar";
            btn_Resetar.Size = new Size(95, 41);
            btn_Resetar.TabIndex = 4;
            btn_Resetar.Text = "Resetar";
            btn_Resetar.UseVisualStyleBackColor = true;
            btn_Resetar.Click += btn_Resetar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_Continuar
            // 
            btn_Continuar.Location = new Point(153, 212);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(114, 41);
            btn_Continuar.TabIndex = 5;
            btn_Continuar.Text = "Continuar Relógio";
            btn_Continuar.UseVisualStyleBackColor = true;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // pb_LuzVerde
            // 
            pb_LuzVerde.Image = Properties.Resources.luz_verde;
            pb_LuzVerde.Location = new Point(423, 69);
            pb_LuzVerde.Name = "pb_LuzVerde";
            pb_LuzVerde.Size = new Size(35, 36);
            pb_LuzVerde.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_LuzVerde.TabIndex = 6;
            pb_LuzVerde.TabStop = false;
            // 
            // pb_LuzVermelha
            // 
            pb_LuzVermelha.Image = Properties.Resources.luz_vermelha;
            pb_LuzVermelha.Location = new Point(423, 69);
            pb_LuzVermelha.Name = "pb_LuzVermelha";
            pb_LuzVermelha.Size = new Size(35, 36);
            pb_LuzVermelha.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_LuzVermelha.TabIndex = 7;
            pb_LuzVermelha.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(436, 23);
            progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(633, 26);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 9;
            label1.Text = "Ciclo - 1 Hora";
            // 
            // pb_Vermelho_Primeiro25
            // 
            pb_Vermelho_Primeiro25.Image = Properties.Resources.luz_vermelha;
            pb_Vermelho_Primeiro25.Location = new Point(762, 69);
            pb_Vermelho_Primeiro25.Name = "pb_Vermelho_Primeiro25";
            pb_Vermelho_Primeiro25.Size = new Size(17, 18);
            pb_Vermelho_Primeiro25.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Vermelho_Primeiro25.TabIndex = 10;
            pb_Vermelho_Primeiro25.TabStop = false;
            // 
            // pb_Vermelho_Primeiro5
            // 
            pb_Vermelho_Primeiro5.Image = Properties.Resources.luz_vermelha;
            pb_Vermelho_Primeiro5.Location = new Point(762, 103);
            pb_Vermelho_Primeiro5.Name = "pb_Vermelho_Primeiro5";
            pb_Vermelho_Primeiro5.Size = new Size(17, 18);
            pb_Vermelho_Primeiro5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Vermelho_Primeiro5.TabIndex = 11;
            pb_Vermelho_Primeiro5.TabStop = false;
            // 
            // pb_Vermelho_Segundo25
            // 
            pb_Vermelho_Segundo25.Image = Properties.Resources.luz_vermelha;
            pb_Vermelho_Segundo25.Location = new Point(762, 139);
            pb_Vermelho_Segundo25.Name = "pb_Vermelho_Segundo25";
            pb_Vermelho_Segundo25.Size = new Size(17, 18);
            pb_Vermelho_Segundo25.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Vermelho_Segundo25.TabIndex = 12;
            pb_Vermelho_Segundo25.TabStop = false;
            // 
            // pb_Vermelho_Segundo5
            // 
            pb_Vermelho_Segundo5.Image = Properties.Resources.luz_vermelha;
            pb_Vermelho_Segundo5.Location = new Point(762, 178);
            pb_Vermelho_Segundo5.Name = "pb_Vermelho_Segundo5";
            pb_Vermelho_Segundo5.Size = new Size(17, 18);
            pb_Vermelho_Segundo5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Vermelho_Segundo5.TabIndex = 13;
            pb_Vermelho_Segundo5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(650, 66);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 14;
            label2.Text = "1. 25 Minutos";
            // 
            // pb_Verde_Primeiro25
            // 
            pb_Verde_Primeiro25.Image = Properties.Resources.luz_verde;
            pb_Verde_Primeiro25.Location = new Point(762, 69);
            pb_Verde_Primeiro25.Name = "pb_Verde_Primeiro25";
            pb_Verde_Primeiro25.Size = new Size(17, 18);
            pb_Verde_Primeiro25.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Verde_Primeiro25.TabIndex = 15;
            pb_Verde_Primeiro25.TabStop = false;
            // 
            // pb_Verde_Primeiro5
            // 
            pb_Verde_Primeiro5.Image = Properties.Resources.luz_verde;
            pb_Verde_Primeiro5.Location = new Point(762, 103);
            pb_Verde_Primeiro5.Name = "pb_Verde_Primeiro5";
            pb_Verde_Primeiro5.Size = new Size(17, 18);
            pb_Verde_Primeiro5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Verde_Primeiro5.TabIndex = 16;
            pb_Verde_Primeiro5.TabStop = false;
            // 
            // pb_Verde_Segundo25
            // 
            pb_Verde_Segundo25.Image = Properties.Resources.luz_verde;
            pb_Verde_Segundo25.Location = new Point(762, 139);
            pb_Verde_Segundo25.Name = "pb_Verde_Segundo25";
            pb_Verde_Segundo25.Size = new Size(17, 18);
            pb_Verde_Segundo25.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Verde_Segundo25.TabIndex = 17;
            pb_Verde_Segundo25.TabStop = false;
            // 
            // pb_Verde_Segundo5
            // 
            pb_Verde_Segundo5.Image = Properties.Resources.luz_verde;
            pb_Verde_Segundo5.Location = new Point(762, 178);
            pb_Verde_Segundo5.Name = "pb_Verde_Segundo5";
            pb_Verde_Segundo5.Size = new Size(17, 18);
            pb_Verde_Segundo5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Verde_Segundo5.TabIndex = 18;
            pb_Verde_Segundo5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(650, 100);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 19;
            label3.Text = "1. 05 Minutos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(650, 136);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 20;
            label4.Text = "2. 25 Minutos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(650, 175);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 21;
            label5.Text = "2. 05 Minutos";
            // 
            // btn_ContinuarCiclo
            // 
            btn_ContinuarCiclo.Location = new Point(153, 155);
            btn_ContinuarCiclo.Name = "btn_ContinuarCiclo";
            btn_ContinuarCiclo.Size = new Size(114, 41);
            btn_ContinuarCiclo.TabIndex = 22;
            btn_ContinuarCiclo.Text = "Continuar Ciclo";
            btn_ContinuarCiclo.UseVisualStyleBackColor = true;
            btn_ContinuarCiclo.Click += btn_ContinuarCiclo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(btn_ContinuarCiclo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pb_Verde_Segundo5);
            Controls.Add(pb_Verde_Segundo25);
            Controls.Add(pb_Verde_Primeiro5);
            Controls.Add(pb_Verde_Primeiro25);
            Controls.Add(label2);
            Controls.Add(pb_Vermelho_Segundo5);
            Controls.Add(pb_Vermelho_Segundo25);
            Controls.Add(pb_Vermelho_Primeiro5);
            Controls.Add(pb_Vermelho_Primeiro25);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(pb_LuzVermelha);
            Controls.Add(pb_LuzVerde);
            Controls.Add(btn_Continuar);
            Controls.Add(btn_Resetar);
            Controls.Add(btn_PausarRelogio);
            Controls.Add(btn_IniciarCiclo);
            Controls.Add(lbl_TimerView);
            Controls.Add(lbl_Tempo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_LuzVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_LuzVermelha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Primeiro25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Primeiro5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Segundo25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Vermelho_Segundo5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Primeiro25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Primeiro5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Segundo25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Verde_Segundo5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Tempo;
        private Label lbl_TimerView;
        private Button btn_IniciarCiclo;
        private Button btn_PausarRelogio;
        private Button btn_Resetar;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Continuar;
        private PictureBox pb_LuzVerde;
        private PictureBox pb_LuzVermelha;
        private ProgressBar progressBar1;
        private Label label1;
        private PictureBox pb_Vermelho_Primeiro25;
        private PictureBox pb_Vermelho_Primeiro5;
        private PictureBox pb_Vermelho_Segundo25;
        private PictureBox pb_Vermelho_Segundo5;
        private Label label2;
        private PictureBox pb_Verde_Primeiro25;
        private PictureBox pb_Verde_Primeiro5;
        private PictureBox pb_Verde_Segundo25;
        private PictureBox pb_Verde_Segundo5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_ContinuarCiclo;
    }
}