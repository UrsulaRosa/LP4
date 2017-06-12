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
    public partial class Consultar : Form
    {
        public Consultar()
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
        private void PreencherListView(List<Treino> Treinos)
        {
            ListViewItem item;
            foreach (Treino Treino in Treinos)
            {
                item = new ListViewItem(Treino.TreinoNome);
                item.SubItems.Add(Treino.Minutos.ToString());
                item.SubItems.Add(Treino.Nivel);
                item.SubItems.Add(Treino.Intensidade);
                Lista.Items.Add(item);
            }
            txtConsulta.Clear();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = Conectar();


            if (checknome.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM treino t WHERE Treino LIKE (@TreinoNome)";
                cmd.Parameters.AddWithValue("@TreinoNome", txtConsulta.Text + "%");
                Lista.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Treino> Treinos = new List<Treino>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Treino t = new Treino();
                        t.Id = r.GetInt32(0);
                        t.TreinoNome = r.GetString(1);
                        t.Minutos = r.GetInt32(2);
                        t.Nivel = r.GetString(3);
                        t.Intensidade = r.GetString(4);
                        Treinos.Add(t);
                    }
                }

                PreencherListView(Treinos);
                cmd.Connection.Close();

            }
            else if (checkminutos.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM treino t WHERE Minutos LIKE (@Minutos)";
                cmd.Parameters.AddWithValue("@Minutos", txtConsulta.Text + "%");
                Lista.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Treino> Treinos = new List<Treino>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Treino t = new Treino();
                        t.Id = r.GetInt32(0);
                        t.TreinoNome = r.GetString(1);
                        t.Minutos = r.GetInt32(2);
                        t.Nivel = r.GetString(3);
                        t.Intensidade = r.GetString(4);
                        Treinos.Add(t);
                    }
                }

                PreencherListView(Treinos);
                cmd.Connection.Close();
            }
            else if (checknivel.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM treino t WHERE Nivel LIKE (@Nivel)";
                cmd.Parameters.AddWithValue("@Nivel", txtConsulta.Text + "%");
                Lista.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Treino> Treinos = new List<Treino>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Treino t = new Treino();
                        t.Id = r.GetInt32(0);
                        t.TreinoNome = r.GetString(1);
                        t.Minutos = r.GetInt32(2);
                        t.Nivel = r.GetString(3);
                        t.Intensidade = r.GetString(4);
                        Treinos.Add(t);
                    }
                }

                PreencherListView(Treinos);
                cmd.Connection.Close();
            }
            else if (checkintensidade.Checked && txtConsulta.Text != string.Empty)
            {
                cmd.CommandText = "SELECT * FROM treino t WHERE Intensidade LIKE (@Intensidade)";
                cmd.Parameters.AddWithValue("@Intensidade", txtConsulta.Text + "%");
                Lista.Items.Clear();
                cmd.Connection.Open();
                MySqlDataReader r;
                r = cmd.ExecuteReader();

                List<Treino> Treinos = new List<Treino>();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Treino t = new Treino();
                        t.Id = r.GetInt32(0);
                        t.TreinoNome = r.GetString(1);
                        t.Minutos = r.GetInt32(2);
                        t.Nivel = r.GetString(3);
                        t.Intensidade = r.GetString(4);
                        Treinos.Add(t);
                    }
                }

                PreencherListView(Treinos);
                cmd.Connection.Close();
            }
        }
    }
}
