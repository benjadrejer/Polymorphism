using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            TimeOut = new TimeSpan(0, 2, 0);
        }

        public override void Open()
        {
            Console.WriteLine("Opening Sql Database connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Sql Database connection");
        }
    }
}
