using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TechnicalTask
{
    public class MovieStar
    {
        private readonly string path = @"C:\Users\AllBlacks\source\repos\TechnicalTask\TechnicalTask\input.txt";
        List<Actor> star { get; set; }

        public void JsonMovieStarsGetStar()
        {
            try
            {
                string Newpath = File.ReadAllText(path);

                List<Actor> person = JsonConvert.DeserializeObject<List<Actor>>(Newpath);
                foreach (var item in person)
                {
                    Console.WriteLine(item.Name +" "+ item.Surname);
                    Console.WriteLine(item.Sex);
                    Console.WriteLine(item.Nationality);
                    Console.WriteLine(item.dateOfBirth + " years old.");
                    Console.WriteLine("--------- Next Actor ---------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The File could not be read!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
