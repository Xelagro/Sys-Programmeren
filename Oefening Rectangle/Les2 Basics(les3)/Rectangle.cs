using System;
using System.Collections.Generic;
using System.Text;

namespace Les2_Basics_les3_
{
    class Rectangle
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.height = height;
        }
        public Rectangle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int size)//viekant
        {
            
        }

        // 2de gedeelte van de opdracht.

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsSquare()
        {
            bool rectangleVierkant;

            if(this.x == this.y)
            {
                rectangleVierkant = true;
            }
            else
            {
                rectangleVierkant = false;
            }
            return rectangleVierkant;
        }

        public void Set(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
