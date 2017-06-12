using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP4
{
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        public MySqlCommand Conectar()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=treinos;Uid=root;Pwd=root;")
            };
            return cmd;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtTreinoAlterar.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT * FROM treino WHERE Treino = @TreinoNome;";
                cmd.Parameters.AddWithValue("@TreinoNome", (txtTreinoAlterar.Text));

                cmd.Connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    txtTreinoNome.Text = r.GetString(1);
                    txtmin.Text = r.GetString(2);
                    txtNivel.Text = r.GetString(3);
                    txtIntensidade.Text = r.GetString(4);
                }
                else
                {
                    MessageBox.Show("Treino não encontrado");
                    txtTreinoAlterar.Clear();
                }

                cmd.Connection.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTreinoNome.Text != string.Empty && txtmin.Text != string.Empty && txtNivel.Text != string.Empty && txtIntensidade.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "UPDATE treino SET Minutos = @min, Nivel = @Nivel, Intensidade = @Intensidade, Treino = @TreinoNome WHERE Treino = @TreinoNome;";
                cmd.Parameters.AddWithValue("@TreinoNome", txtTreinoNome.Text.ToString());
                cmd.Parameters.AddWithValue("@min", int.Parse(txtmin.Text));
                cmd.Parameters.AddWithValue("@Nivel", txtNivel.Text.ToString());
                cmd.Parameters.AddWithValue("@Intensidade", txtIntensidade.Text.ToString());

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Alteração Concluída");
                txtTreinoAlterar.Clear();
                txtTreinoNome.Clear();
                txtmin.Clear();
                txtNivel.Clear();
                txtIntensidade.Clear();
            }
            else
                MessageBox.Show("Operação mal sucedida");

        }

       
    }
    }

