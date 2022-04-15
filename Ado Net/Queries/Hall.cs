using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    internal class Hall
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from hall");
        }
        public static void Delete(int id)
        {

            Sql.Execute($"DELETE hall WHERE Id = {id}");
        }
        public static void Create(string name, int SeatCount)
        {
            int choice = 0;
            do
            {
                Console.WriteLine($"[1]-Name\n[2]-SeatCount\n\n[0]-EXIT");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Sql.Execute($@"insert into hall(Name)
values('{name}')
");
                        break;
                    case 2:
                        if (SeatCount<250)
                        {

                        Sql.Execute(@$"insert into hall(Name,SeatCount)
values('{name}',{SeatCount})");
                        }
                        else
                        {
                            Console.WriteLine("seatcount Max size is 250");
                        }
                        break;
                }

            } while (choice != 0);
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM hall WHERE Id={id};");
        }
    }
}
