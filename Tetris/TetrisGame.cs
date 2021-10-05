using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace Tetris
{
    partial class TetrisGame
    {
        Grid Grid1 = new Grid(); // Oyunun oynanacağı grid  
        Image nextImage = new Image(); // Sıradaki şekli göstermesi için image
        BrushConverter bc = new BrushConverter();
        Random random = new Random();

        private bool[,] bool_shape = new bool[32, 16];  // Hangi bölgede şekil olduğunu kontrol etmek için bool dizisi.
        private Rectangle[,] all_square = new Rectangle[31, 16];
        public int score;
        public int lines;

        private Rectangle[] current_shape = new Rectangle[4]; // Güncel hareket eden şekil
        private double currentshape_no; // Güncel şeklin shape_no'su
        public double nextshape_no; // Sıradaki şeklin shape_no'su
        
        public TetrisGame()
        {
            for (int i = 0; i < 31; i++)
                for (int a = 0; a < 16; a++)
                    bool_shape[i, a] = false; // Ekranda square olmadığı için false yaptık.

            for (int i = 0; i < 16; i++)
                bool_shape[31, i] = true; // Ekranının sondan sonraki satırını true yaptık. (Shape'in son satırda durması için)

            score = 0;
            lines = 0;
            this.nextshape_no = 1.1;
            CreateShape(nextshape_no, 0, 140, 0);
            CreateShape(nextshape_no, 1, 160, 0);
            CreateShape(nextshape_no, 2, 140, 20);
            CreateShape(nextshape_no, 3, 160, 20);
        }

        public Grid CreateGrid()
        {
            Grid1.Name = "grid1"; // Name

            Grid1.HorizontalAlignment = HorizontalAlignment.Left;
            Grid1.VerticalAlignment = VerticalAlignment.Top;
            Grid1.Margin = new Thickness(130, 22, 0, 0); // Koordinat

            Grid1.Width = 320; // Genişlik
            Grid1.Height = 620; // Uzunluk

            Grid1.Background = bc.ConvertFrom("#BECFEA") as Brush; // Arkaplan Rengi

            return Grid1;
         }

        public Rectangle CreateRod(int left, int top, int right, int bottom, int width, int height)
        {
            
            Rectangle rod = new Rectangle();

            rod.HorizontalAlignment = HorizontalAlignment.Left;
            rod.VerticalAlignment = VerticalAlignment.Top;
            rod.Margin = new Thickness(left, top, right, bottom); // Koordinat

            rod.Width = width; // Genişlik
            rod.Height = height; // Uzunluk

            rod.Stroke = bc.ConvertFrom("#7788aa") as Brush;
            rod.StrokeThickness = 5;

            return rod;
        }

        public Image CreateNextImage()
        {
            nextImage.VerticalAlignment = VerticalAlignment.Top;
            nextImage.HorizontalAlignment = HorizontalAlignment.Left;

            nextImage.Margin = new Thickness(550, 110, 0, 0); // set coordinate

            nextImage.Width = 50;
            nextImage.Height = 110; // set width and height

            return this.nextImage;
        }

        private void CreateShape(double nextshape_no, int square_no, int left, int top)
        {
            
            if (square_no == 0)
                current_shape = new Rectangle[4]; // Eğer yeni bir şekil oluşturulacak ise current_shapes dizisi sıfırlansın.

            GameFinish();
            

            Rectangle square = new Rectangle();
            this.currentshape_no = nextshape_no;

            square.VerticalAlignment = VerticalAlignment.Top;
            square.HorizontalAlignment = HorizontalAlignment.Left;
            square.Margin = new Thickness(left, top, 0, 0); // set coordinate

            square.Width = 20;
            square.Height = 20; // set width and height

            square.Fill = setBrush(currentshape_no); // set fill color
            square.Stroke = Brushes.Black;  // set stroke color (black)

            current_shape[square_no] = square;
            Grid1.Children.Add(square);

            if (square_no == 3)
            {
                this.nextshape_no = random.Next(1, 8) + 0.1;
                ChangeNextImage();
            }
        }

        private Brush setBrush(double number)
        {
            if (number == 1.1) // kare
                return Brushes.Firebrick;
            else if (number == 2.1)
                return Brushes.Blue;
            else if (number == 3.1)
                return Brushes.Red;
            else if (number == 4.1)
                return Brushes.Green;
            else if (number == 5.1)
                return Brushes.Yellow;
            else if (number == 6.1)
                return Brushes.Orange;
            else if (number == 7.1)
                return Brushes.Ivory;

            return Brushes.RoyalBlue;
        }

       private void ChangeNextImage()
        {
            Image image = nextImage;
           
            if (nextshape_no == 1.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape1.png", UriKind.Relative));

            else if (nextshape_no == 2.1)
                 image.Source = new BitmapImage(new Uri(@"/images/Shape2.png", UriKind.Relative));

            else if (nextshape_no == 3.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape3.png", UriKind.Relative));

            else if (nextshape_no == 4.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape4.png", UriKind.Relative));

            else if (nextshape_no == 5.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape5.png", UriKind.Relative));
            
            else if (nextshape_no == 6.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape6.png", UriKind.Relative));
            
            else if (nextshape_no == 7.1)
                image.Source = new BitmapImage(new Uri(@"/images/Shape7.png", UriKind.Relative));

            nextImage = image;
         }
     }
}

