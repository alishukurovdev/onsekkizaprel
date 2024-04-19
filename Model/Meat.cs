using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFirstHome.Model
{
    public class Meat : Food
    {
        public Meat(decimal calori, string type) : base(calori)
        {
        }

        public string Type { get; set; }
    }
}
