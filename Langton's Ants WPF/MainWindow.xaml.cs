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

namespace Langton_s_Ants_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
               class Program
        {
            int[][] grid;
            int x;
            int y;
            int dir;

            int AntNorth = 0;
            int AntEast = 1;
            int AntSouth = 2;
            int AntWest = 3;

            public void setup()
            {
                size(400, 400);
                grid = new int[width][height];
                //board size

                at start
    
            dir = AntNorth;
                //facing direction start
            }

            public void turnRight()
            {
                dir++;
            }

            public void turnLeft()
            {
                dir--;
            }
            //cycles between north->east->south->west by +1 -1 depending if left or right


            public void moveForward()
            {
                if (dir == AntNorth)
                {
                    y--;
                }
                else if (dir == AntEast)
                {
                    x++;
                }
                else if (dir == AntSouth)
                {
                    y++;
                }
                else if (dir == AntWest)
                {
                    x--;
                }
                //change the ants position on the 2d array either x or y co-ordinates

                if (x > width - 1)
                {
                    x = 0;
                }
                else if (x < 0)
                {
                    x = width - 1;
                }
                if (y > height - 1)
                {
                    y = 0;
                }
                else if (y < 0)
                {
                    y = height - 1;
                }
            }

            public void draw()
            {
                backgroundColor.White;
                for (int n = 0; n < 100; n++)
                {
                    int state = grid[x][y];

                    if (state == 0)
                    {
                        turnRight();
                        grid[x][y] = 1;
                        moveForward();
                    }
                    else if (state == 1)
                    {
                        turnLeft();
                        grid[x][y] = 0;
                        moveForward();
                    }
                }
                //moving on grid, state determins if black or white, this pulled from x,y co-or 2d array of grid. 0 (black) pulls turn right then move forward function.
                //1 (white)

                loadPixels();
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        int pix = i + width * j;
                        if (grid[i][j] == 0)
                        {
                            pixels[pix] = Color.White;
                        }
                        else
                        {
                            pixels[pix] = Color.Black;

                        }
                    }
                    //for loop where i (x value for loadPixels) checks where ant moved then draws that square 
                }
                UpdatePixels();
            }

        }
    }
    InitializeComponent();
        }
    }
}

{
 