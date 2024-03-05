using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Elegant_Sofas.Models
{
    public class SofaGenreViewModel
    {
        public List<Sofas>? Sofas { get; set; }
        public SelectList? Material { get; set; }
        public string? SofaGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
