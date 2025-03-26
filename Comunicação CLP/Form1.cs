using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EasyModbus;
using MySql.Data.MySqlClient;

namespace Comunicação_CLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModbusClient CLP_connectionPort = new ModbusClient("192.168.30.13", 502);

        string CONFIG_CONEXAO_BD = "server=127.0.0.1;userid=root;password=;database=senai";
        public void QUERY_MYSQL(string server, string query)
        {
            MySqlConnection conexao = new MySqlConnection(server);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = conexao;
            conexao.Open();
            Query.CommandText = query;
            Query.ExecuteNonQuery();

            conexao.Close();


        }
        private void CarregarComboBox()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CONFIG_CONEXAO_BD))
                {
                    conn.Open();
                    string query = "SELECT nome FROM produtos";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CBXescolha.Items.Add(reader["nome"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
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
                Minimizar.Location = new Point(653, 12);
                Maximizar.Location = new Point(704, 12);
                Fechar.Location = new Point(755, 12);
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

        /////// Arrastar Form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //////




        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            try
            {
                CLP_connectionPort.UnitIdentifier = 255;
                CLP_connectionPort.Connect();

                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o CLP: " + ex.Message);
            }

        }
        int AcessOFFControl = 1;
        private void button2_Click(object sender, EventArgs e)
        {

            int DesligaMotor = 1;
            try
            {

                CLP_connectionPort.WriteSingleRegister(3, DesligaMotor); // TENTA DESLIGAR O MOTOR
                
                AcessOFFControl++;

                
                if (AcessOFFControl % 2 == 0)
                {
                    BTNdesligar.BackColor = Color.Red; 
                }
                else
                {
                    BTNdesligar.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desligar o motor: " + ex.Message);
            }
        }


        private void BTNligar_MouseHover(object sender, EventArgs e)
        {
            BTNligar.BackColor = Color.Lime;
        }

        private void BTNdesligar_MouseHover(object sender, EventArgs e)
        {
            BTNdesligar.BackColor = Color.Red;
        }

        private void BTNdesligar_MouseLeave(object sender, EventArgs e)
        {
            BTNdesligar.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void BTNligar_MouseLeave(object sender, EventArgs e)
        {
            BTNligar.BackColor = Color.FromArgb(192, 255, 192);
        }

        int AcessONControl = 1;
        private void BTNligar_Click(object sender, EventArgs e)
        {
            int QuantidadeDePeca = 0; 
            string produto = CBXescolha.Text;


            if (string.IsNullOrEmpty(produto))
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            try // pegando a quantidade de peças do produto selecionado no DB e armazenando na variável produto
            {
                using (MySqlConnection conn = new MySqlConnection(CONFIG_CONEXAO_BD))
                {
                    conn.Open();
                    string query = "SELECT qtd FROM produtos WHERE nome = @nome";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                QuantidadeDePeca = Convert.ToInt32(reader["qtd"]);
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                return;
            }

          
            try
            {
                CLP_connectionPort.WriteSingleRegister(9, QuantidadeDePeca);
                CLP_connectionPort.WriteSingleCoil(1, true); // resetando o contador
                CLP_connectionPort.WriteSingleCoil(0, true);    // ligando o motor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escrever no CLP: " + ex.Message);
            }
        



            AcessONControl++;
            if (AcessONControl % 2 == 0)
            {
                BTNligar.BackColor = Color.Lime;
            }
            else
            {
                BTNligar.BackColor = Color.FromArgb(192, 255, 192);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                bool[] COIL;
                COIL = CLP_connectionPort.ReadCoils(0, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o CLP: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
