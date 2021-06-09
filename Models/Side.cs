using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WallsWeb.Models
{
    public class Side
    {
        public int Id { get; set; }//read and write
        public string Title { get; set; }//read and write
        public List<Comment> Comments { get; set; }
    }
}