using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            TimeOut = new TimeSpan(0, 2, 0);
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle Database connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle Database connection");
        }
    }
}
