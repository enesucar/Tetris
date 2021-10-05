using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;


namespace Tetris
{
    partial class TetrisGame // Hareket Etme veya Yeni Şekil Oluşturma
    {
        public void DownMoveCurrentShapeorCreateNewShape()
        {
            if (CheckShapeStop()) // Eğer true ise aşağıya hareket ettir.
            {
                for (int i = 0; i < current_shape.Length; i++)
                {
                    Rectangle rect = current_shape[i];
                    rect.Margin = new Thickness(rect.Margin.Left, rect.Margin.Top + 20, 0, 0);

                    current_shape[i] = rect;
                   
                }

                CheckShapeStop();
            }
            else // False ise  güncel şekli ve koordinatı kaydet ve yeni şekil oluştur.
            {
                LineDeleteControl();
                double left, top;

                for (int i = 0; i < current_shape.Length; i++)
                {
                    Rectangle rect = current_shape[i];
                    left = rect.Margin.Top / 20;
                    top = rect.Margin.Left / 20;

                    bool_shape[(int)left, (int)top] = true;
                    all_square[(int)left, (int)top] = rect;
               
                } // Şeklin koordinatı kaydedildi. Tüm şekil bilgileri diziye aktarıldı.

                if (nextshape_no == 1.1)
                {
                    CreateShape(nextshape_no, 0, 140, 0);
                    CreateShape(nextshape_no, 1, 160, 0);
                    CreateShape(nextshape_no, 2, 140, 20);
                    CreateShape(nextshape_no, 3, 160, 20);
                }
                else if (nextshape_no == 2.1)
                {
                    CreateShape(nextshape_no, 0, 120, 0);
                    CreateShape(nextshape_no, 1, 140, 0);
                    CreateShape(nextshape_no, 2, 160, 0);
                    CreateShape(nextshape_no, 3, 180, 0);
                }
                else if (nextshape_no == 3.1)
                {
                    CreateShape(nextshape_no, 0, 140, 0);
                    CreateShape(nextshape_no, 1, 120, 20);
                    CreateShape(nextshape_no, 2, 140, 20);
                    CreateShape(nextshape_no, 3, 160, 20);
                }
                else if (nextshape_no == 4.1)
                {
                    CreateShape(nextshape_no, 0, 180, 0);
                    CreateShape(nextshape_no, 1, 180, 20);
                    CreateShape(nextshape_no, 2, 160, 20);
                    CreateShape(nextshape_no, 3, 140, 20);
                }
                else if (nextshape_no == 5.1)
                {
                    CreateShape(nextshape_no, 0, 140, 20);
                    CreateShape(nextshape_no, 1, 160, 20);
                    CreateShape(nextshape_no, 2, 180, 20);
                    CreateShape(nextshape_no, 3, 140, 0);
                }
                else if (nextshape_no == 6.1)
                {
                    CreateShape(nextshape_no, 0, 140, 0);
                    CreateShape(nextshape_no, 1, 160, 0);
                    CreateShape(nextshape_no, 2, 160, 20);
                    CreateShape(nextshape_no, 3, 180, 20);
                }
                else if (nextshape_no == 7.1)
                {
                    CreateShape(nextshape_no, 0, 180, 0);
                    CreateShape(nextshape_no, 1, 160, 0);
                    CreateShape(nextshape_no, 2, 160, 20);
                    CreateShape(nextshape_no, 3, 140, 20);
                }
             }
            
            LineDeleteControl();
        }
        
        private bool CheckShapeStop()
        {
            try
            {
                double left, top;

                for (int i = 0; i < current_shape.Length; i++)
                {
                    Rectangle rect = current_shape[i];
                    left = rect.Margin.Top / 20 + 1;
                    top = rect.Margin.Left / 20;

                    if (bool_shape[(int)left, (int)top])
                        return false;
                }

                return true;
            }
            catch
            {
                return true;
            }
        }

        public void LeftOrRightMove(string direction)
        {
            bool durum = true;
            double number = 0;

            if (direction == "left") 
                number = -20;
            else if (direction == "right") 
                number = 20;

            for (int i = 0; i < 4; i++)
            {
                Rectangle rect = current_shape[i];
                double left = rect.Margin.Top / 20;
                double top = rect.Margin.Left / 20;

                if (rect.Margin.Left + number < 0 || rect.Margin.Left + number > 300) // Alan dışına çıktı mı
                {
                    durum = false;
                    break;
                }

                if (direction == "left" && bool_shape[(int)left, (int)top - 1]) // Solunda kare var mı
                {
                    durum = false;
                    break;
                }

                if (direction == "right" && bool_shape[(int)left, (int)top + 1]) // sağında kare var mı
                {
                    durum = false;
                    break;
                }
               
            }

            if (durum) // true ise hareket etsin
            {
                for (int i = 0; i < current_shape.Length; i++)
                {
                    Rectangle rec = current_shape[i];
                    rec.Margin = new Thickness(rec.Margin.Left + number, rec.Margin.Top, 0, 0);
                    current_shape[i] = rec;
                }
            }
        }
    }
}
