using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class tickets
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from tickets");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE tickets WHERE Id = {id}");
        }
        public static void Create(string SoldDate, int Price,int Place,int CustomersId,int HallId,int FilmId,int SessonId)
        {
            Sql.Execute($"INSERT INTO tickets VALUES ('{SoldDate}','{Price}','{Place}','{CustomersId}','{HallId}','{FilmId}','{SessonId}')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM tickets WHERE Id={id};");
        }
    }
}
