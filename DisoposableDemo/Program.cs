using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DisoposableDemo
{
    //class Program
    //{
    //    static Dictionary<string, int> tableRowCount = new Dictionary<string, int>();
    //    static void Main(string[] args)
    //    {
    //        var connection = GetConnection();
    //        var tableCollection = connection
    //            .Query<string>
    //            ("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");

    //        foreach (string tablename in tableCollection)
    //        {
    //            AddTableCount(tablename);
    //            Console.WriteLine(tablename);
    //        }
    //    }
    //        private static void AddTableCount(string tablename)
    //    {
    //         using SqlConnection connection = GetConnection();
    //        tableRowCount.Add(tablename, connection
    //            .Query($"SELECT COUNT(*) as V_COUNT FROM {tablename}").First().V_COUNT);
            
    //    }

    //    private static SqlConnection GetConnection()
    //    {
    //        var connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=msdb;MultipleActiveResultSets=true");
            
    //        connection.Open();
    //        //Console.WriteLine(connection.State);
    //        return connection;

    //    }
    //}

}
