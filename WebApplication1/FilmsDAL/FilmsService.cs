using FilmInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDAL
{
    public class FilmsService
    {
        public List<Film> Films { get; set; }

        public FilmsService() 
        {
            Films = new List<Film>()
            {
                new Film() {FilmName = "film1",
                    Produser = "produser1",
                    Style = "style1",
                    About="about",
                    Sessions = new List<string>() {"date1", "date2", "date3" } },

                new Film() {FilmName = "film2",
                    Produser = "produser2",
                    Style = "style2",
                    About="about",
                    Sessions = new List<string>() {"date1", "date2", "date3" } },

                new Film() {FilmName = "film3",
                    Produser = "produser3",
                    Style = "style3",
                    About="about",
                    Sessions = new List<string>() {"date1", "date2", "date3" } },

                new Film() {FilmName = "film4",
                    Produser = "produser4",
                    Style = "style4",
                    About="about",
                    Sessions = new List<string>() {"date1", "date2", "date3" } },

                new Film() {FilmName = "film5",
                    Produser = "produser5",
                    Style = "style5",
                    About="about",
                    Sessions = new List<string>() {"date1", "date2", "date3" } }
            };
        }

        public void AddFilm(Film film)
        {
            Films.Add(film);
        }

        public void DeleteFilm(int index)
        {
            Films.RemoveAt(index);
        }
    }
}
