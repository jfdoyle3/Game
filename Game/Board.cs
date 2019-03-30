using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Board
    {
        int Height = 4;
        int Width = 2;
        static String[] parts = { "|", " ", "+", "-" };
        String wall = parts[0];
        String space = parts[1];
        String plus = parts[2];
        String dash = parts[3];

        public void BuildBoard(int height, int width)
        {
              this.Height = height;
              this.Width = width;
             Console.WriteLine("{0},{1}", height, width);


        
           
            for (var vert = 0; vert <= Height+1; vert++)
             {
               
              for (var horz = 0; horz <= Width+1; horz++)
             {
                   
                    if (vert % 2 == 0)
                    {
                        Console.Write("{0}{1}", plus, dash);
                    } else
                    {
                        Console.Write("{0}{1}", wall, space);
                    }
                }
                Console.WriteLine();
             }
            Console.WriteLine();
        }    
 
    }
 }