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
        DispatcherTimer timer;
        WaveOut output;
        bool dragging = false;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (!dragging)
            {
                PbCancion.Value = reader.CurrentTime.TotalSeconds;
            }

            if (PbCancion.Value > 20)
            {
                txt1.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 27)
            {
                txt1.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 37)
            {
                txt2.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 47)
            {
                txt3.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 58)
            {
                txt4.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 63)
            {
                txt5.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 83)
            {
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 98)
            {
                txt7.Visibility = Visibility.Hidden;
               
            }
            if (PbCancion.Value > 118)
            {
                txt7.Visibility = Visibility.Hidden;
                txt8.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 127)
            {
                txt8.Visibility = Visibility.Hidden;
                txt9.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 137)
            {
                txt9.Visibility = Visibility.Hidden;
                txt10.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 147)
            {
                txt10.Visibility = Visibility.Hidden;
                txt11.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 157)
            {
                txt10.Visibility = Visibility.Hidden;
                txt11.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 163)
            {
                txt11.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Visible;
            }
            if (PbCancion.Value > 180)
            {
                txt6.Visibility = Visibility.Hidden;
                txt7.Visibility = Visibility.Visible;
            }




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


            timer.Start();

         
        }
    }
    }
