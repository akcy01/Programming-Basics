using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Abstract.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlServer sql = new SqlServer();
            sql.Add();
        }
    }
}
