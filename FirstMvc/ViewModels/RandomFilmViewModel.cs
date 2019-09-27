using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMvc.Models;

namespace FirstMvc.ViewModels
{
    public class RandomFilmViewModel
    {
        public Film Film { get; set; }

        public List<Kolcsonzok> Kolcsonzok { get; set; }
    }
}