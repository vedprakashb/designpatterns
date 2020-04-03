using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value to be created sql/oracle");
        
            var input = Console.ReadLine();
            if (input.Equals("oracle"))
            {
                IDataBaseFactory ofc = new OracleFactory();
                var oCommand = ofc.GetCommand();
                oCommand.CommandText = "Oracle Command to be executed";
                var oCon = ofc.GetConnection();
                oCon.ConnectionString = "Provider=SQLOLEDB ; Server = Oracle Connection String";
                oCommand.Connection = oCon;
                var odb = new DataBaseHelper(ofc);
                odb.Execute(oCommand);
     
            }
            else if (input.Equals("sql"))
            {
                IDataBaseFactory fc = new SQLFacotry();
                var command = fc.GetCommand();
                command.CommandText = "SQL Command to be executed";
                var con = fc.GetConnection();
                con.ConnectionString = "Server = SQL Connection String";
                command.Connection = con;
                var db = new DataBaseHelper(fc);
                db.Execute(command);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            Console.ReadLine();
        }
    }
}
