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

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Artis Name")]
        public string artisName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Album Name")]
        public string albumName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Image URL")]
        public string imageURL { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Date Release")]
        public DateTime releaseDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Price")]
        public double price { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Sample URL")]
        public string sampleURL { get; set; }
    }
}
