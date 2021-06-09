using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WallsWeb.Models
{
    public class WallManager
    {
        private string Serialize(Wall wall)
        {
            string xml = string.Empty;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Wall));
          
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, wall);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;

        }


        public Wall GetWall(int id)   
        {
            Wall wall = new Wall() {
                Id = 1,
                Theme = "Theme 1",
                Description = "Description 1",
                SideLeft = new Side() {
                        Id = 1,
                        Title = "Title Side 1",
                        Comments = new List<Comment>() { new Comment() {
                             Id = 1,
                              Rating = 1,
                              Text = "Text"
                        },  new Comment() {
                             Id = 3,
                              Rating = 1,
                              Text = "Text sccszxc"
                        }
                    }
                 },
             SideRight = new Side()
             {
                 Id = 2,
                 Title = "Title Side 2",
                 Comments = new List<Comment>() { new Comment() {
                             Id = 2,
                              Rating = 2,
                              Text = "Text 2"
                        }
                    }
             }
            };

            var xml = Serialize(wall);


            return wall;
        }
    }
}