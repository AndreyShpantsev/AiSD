using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD.Graphs
{
    public class Vertex
    {
        public int Number { get; set; }
        public Vertex(int number) 
        {
            Number = number;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
