using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDealbera_ControlTiempo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private DateTime inicioTrabajo;
        private Timer timer;
        private bool enTrabajo = false;

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            if (!enTrabajo)
            { 
                //inicio
                enTrabajo = true;
                inicioTrabajo = DateTime.Now;
                btnTrabajo.Text = "Finalizar";
                timer.Start();
            }
            else
            {
                //fin
                enTrabajo = false;
                timer.Stop();
                TimeSpan tiempoTrabajado = DateTime.Now - inicioTrabajo;
                MessageBox.Show($"Tiempo trabajado: {tiempoTrabajado:hh\\:mm\\:ss}");
                btnTrabajo.Text = "Trabajo";
                toolStripStatusLabel1.Text = "Tiempo: 00:00:00";
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;

            toolStripStatusLabel1.Text = "Tiempo: 00:00:00";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoActual = DateTime.Now - inicioTrabajo;
            toolStripStatusLabel1.Text = "Tiempo: " + tiempoActual.ToString(@"hh\:mm\:ss");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
