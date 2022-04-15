using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class FilmGenres
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from FilmGenres");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE FilmGenres WHERE Id = {id}");
        }
        public static void Create(int FilmId, int GenresId)
        {
            Sql.Execute($"INSERT INTO FilmGenres VALUES (N'{FilmId }', N'{GenresId }')");
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM FilmGenres WHERE Id={id};");
        }
    }
}
