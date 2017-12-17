using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString)){
                ConnectionString = connectionString;
            }
            else
            {
                throw new InvalidOperationException("The connectionstring cannot be null or empty");
            }

        }

        public abstract void Open();

        public abstract void Close();


    }
}
