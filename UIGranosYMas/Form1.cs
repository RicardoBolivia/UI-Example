using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UIGranosYMas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bandaMN = true;
        int R = 255;
        int G = 0;
        int B = 0;
       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (bandaMN)
            {
                this.WindowState = FormWindowState.Normal;
                max.BackgroundImage = Properties.Resources.maxi;
                bandaMN = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                max.BackgroundImage = Properties.Resources.res;
                bandaMN = true;
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Transicion(object sender, EventArgs e)
        {
            if (R == 255)
            {
                B = B + 1;
            }
            if (B == 252)
            {
                R = R - 1;
                if (R == 5)
                {
                    R = 6;
                    B = 252;
                }
            }
            if (R == 6 & B == 252)
            {
                G = G + 1; ;
            }
            if (G == 252)
            {
                B = B - 1;
                if (B == 5)
                {
                    B = 6;
                }
            }
            if (B == 6 & G == 252)
            {
                R = R + 1;
            }
            if (R == 252 & B == 6)
            {
                G = G - 1;
                if (G == 5)
                {
                    G = 6;
                }
            }
            if (G == 6 & B == 6)
            {
                R = 255;
                G = 0;
                B = 0;
            }
            label3.ForeColor = Color.FromArgb(R, G, B);
            LOGO.ForeColor = Color.FromArgb(R, G, B);
            return;
        }

        private void Arrastrar(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.upForm.Controls.Count > 0)
                this.upForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.upForm.Controls.Add(fh);
            this.upForm.Tag = fh;
            fh.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cliente());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new productos());
        }

        public void btnNota_Click(object sender, EventArgs e)
        {
            estado.panel = upForm;
            AbrirFormInPanel(new NotasDeEntregraUI());
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Bolsas());
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Bolsas());
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Manual());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Bolsas());
        }

        private void btnBolsa_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Bolsas());
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            if (!cn.Conectar())
                System.Diagnostics.Process.Start("C:/wamp/wampmanager.exe");
        }

        private void upForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}