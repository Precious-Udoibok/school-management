using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeCamp_5._0_Task_4
{
    internal class FellowshipUnit
    {

        public FellowshipUnit (int id,string name )
        {
            ID = id; Name = name;
        }

        public int ID { set; get; }
        public string Name { set; get; }
        public Student studentID { set; get; }
    }
}
