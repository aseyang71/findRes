using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace findRes.Models
{
    public class topRes
    {
        
        public topRes(int Rank)
        {
            rank = Rank;
        }

        [Required]
        public int rank { get; set; }

        [Required]
        public string resName { get; set; }

        public string? favDish { get; set; } = "It's all tasty!";

        [Required]
        public string address { get; set; }
        public string? phone { get; set; }
        public string? webLink { get; set; } = "Coming soon.";

        public static topRes[] GetTopRes()
        {
            topRes r1 = new topRes(1)
            {
                resName = "Koko Lunchbox",
                favDish = "K4. Bibimbop",
                address = "1175 N Canyon Rd #3420",
                phone = "(801)850-4358",
                webLink = "facebook.com/kokobobox"
            };

            topRes r2 = new topRes(2)
            {
                resName = "Two Jacks Pizza",
                favDish = "Jack's Meats",
                address = "80W Center St",
                phone = "(801)377-4747",
                webLink = "twojackspizza.com"
            };

            topRes r3 = new topRes(3)
            {
                resName = "Saigon Cafe",
                favDish = "Chicken Fried Rice",
                address = "440 W 300 S",
                phone = "(801)812-1173",
                webLink = "saigoncafeprovo.biz"
            };

            topRes r4 = new topRes(4)
            {
                resName = "Bombay House",
                favDish = "Lamb Coconut Kurma",
                address = "463 N University Ave",
                phone = "(801)373-6677",
                webLink = "bombayhouse.com"
            };

            topRes r5 = new topRes(5)
            {
                resName = "Tucanos Brazilian Grill",
                favDish = null,
                address = "545 E University Pkwy",
                phone = "(801)224-4774",
                webLink = "tucanos.com"
            };

            return new topRes[] { r1, r2, r3, r4, r5 };
        }

    }
}
