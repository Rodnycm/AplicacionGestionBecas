using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public static class Globals
    {
        public static Usuario usuario { get; set; }

        public static void clear()
        {
            usuario = null;
        }
    }
}
