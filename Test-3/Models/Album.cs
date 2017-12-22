using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_3.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }
        
        public List<Review> Reviews { get; set; }

    }
}