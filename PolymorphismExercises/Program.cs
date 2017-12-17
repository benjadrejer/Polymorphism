using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand dbCommand = new DbCommand(new OracleConnection("Oracle-2017"), "Insert table into Oracle Database");
            dbCommand.Execute();

            Console.ReadKey();
        }
    }
}
