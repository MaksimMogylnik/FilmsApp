using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmInfos
{
    public class Film
    {
        public string FilmName { get; set; }

        public string Produser { get; set; }

        public string Style { get; set; }

        public string About { get; set; }

        public List<string> Sessions { get; set; }
    }
}
