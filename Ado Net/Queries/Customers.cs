using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class Customers
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from Customers");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Customers WHERE Id = {id}");
        }
        public static void Create(string Name, string Surname,int Age)
        {
            if (Age>0||Age<166)
            {
            Sql.Execute($"INSERT INTO Customers VALUES (N'{Name }', N'{Surname }',{Age})");
            }
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM Customers WHERE Id={id};");
        }

    }
}
