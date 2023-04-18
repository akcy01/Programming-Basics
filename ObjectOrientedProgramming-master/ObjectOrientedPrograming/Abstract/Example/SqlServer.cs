using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Abstract.Example
{
    public class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("SqlServer tarafından silindi");
        }
    }
}
