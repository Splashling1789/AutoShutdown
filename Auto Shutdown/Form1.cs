using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Shutdown
{
    public partial class Form1 : Form
    {
        int segundos;
        int minutos;
        int horas;
        int cuentaAtras;
        bool Por_apagar;

        public Form1()
        {
            Por_apagar = false;
            InitializeComponent();
        }

        private void Lbl_min_Click(object sender, EventArgs e)
        {

        }

        private void Btn_lh_Click(object sender, EventArgs e)
        {
            horas = horas - 1;
            if (horas < 0)
            {
                horas = 99;
            }
        }

        private void Btn_Mh_Click(object sender, EventArgs e)
        {
            horas = horas + 1;
            if(horas > 99)
            {
                horas = 99;
                string message = "You don't have enough with 99 hours? Maybe another day I will update this";
                string caption = "Wait what?";
                DialogResult result;
                result = MessageBox.Show(message, caption);
                
            }

        }

        private void Lbl_horas_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_mm_Click(object sender, EventArgs e)
        {
            minutos = minutos + 1;
            if (minutos >= 60)
            {
                horas = horas + 1;
                minutos = 0;
            }
        }

        private void Btn_lm_Click(object sender, EventArgs e)
        {
            minutos = minutos - 1;
            if (minutos < 0)
            {
                minutos = 59;
            }

        }

        private void Btn_Ms_Click(object sender, EventArgs e)
        {
            segundos = segundos + 1;
            if(segundos >= 60)
            {
                minutos = minutos + 1;
                segundos = 0;
            }
        }
    
        private void Btn_ls_Click(object sender, EventArgs e)
        {
            segundos = segundos - 1;
            if (segundos < 0)
            {
                segundos = 59;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_lh.Enabled = false;
            Btn_Mh.Enabled = false;
            Btn_lm.Enabled = false;
            Btn_mm.Enabled = false;
            Btn_ls.Enabled = false;
            Btn_Ms.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Start.Enabled = false;
            Por_apagar = true;
            Time_s.Enabled = true;
            cuentaAtras = segundos + (minutos * 60) + (horas * 60 * 60);
        }

        private void Time_s_Tick(object sender, EventArgs e)
        {
            cuentaAtras = cuentaAtras - 1;
            segundos = segundos - 1;
            if (segundos < 0 && minutos > 0)
            {
                minutos = minutos - 1;
                segundos = 59;
            }
            if(minutos < 0 && horas > 0)
            {
                horas = horas - 1;
                minutos = 59;
            }
            if (segundos < 0 && minutos == 0 && horas > 0)
            {
                horas -= 1;
                minutos = 59;
                segundos = 59;
            }
            if (segundos < -0)
                segundos = 0;
            if (minutos < 0)
                minutos = 0;
            if (horas < 0)
                horas = 0;
            
            
            

        }

        private void Actualizar_Tick(object sender, EventArgs e)
        {
            Lbl_seg.Text = Convert.ToString(segundos);
            Lbl_min.Text = Convert.ToString(minutos);
            Lbl_horas.Text = Convert.ToString(horas);
            Lbl_restante.Text = "Seconds remaining: " + Convert.ToString(cuentaAtras);
            if(segundos == 0 && minutos == 0 && horas == 0 && cuentaAtras == 0 && Por_apagar == true)
            {
                System.Diagnostics.ProcessStartInfo shutdown10 = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -s -t 10 -c \"Apagado automático apagará tu pc, la cuenta atrás finalizó\"");
                System.Diagnostics.ProcessStartInfo shutdown = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -s -c \"Apagado automático apagará tu pc, la cuenta atrás finalizó\"");
                System.Diagnostics.ProcessStartInfo reboot = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -r -c \"Apagado automático reiniciará tu pc, la cuenta atrás finalizó\"");
                System.Diagnostics.ProcessStartInfo reboot10 = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -r -t 10 -c \"Apagado automático reiniciará tu pc, la cuenta atrás finalizó\"");
                System.Diagnostics.Process proceso = new System.Diagnostics.Process();
                if(cb_margen.Checked == true && cb_reiniciar.Checked == false)
                {
                    proceso.StartInfo = shutdown10;
                    proceso.Start();
                }
                if(cb_margen.Checked == true && cb_reiniciar.Checked == true)
                {
                    proceso.StartInfo = reboot10;
                    proceso.Start();
                }
                if(cb_margen.Checked == false && cb_reiniciar.Checked == false)
                {
                    proceso.StartInfo = shutdown;
                    proceso.Start();
                }
                if(cb_margen.Checked == false && cb_reiniciar.Checked == true)
                {
                    proceso.StartInfo = reboot;
                    proceso.Start();
                }
                Actualizar.Enabled = false;
                Application.Exit();
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Time_s.Enabled = false;
            Btn_lh.Enabled = true;
            Btn_Mh.Enabled = true;
            Btn_lm.Enabled = true;
            Btn_mm.Enabled = true;
            Btn_ls.Enabled = true;
            Btn_Ms.Enabled = true;
            Btn_Start.Enabled = true;
            Btn_Stop.Enabled = false;
            Por_apagar = false;
            segundos = 0;
            minutos = 0;
            horas = 0;
            cuentaAtras = 0;
            
        }

        private void Cb_margen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_restante_Click(object sender, EventArgs e)
        {

        }

        private void Cb_reiniciar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
