using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmsDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class FilmsListModel : PageModel
    {
        public FilmsService filmsService { get; set; }

        public FilmsListModel()
        {
            filmsService = new FilmsService();
        }

        public void OnGet()
        {
        }
    }
}
