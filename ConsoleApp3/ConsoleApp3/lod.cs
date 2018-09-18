using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Lod
    {
        private int locY = 5;
        private int locX = 5;
        private int lenght = 3;
        private bool direction = true; // true = horizontální, false = vertikální

        public void changeDirection(bool newDirection)
        {
            if (direction == true)
            {
                direction = false;
            } else
            {
                direction = true;
            }
            
        }
    }
}
