using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FontArranger
{
    class Character
    {
        public Character(Image i, Point p,char c)
        {
            image = i;
            position = p;
            character = c;
        }
        public Character(Image i, Point p)
        {
            image = i;
            position = p;
        }
        public Character(Image i, char c)
        {
            image = i;
            character = c;
        }

        public Image image;
        public Point position;
        public char character;
        public int rowMaxHeight;
    }
}
