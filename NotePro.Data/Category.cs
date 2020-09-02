using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePro.Data
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
