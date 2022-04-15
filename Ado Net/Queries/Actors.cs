using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Net.Queries
{
    public class Actors
    {
        public static void ShowAll()
        {
            Sql.Select($"select *from actors");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE actors WHERE Id = {id}");
        }
        public static void Create(string name, string Surname,int age)
        {
            int choice =0;
            do
            {
            Console.WriteLine($"[1]-Name\n[2]-Surname\n[3]-AGe\n[0]-EXIT");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Sql.Execute($@"insert into actors(Name)
values('{name}')
");
                    break;
                case 2:
                    Sql.Execute(@$"insert into actors(Name,Surname)
values('{name}','{Surname}')");
                    break;
                case 3:
                        if (age>0||age<166)
                        {

                        Sql.Execute(@$"insert into actors(Name,Surname,age)
values('{name}','{Surname}',{age})");
                        }
                        else
                        {
                            Console.WriteLine("Age must be 0-166 interval");
                        }
                        break;
                }

            } while (choice!=0);
        }
        public static void update(string name, string Surname, int age)
        {
            int choice = 0;
            do
            {
                Console.WriteLine($"[1]-Name\n[2]-Surname\n[3]-AGe\n[0]-EXIT");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Sql.Execute($@"UPDATE actors
SET Name = 'A'
WHERE Name = 'test'')
");
                        break;
                    case 2:
                        Sql.Execute(@$"insert into actors(Name,Surname)
values('{name}','{Surname}')");
                        break;
                    case 3:
                        if (age > 0 || age < 166)
                        {

                            Sql.Execute(@$"insert into actors(Name,Surname,age)
values('{name}','{Surname}',{age})");
                        }
                        else
                        {
                            Console.WriteLine("Age must be 0-166 interval");
                        }
                        break;
                }

            } while (choice != 0);
        }
        public static void GetById(string query)
        {
            Sql.Select(query);
        }
        public static void GetById(int id)
        {
            Sql.Select($"SELECT * FROM actors WHERE Id={id};");
        }
    }
}

