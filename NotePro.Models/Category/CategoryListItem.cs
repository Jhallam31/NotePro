using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePro.Models.Category
{
    public class CategoryListItem
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }

        [Display(Name="Notes")]
        public int NoteCount { get; set; }
    }
}
