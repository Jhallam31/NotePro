﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePro.Models.Note
{
    public class NoteEdit
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CategoryId { get; set; }

    }
}
