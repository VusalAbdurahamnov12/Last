using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class genres
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from genres");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE genres WHERE Id = {id}");
        }
        public static void Create(string name)
        {
            Sql.Execute($"INSERT INTO genres VALUES ('{name}')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM genres WHERE Id={id};");
        }
    }
}
