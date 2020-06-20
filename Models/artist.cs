using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_music.Models
{
    public class artist
    {
        [Key]
        public int artisID { get; set; }
        public string artisName { get; set; }
        public string albumName { get; set; }
        public string imageURL { get; set; }
        public DateTime releaseDate { get; set; }
        public double price { get; set; }
        public string sampleURL { get; set; }
    }
}
