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
using System.Windows.Threading;

namespace Schulte_Table
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public Random random = new Random();
        public int[] arr = new int[6];
        public bool isNext;
        public bool isStartEnabled = true;
        public uint Score;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += Timer_Tick;

            if(progressBar.Value == 100)
            {
                if(Score < 6)
                {
                    MessageBox.Show("You loose!");
                }
                else if(Score >= 6)
                {
                    MessageBox.Show("You win!");
                }
            }

        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == progressBar.Maximum)
                progressBar.Value = progressBar.Minimum;
            else
                progressBar.Value++;
        }

        public void RandomNumberOnButtons()
        {
            for (int i = 0; i < 5; i++)
            {
                arr[i] = random.Next(1, 6);
            }
            btn1.Content = arr[0];
            btn2.Content = arr[2];
            btn3.Content = arr[3];
            btn4.Content = arr[4];
            btn5.Content = arr[5];
            btn6.Content = arr[1];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isStartEnabled)
            {
                timer.Start();
                RandomNumberOnButtons();
                isStartEnabled = false;
            }
        }

        // Need make for all
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == 1.ToString()) // don't true!
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;
            }
            else if(Score >= 1 && ((Button)sender).Content.ToString() == 2.ToString())
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;

            }
            else if(Score >= 2 && ((Button)sender).Content.ToString() == 3.ToString())
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;

            }
            else if(Score >= 3 && ((Button)sender).Content.ToString() == 4.ToString())
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;

            }
            else if(Score >= 4 && ((Button)sender).Content.ToString() == 5.ToString())
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;

            }
            else if(Score >= 5 && ((Button)sender).Content.ToString() == 6.ToString())
            {
                Score++;
                lblScore.Content = Score.ToString();
                ((Button)sender).IsEnabled = false;
                RandomNumberOnButtons(); // for random all buttons
                slider.Value++;
            }
        }

        // random for button refresh
        private void imgRefresh_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!isStartEnabled)
                RandomNumberOnButtons();
        }
    }
}
