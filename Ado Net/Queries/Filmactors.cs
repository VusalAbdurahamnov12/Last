using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class Filmactors
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from Filmactors");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Filmactors WHERE Id = {id}");
        }
        public static void Create(int FilmId,int ActorID)
        {
            Sql.Execute($"INSERT INTO Filmactors VALUES ('{FilmId}','{ActorID}')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM Filmactors WHERE Id={id};");
        }
    }
}
