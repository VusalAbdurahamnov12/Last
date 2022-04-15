using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class Session
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from session");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE session WHERE Id = {id}");
        }
        public static void Create(string time)
        {
            Sql.Execute($"INSERT INTO session VALUES ('{time}')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM session WHERE Id={id};");
        }
    }
}
