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
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;

namespace Cronometro
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public Stopwatch stopWatch { get; set; }

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        string tempo = string.Empty;  
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        private void tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void dt_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                tempo = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                txtblock.Text = tempo;
            }
        } 
        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            dispatcherTimer.Start();
            btniniciar.IsEnabled = false;
            btnparar.IsEnabled = true;
            btnzerar.IsEnabled = true;
        }
        
        private void btnparar_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            dispatcherTimer.Stop();
            btniniciar.IsEnabled = true;
            btnparar.IsEnabled = false;
            btnzerar.IsEnabled = true;
        }

        private void btnzerar_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            txtblock.Text = "00:00:00";
            btnparar.IsEnabled = false;
            btniniciar.IsEnabled = true;
            btnzerar.IsEnabled = false;
        }
  }
}
