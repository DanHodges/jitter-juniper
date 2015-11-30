using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class Jot
    {
        public object Author { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Key]
        public int JotId { get; set; }
        public string Picture { get; set; }

        public int CompareTo(object obj)
        {
            Jot other_jot = obj as Jot;
            // Multiply times -1 b/c DateTimes CompareTo Sorts Ascendingly by default;
            //We Want tot soft Jots descendingly
            return -1*(this.Date.CompareTo(other_jot.Date));
        }
    }
}