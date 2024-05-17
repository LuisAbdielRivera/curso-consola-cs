using System;

namespace Builders
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color();

            color1.R = 100;
            color1.G = 150;
            color1.B = 200;

            Console.WriteLine("({0},{1},{2})",color1.R, color1.G, color1.B);
        }

        public class Color 
        {
            private int r;
            private int g;
            private int b;

            public int R
            {
                get { return r; }
                set { if (value <= 255) 
                    {
                        r = value;    
                    } else
                    {
                        r = 255;
                    }
                }
            }

            public int G
            {
                get { return g; }
                set { if (value <= 255)
                    {
                        g = value;
                    } else
                    {
                        g = 255;
                    } 
                }
            }

            public int B
            {
                get { return b; }
                set { if(value <= 255) 
                    { 
                        b = value; 
                    } else { 
                        b = 255; 
                    }
                        
                }
            }
        }
    }
}