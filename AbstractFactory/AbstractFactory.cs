using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DataBaseHelper
    {
        IDataBaseFactory factory;
        public DataBaseHelper(IDataBaseFactory dbFactory)
        {
            factory = dbFactory;
        }

        public void Execute(DbCommand cmd)
        {
            Console.WriteLine($"Commandtext :-- {cmd.CommandText}");
            Console.WriteLine($"Connection string  :-- {cmd.Connection.ConnectionString}");
        }

    }
    public interface IDataBaseFactory
    {
        DbConnection GetConnection();
        DbCommand GetCommand();


    }
    public class SQLFacotry : IDataBaseFactory
    {
        public DbCommand GetCommand()
        {
            return new SqlCommand();
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection();
        }
    }
    public class OracleFactory : IDataBaseFactory
    {
        public DbCommand GetCommand()
        {
            return new OleDbCommand();
        }

        public DbConnection GetConnection()
        {
            return new OleDbConnection();
        }
    }
}
