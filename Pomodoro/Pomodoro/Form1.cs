
using Pomodoro.Domain.Ciclos;
using System.Diagnostics;

namespace Pomodoro
{
    public partial class Form1 : Form
    {

        bool ativo = false;
        bool pauseState = false;
        int tempoEstudo = 0;
        int minuto = 0;
        int segundo = 0;
        int progBarMax = 0;
        int progBarCount = 0;
        CicloUmaHora ciclo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_TimerView.Text = tempoEstudo.ToString().FormatTimeTwoDigits() + ":" + segundo.ToString().FormatTimeTwoDigits();
            CarregarSinaisDeCiclos();
            MostrarLuzVermelha();

            btn_ContinuarCiclo.Enabled = false;
        }

        private void btn_IniciarCiclo_Click(object sender, EventArgs e)
        {
            MostrarLuzVerde();

            ciclo = new CicloUmaHora(1);
            minuto = ciclo.TempoCiclo();

            ProgBarConfig(minuto);

            ativo = true;
            timer1.Enabled = true;
            btn_IniciarCiclo.Enabled = false;
        }

        private void btn_PausarRelogio_Click(object sender, EventArgs e)
        {
            if(!pauseState && ativo == true)
            {
                pauseState = true;
                ativo = false;
                MostrarLuzVermelha();
            }
        }
        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (pauseState && ativo == false)
            {
                pauseState = false;
                MostrarLuzVerde();
                ativo = true;
            }
        }
        private void btn_ContinuarCiclo_Click(object sender, EventArgs e)
        {
            btn_ContinuarCiclo.Enabled = false;
            minuto = ciclo.TempoCiclo();
            ProgBarConfig(minuto);
            ativo = true;
        }
        private void btn_Resetar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ativo)
                CorrerTempo();
        }

        private void CorrerTempo()
        {
            progBarCount++;
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 5;
                    minuto--;
                }
            }
                        
            lbl_TimerView.Text = minuto.ToString().FormatTimeTwoDigits() + ":" + segundo.ToString().FormatTimeTwoDigits();

            if (progressBar1.Value < progBarMax)
                progressBar1.Value = progBarCount;

            if (minuto == 0 && segundo == 0)
            {
                btn_ContinuarCiclo.Enabled = true;
                ativo = false;
                VerificaCiclo();
            }
        }

        private void VerificaCiclo()
        {
            if (!ciclo.Primeiro25)
            {
                ciclo.Primeiro25 = true;
                pb_Vermelho_Primeiro25.Visible = false;
                pb_Verde_Primeiro25.Visible = true;
            }
            else if (!ciclo.Primeiro5)
            {
                ciclo.Primeiro5 = true;
                pb_Vermelho_Primeiro5.Visible = false;
                pb_Verde_Primeiro5.Visible = true;
            }
            else if (!ciclo.Segundo25)
            {
                ciclo.Segundo25 = true;
                pb_Vermelho_Segundo25.Visible = false;
                pb_Verde_Segundo25.Visible = true;
            }
            else if (!ciclo.Segundo5)
            {
                ciclo.Segundo5 = true;
                pb_Vermelho_Segundo5.Visible = false;
                pb_Verde_Segundo5.Visible = true;
            }
        }


        private void MostrarLuzVerde()
        {
            pb_LuzVerde.Visible = true;
            pb_LuzVermelha.Visible = false;
        }

        private void MostrarLuzVermelha()
        {
            pb_LuzVerde.Visible = false;
            pb_LuzVermelha.Visible = true;
        }

        private void CarregarSinaisDeCiclos()
        {
            pb_Verde_Primeiro25.Visible = false;
            pb_Verde_Primeiro5.Visible = false;
            pb_Verde_Segundo25.Visible = false;
            pb_Verde_Segundo5.Visible = false;

            pb_Vermelho_Primeiro25.Visible = true;
            pb_Vermelho_Primeiro5.Visible = true;
            pb_Vermelho_Segundo25.Visible = true;
            pb_Vermelho_Segundo5.Visible = true;

        }

        private void ProgBarConfig(int tempo)
        {
            progBarCount = 0;
            //progBarMax = tempo * 60;
            
            progBarMax = 5;
            progressBar1.Value = 0;
            progressBar1.Maximum = progBarMax;
        }
        
    }
}