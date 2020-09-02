using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NotePro.Data;
using NotePro.Models.Note;

namespace NotePro.Models.Category
{
    public class CategoryDetail
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<NotePro.Data.Note> Notes { get; set; } = new List<NotePro.Data.Note>();

        [Display(Name="Notes")]
        public int NoteCount { get; set; }


    }
}
