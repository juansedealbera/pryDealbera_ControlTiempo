using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDealbera_ControlTiempo
{
    public partial class frmAuditoria : Form
    {
        //zona de declaraciones globales
        StreamWriter streamWriter;

        public frmAuditoria()
        {
            InitializeComponent();
        }

        int tiempoTrabajo = 0; //contador de tiempo

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            streamWriter = new StreamWriter("zonaCalor.txt"); //base de datos
        }

        private void panelTrabajo_Paint(object sender, PaintEventArgs e)
        {
            timerTiempoTrabajo.Enabled = true;
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = true;
            OpenFileDialog ofdArchivoCoordenadas = new OpenFileDialog();

            if (ofdArchivoCoordenadas.ShowDialog() == DialogResult.OK)
            {
                //contar y sumar la cantidad de posiciones sql
                StreamWriter srAuditar = new StreamWriter(ofdArchivoCoordenadas.FileName);

               /* while (!srAuditar.EndOfStream) 
                {
                    lstCoordenadas.Items.Add(srAuditar.
                }*/
            }
        }

        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {
            tiempoTrabajo++;
            lblTiempoTrabajo.Text = tiempoTrabajo.ToString();
        }
    }
}
