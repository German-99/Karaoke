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

using Microsoft.Win32;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

using System.Windows.Threading;

namespace Karaoke
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AudioFileReader reader;
        WaveOut output;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReproducir_Click(object sender, RoutedEventArgs e)
        {
            reader = new AudioFileReader(@"Surf Curse - In My Head Till I'm Dead.mp3");
            output = new WaveOut();
            output.Init(reader);
            output.Play();
            btnReproducir.Visibility = Visibility.Hidden;
            PbCancion.Visibility = Visibility.Visible;

            PbCancion.Maximum = reader.TotalTime.TotalSeconds;
            PbCancion.Value = reader.CurrentTime.TotalSeconds;
        }
    }
}
