using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFirstHome.Model
{
    public class Grass:Food
    {
        public Grass(decimal calori, string name) : base(calori)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
