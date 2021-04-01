using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressAPI.DataSource
{
    public class Maker
    {
        private static int id = 0;
        public int MakerID { get; }
        public string MakerName { get; set; }

        public Maker()
        {
            MakerID = ++id;
            MakerName = "Some other guy -_-";
        }

        public Maker(string makerName)
        {
            MakerID = ++id;
            MakerName = makerName;
        }
    }
}
