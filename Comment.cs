using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WallsWeb.Models
{
    public class Comment
    {
        public int Id { get; set; }//read and write
        public string Text { get; set; }//read and write
        public int Rating { get; set; }
    }
}