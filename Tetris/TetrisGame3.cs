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
   partial  class TetrisGame // Şekil Değişme
    {
        public void SquareChangeShape()
        {
            if (currentshape_no == 2.1)
                currentshape_no = 2.2;
            else if (currentshape_no == 2.2)
                currentshape_no = 2.1;

            else if (currentshape_no == 3.1)
                currentshape_no = 3.2;
            else if (currentshape_no == 3.2)
                currentshape_no = 3.3;
            else if (currentshape_no == 3.3)
                currentshape_no = 3.4;
            else if (currentshape_no == 3.4)
                currentshape_no = 3.1;

            else if (currentshape_no == 4.1)
                currentshape_no = 4.2;
            else if (currentshape_no == 4.2)
                currentshape_no = 4.3;
            else if (currentshape_no == 4.3)
                currentshape_no = 4.4;
            else if (currentshape_no == 4.4)
                currentshape_no = 4.1;

            else if (currentshape_no == 5.1)
                currentshape_no = 5.2;
            else if (currentshape_no == 5.2)
                currentshape_no = 5.3;
            else if (currentshape_no == 5.3)
                currentshape_no = 5.4;
            else if (currentshape_no == 5.4)
                currentshape_no = 5.1;

            else if (currentshape_no == 6.1)
                currentshape_no = 6.2;
            else if (currentshape_no == 6.2)
                currentshape_no = 6.1;

            else if (currentshape_no == 7.1)
                currentshape_no = 7.2;
            else if (currentshape_no == 7.2)
                currentshape_no = 7.1;

            if (currentshape_no != 1.1)
                SquareChangeShape(currentshape_no);
        }

        private void SquareChangeShape(double currentshape_no)
        {
            double[,] sanal = new double[4,2];

            for (int i = 0; i < current_shape.Length; i++)
            {
                Rectangle rec = new Rectangle();
                rec = current_shape[i];

                if (currentshape_no == 2.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left + 40;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    else if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }

                    else if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 40;
                    }
                    else if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top + 60;
                    }
               }

                else if (currentshape_no == 2.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left - 40;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    else if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }

                    else if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 40;
                    }
                    else if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top - 60;
                    }
                }

                else if (currentshape_no == 3.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                        
                    }

                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 3.3)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                        
                    }

                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 3.4)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                }

                else if (currentshape_no == 3.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }

                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }

                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                }

                else if (currentshape_no  == 4.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }

                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top - 40;
                    }
                }

                else if (currentshape_no == 4.3)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }

                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 40;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }

                }

                else if (currentshape_no == 4.4)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                }

                else if (currentshape_no == 4.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 40;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left - 40;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 5.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left - 40;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                }

                else if (currentshape_no == 5.3)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top -40;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 5.4)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 20;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left + 40;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 20;
                    }
                }

                else if (currentshape_no == 5.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 40;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left -20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 6.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left -20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left -20;
                        sanal[i, 1] = rec.Margin.Top -40;
                    }
                }

                else if (currentshape_no == 6.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top + 40;
                    }
                }

                else if (currentshape_no == 7.2)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top - 40;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left + 40;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }

                else if (currentshape_no == 7.1)
                {
                    if (i == 0)
                    {
                        sanal[i, 0] = rec.Margin.Left + 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 1)
                    {
                        sanal[i, 0] = rec.Margin.Left - 20;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                    if (i == 2)
                    {
                        sanal[i, 0] = rec.Margin.Left;
                        sanal[i, 1] = rec.Margin.Top + 40;
                    }
                    if (i == 3)
                    {
                        sanal[i, 0] = rec.Margin.Left - 40;
                        sanal[i, 1] = rec.Margin.Top;
                    }
                }
             }

            if (SquareBoolChangeShape(sanal))
            {
                for (int i = 0; i < 4; i++)
                {
                    Rectangle rect = current_shape[i];
                    rect.Margin = new Thickness(sanal[i, 0], sanal[i, 1], 0, 0);
                }
            }
            else
            {
                if (currentshape_no == 2.1) this.currentshape_no = 2.2;
                else if (currentshape_no == 2.2) this.currentshape_no = 2.1;
               
                else if (currentshape_no == 6.1) this.currentshape_no = 6.2;
                else if (currentshape_no == 6.2) this.currentshape_no = 6.1;

                if (currentshape_no == 7.1) this.currentshape_no = 2.2;
                if (currentshape_no == 7.2) this.currentshape_no = 7.1;
                else
                {
                    if (currentshape_no == 3.1)
                        this.currentshape_no = 3.4;
                    else if (currentshape_no == 3.2)
                        this.currentshape_no = 3.1;
                    else if (currentshape_no == 3.3)
                        this.currentshape_no = 3.2;
                    else if (currentshape_no == 3.4)
                        this.currentshape_no = 3.3;

                    else if (currentshape_no == 4.1)
                        this.currentshape_no = 4.4;
                    else if (currentshape_no == 4.2)
                        this.currentshape_no = 4.1;
                    else if (currentshape_no == 4.3)
                        this.currentshape_no = 4.2;
                    else if (currentshape_no == 4.4)
                        this.currentshape_no = 4.3;

                    else if (currentshape_no == 5.1)
                        this.currentshape_no = 5.4;
                    else if (currentshape_no == 5.2)
                        this.currentshape_no = 5.1;
                    else if (currentshape_no == 5.3)
                        this.currentshape_no = 5.2;
                    else if (currentshape_no == 5.4)
                        this.currentshape_no = 5.3;
                   
                }
            }
        }

        private bool SquareBoolChangeShape(double[,] dizi)
        {
            bool durum = true;

            
            for (int i = 0; i < 4; i++)
            {
                Rectangle rect = current_shape[i];
                double left = rect.Margin.Top / 20;
                double top = rect.Margin.Left / 20;

                if (dizi[i,0] > 300 || dizi[i,0] <0 || dizi[i,1] > 600 || dizi[i,1] < 0)
                        durum = false;

                if (rect.Margin.Left != 0 && rect.Margin.Left != 300)
                {
                    if (bool_shape[(int)left, (int)top - 1]) // Solunda kare var mı
                    {
                        durum = false;
                        break;
                    }


                    if (bool_shape[(int)left, (int)top + 1]) // sağında kare var mı
                    {
                        durum = false;
                        break;
                    }
                }
            }

            return durum;
        }
    }
}
