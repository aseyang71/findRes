using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace findRes.Models
{
    public class cusFavRes
    {
        [Required(ErrorMessage = "Your name is required!")]
        [Display(Name = "Your Name:")]
        public string cusName { get; set; }

        [Required(ErrorMessage = "The restaurant name is required!")]
        [Display(Name = "Restaurant Name:")]
        public string cusResName { get; set; }

        [Display(Name = "Favorite Dish:")]
        public string cusFavDish { get; set; }

        [Display(Name = "Your Phone#:")]
        [Required(ErrorMessage = "Your phone number is required!")]
        [Phone(ErrorMessage = "Phone# is in invalid format!")]
        [StringLength(10, ErrorMessage ="Invalid Phone Number!")]
        [MinLength(10, ErrorMessage ="Phone number must have at least 10 numbers")]
        public string cusPhone {get; set; }
    }
}
