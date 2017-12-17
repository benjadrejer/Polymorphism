using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class DbCommand
    {
        public DbConnection DbConnection { get; private set; }
        public string Instruction { get; private set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection != null && !string.IsNullOrWhiteSpace(instruction))
            {
                DbConnection = dbConnection;
                Instruction = instruction;
            }
            else
            {
                throw new InvalidOperationException("There must be a valid Database connection and instruction");
            }
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("Instruction being executed: {0}",Instruction);
            DbConnection.Close();
        }
    }
}
