using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    
    public class CursorDraw
    {
        public static Color  CursorColor;
        public static int CoordX;
        public static int CoordY;
        private static bool draw;
        public static bool Draw
        {
            get
            {
                return draw;
            }

            set
            {
                draw = value;
                if (draw)
                {
                    // Графический вид курсора 

                }
                else
                {
                    // Обычный вид курсора

                }
            }
        }

        


        public CursorDraw()
        {
            //Draw = false;
            
            CoordX = 1;
            CoordY = 1;
        }
    }
}
