using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        TetrisGame tetris = new TetrisGame();
        DispatcherTimer normalDown = new DispatcherTimer();
        DispatcherTimer speedDown = new DispatcherTimer();
        int düsmehizi = 150;

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            
            Grid2.Children.Add(tetris.CreateGrid());

            Grid2.Children.Add(tetris.CreateRod(126, 22, 0, 0, 4, 620));
            Grid2.Children.Add(tetris.CreateRod(450, 22, 0, 0, 4, 620));
            Grid2.Children.Add(tetris.CreateRod(126, 17, 0, 0, 328, 5));
            Grid2.Children.Add(tetris.CreateRod(126, 642, 0, 0, 328, 5)); // Grid çubuk görseli

            Grid2.Children.Add(tetris.CreateNextImage());

            normalDown.Interval = TimeSpan.FromMilliseconds(düsmehizi);
            normalDown.Start();
            normalDown.Tick += new EventHandler(normalDown_Tick);

            speedDown.Interval = TimeSpan.FromMilliseconds(düsmehizi- 50);
            speedDown.Stop();
            speedDown.Tick += new EventHandler(speedDown_Tick);

        }


        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A || e.Key == Key.Left)
            {
                tetris.LeftOrRightMove("left");
                label2.Content = "Score: " + tetris.score;
                label3.Content = "Lines: " + tetris.lines;
                tetris.GameFinish();
                SetDüsmeHizi();

            }
            else if (e.Key == Key.D || e.Key == Key.Right)
            {
                tetris.LeftOrRightMove("right");
                label2.Content = "Score: " + tetris.score;
                label3.Content = "Lines: " + tetris.lines;
                tetris.GameFinish();
                SetDüsmeHizi();

            }
            else if (e.Key == Key.W || e.Key == Key.Up)
            {
                label2.Content = "Score: " + tetris.score;
                label3.Content = "Lines: " + tetris.lines;
                tetris.SquareChangeShape();
                SetDüsmeHizi();
            }

            else if (e.Key == Key.S || e.Key == Key.Down)
            {
                label2.Content = "Score: " + tetris.score;
                label3.Content = "Lines: " + tetris.lines;
                speedDown.Start();
                SetDüsmeHizi();


             }
        }

        private void normalDown_Tick(object sender, EventArgs e)
        {
            
            tetris.DownMoveCurrentShapeorCreateNewShape();
        
            label2.Content = "Score: " + tetris.score;
            label3.Content = "Lines: " + tetris.lines;
            tetris.GameFinish();
            SetDüsmeHizi();

        }


        void speedDown_Tick(object sender, EventArgs e)
        {
            tetris.DownMoveCurrentShapeorCreateNewShape();
            label2.Content = "Score: " + tetris.score;
            label3.Content = "Lines: " + tetris.lines; 
            tetris.GameFinish();
            SetDüsmeHizi();
            speedDown.Stop();
        }

        private void SetDüsmeHizi()
        {
            if(tetris.score == 500)
                düsmehizi -= 50;
            else if (tetris.score == 1000)
                düsmehizi -= 50;
            else if (tetris.score == 2000)
                düsmehizi -= 50;
            else if (tetris.score == 3000)
                düsmehizi -= 10;
        }
        

    }
}
