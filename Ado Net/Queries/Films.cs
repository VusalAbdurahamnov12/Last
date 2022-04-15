using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    public class Films
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from films");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE films WHERE Id = {id}");
        }
        public static void Create(string name, string ReleaseDate)
        {
            Sql.Execute($"INSERT INTO films VALUES (N'{name}', N'{ReleaseDate}')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM films WHERE Id={id};");
        }
    }
}
