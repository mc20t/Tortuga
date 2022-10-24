using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class Basket
    {
        List<Dish> DishList = new List<Dish>();
        public int TableNumber;

        public int NextTable(int NT)
        {
            TableNumber = NT;
            return TableNumber;
        }
    }
}