using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WallsWeb.Models
{
    public class Wall
    {
        public int Id { get; set; }//read and write
        public string Theme { get; set; }//read and write
        public string Description { get; set; }//read and write
        public Side SideLeft { get; set; }//read and write
        public Side SideRight { get; set; }//read and write

    }
}