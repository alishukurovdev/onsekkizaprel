using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFirstHome.Model
{
    public abstract class Food
    {
        public decimal Calori{ get; set; }
        public Food(decimal calori)
        {
            Calori = calori;
        }
    }
}
