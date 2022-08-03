using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidentEvilInventoryApp.Classes
{
    internal class Grid
    {
        private int width;
        private int height;
        private int[,] gridArray;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;

            gridArray = new int[width, height];

            Debug.Write(width + " " + height);
        }
    }
}
