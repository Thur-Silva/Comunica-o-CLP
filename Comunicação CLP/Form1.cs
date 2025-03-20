using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicação_CLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                Minimizar.Location = new Point(1700, 12);
                Maximizar.Location = new Point(1751, 12);
                Fechar.Location = new Point(1802, 12);
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_MouseHover(object sender, EventArgs e)
        {
            Minimizar.Size = new Size(35, 35);
        }

        private void Minimizar_MouseLeave(object sender, EventArgs e)
        {
            Minimizar.Size = new Size(33, 33);
        }

        private void Maximizar_MouseHover(object sender, EventArgs e)
        {
            Maximizar.Size = new Size(35, 35);
        }

        private void Maximizar_MouseLeave(object sender, EventArgs e)
        {
            Maximizar.Size = new Size(33, 33);
        }

        private void Fechar_MouseHover(object sender, EventArgs e)
        {
            Fechar.Size = new Size(35, 35);
        }

        private void Fechar_MouseLeave(object sender, EventArgs e)
        {
            Fechar.Size = new Size(33, 33);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
