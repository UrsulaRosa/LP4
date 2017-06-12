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
    public partial class Deletar : Form
    {
        public Deletar()
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
            if (txtTreinoDeletar.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT * FROM treino WHERE Treino = @TreinoNome;";
                cmd.Parameters.AddWithValue("@TreinoNome", (txtTreinoDeletar.Text));

                cmd.Connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();


                if (r.Read())
                {
                    txtTreino.Text = r.GetString(1);
                    txtmin.Text = r.GetString(2);
                    txtNivel.Text = r.GetString(3);
                    txtIntensidade.Text = r.GetString(4);
                }
                else
                {
                    MessageBox.Show("Treino não encontrado");
                    txtTreinoDeletar.Clear();
                }

                cmd.Connection.Close();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtTreino.Text != string.Empty && txtmin.Text != string.Empty && txtNivel.Text != string.Empty && txtIntensidade.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "DELETE FROM treino WHERE Treino = @TreinoNome AND Minutos = @Minutos AND Nivel = @Nivel AND Intensidade = @Intensidade;";
                cmd.Parameters.AddWithValue("@TreinoNome", txtTreino.Text);
                cmd.Parameters.AddWithValue("@Minutos", txtmin.Text);
                cmd.Parameters.AddWithValue("@Nivel", txtNivel.Text);
                cmd.Parameters.AddWithValue("@Intensidade", txtIntensidade.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Treino excluído");
                txtTreinoDeletar.Clear();
                txtTreino.Clear();
                txtmin.Clear();
                txtNivel.Clear();
                txtIntensidade.Clear();
            }
            else
                MessageBox.Show("Operação mal sucedida");
        }
    }
    }

