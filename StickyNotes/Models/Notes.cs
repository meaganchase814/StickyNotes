using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StickyNotes.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual List<Group> Category { get; set; }
        public DateTime Now { get; set; }
    }
    public class Group
    {
        public int ID { get; set; }
        public string Category { get; set; }
    }

    public class NotesContext : DbContext
    {
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Group> Category { get; set; }
    }
    
}