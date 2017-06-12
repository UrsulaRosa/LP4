using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LP4
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
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

            private void btnsalvar_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "INSERT INTO treino (Treino, Minutos, Nivel, Intensidade) VALUES (@treino, @min, @nivel, @intensidade);";

            Treino t = new Treino();
            t.TreinoNome = txttreino.Text;
            t.Minutos = int.Parse(txtmin.Text);
            t.Nivel = txtnivel.Text;
            t.Intensidade = txtintensidade.Text;
           

            
            cmd.Parameters.AddWithValue("@treino", t.TreinoNome);
            cmd.Parameters.AddWithValue("@min", t.Minutos);
            cmd.Parameters.AddWithValue("@nivel", t.Nivel);
            cmd.Parameters.AddWithValue("@intensidade", t.Intensidade);
            

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Treino salvo");
            txttreino.Clear();
            txtmin.Clear();
            txtnivel.Clear();
            txtintensidade.Clear();
        }

        private void btnconsultar_Click(object sender, RoutedEventArgs e)
        {
            Consultar Consulta = new Consultar();
            Consulta.ShowDialog();
        }

        private void btnalterar_Click(object sender, RoutedEventArgs e)
        {
            Alterar Alterar = new Alterar();
            Alterar.ShowDialog();
        }

        private void btndeletar_Click(object sender, RoutedEventArgs e)
        {
            Deletar Deletar = new Deletar();
            Deletar.ShowDialog();
        }
    }
}
