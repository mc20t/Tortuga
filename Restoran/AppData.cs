using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class AppData
    {
        public static TortugaDBEntities1 Context { get; } = new TortugaDBEntities1();
    }
}
