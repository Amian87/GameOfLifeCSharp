using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConwaysGameOfLife
{
    public class World
    {
        public List<List<Cell>> State { get; set; } 


        public World(List<List<Cell>> state)
        {
            this.State = state;
            
        }


        public World Step()
        {
            return this;
        }
    }

    public class Cell : IEquatable<Cell>
    {
        public bool Alive { get; set; }

        public Cell(bool cellStatus)
        {
            this.Alive = cellStatus;
        }
        
        public bool Equals(Cell other)
        {
            if (this.Alive == other.Alive)
            {
                return true;
            }

            return false;
        }
    }
}
