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
    partial class TetrisGame // Oyun bitirme ve Satır Dolunca Aşağıya İnme
    {
        public void GameFinish()
        {
            int count = 0;
            for (int i = 0; i < 16; i++)
                if (bool_shape[0,i])
                    count++;
            
            if (count >= 1)
            {
                MessageBoxResult result;
                result = MessageBox.Show("Skorunuz: "+score+"\nÖldürülen satır sayısı: "+lines+"\nYeniden Oynamak İster Misiniz?","Oyun Bitti",MessageBoxButton.YesNo,MessageBoxImage.Information);

                if (result == MessageBoxResult.OK)
                {
                    score = 0;
                    lines = 0;

                    for (int i = 0; i < 31; i++)
                        for (int a = 0; a < 16; a++)
                            bool_shape[i, a] = false; // Ekranda square olmadığı için false yaptık.

                    for (int i = 0; i < 31; i++)
                        for (int a = 0; a < 16; a++)
                            all_square[i, a] = null; // Ekranda square olmadığı için false yaptık.
                }
            }
         }

        public void LineDeleteControl()
        {
            int count = 0;
            for (int i = 0; i < 31; i++)
            {
                for (int a = 0; a < 16; a++)
                {
                    if (bool_shape[i, a])
                        count++;
                }

                if (count == 16)
                     LineDeleteControl(i);
                
                count = 0;
            }
        }

        private void LineDeleteControl(int x)
        {
            score += 100;
            lines += 1;

            for (int i = 0; i < 16; i++)
            {
                Rectangle rect = all_square[x,i];
                rect.Fill = null;
                rect.Stroke = null;

                bool_shape[x, i] = false;
            }

            bool[,] sanaldizi = new bool[32, 16];
            for (int i = 0; i < 32; i++)
                for (int a = 0; a < 16; a++)
                    sanaldizi[i, a] = bool_shape[i, a];
                
            
            for (int i = x -1 ; i >= 1; i--)
            {
                for (int a = 0; a < 16; a++)
                {
                    if (sanaldizi[i, a])
                    {
                        Rectangle rect = all_square[i, a];
                        rect.Margin = new Thickness(rect.Margin.Left, rect.Margin.Top + 20, 0, 0);

                        bool_shape[i +1, a] = true;
                        bool_shape[i , a] = false;
                        all_square[i +1, a] = rect;
                    }
                }
            }
        }
     }
}
    

