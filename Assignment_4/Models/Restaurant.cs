using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_4.Models
{
    //I Created a single Class that handles both inputs and initial bootup.
    //I figure it makes more sense that a submission could be saved on a database (eventually)
    //and then the sit owner can go and change the Rank, FavoriteDish, etc.

    public class Restaurant
    {
        //public Restaurant(int rank)
        //{
        //    Rank = rank;
        //}

#nullable enable
        public int? Rank { get; set; } = 404;
#nullable disable

        [Required]
        public string Name { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required]
        public string RestaurantName { get; set; }

#nullable enable
        [Display(Name ="Favorite Dish")]
        public string? FavoriteDish { get; set; } = "It's all tasty!";
#nullable disable

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Phone]
        public string Phone { get; set; }

        public string Website { get; set; } = "Coming Soon.";




        //This is for loading a view-only Top 5 for the home page
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant()
            {
                Rank = 1,
                Name = "Jered White",
                RestaurantName = "Arbys",
                FavoriteDish = "roast beef",
                Address = "University Ave",
                Phone = "9992221111",
                Website = "arbys.com"
            };
            Restaurant r2 = new Restaurant()
            {
                Rank = 2,
                Name = "Jered White",
                RestaurantName = "Taco Bell",
                Address = "University Ave",
                Phone = "1234567890",
                Website = "Tacobell.com"
            };
            Restaurant r3 = new Restaurant()
            {
                Rank = 3,
                Name = "Jered White",
                RestaurantName = "Mickey D's",
                FavoriteDish = "Nugs",
                Address = "University Ave",
                Phone = "1234567890",
            };
            Restaurant r4 = new Restaurant()
            {
                Rank = 4,
                Name = "Jered White",
                RestaurantName = "Sonic",
                FavoriteDish = "Ice Cream",
                Address = "University Ave",
                Phone = "1234567890",
            };
            Restaurant r5 = new Restaurant()
            {
                Rank = 5,
                Name = "Jered White",
                RestaurantName = "Noodles & Co.",
                FavoriteDish = "Company",
                Address = "University Ave",
                Phone = "1234567890",
            };

            return (new Restaurant[] { r1, r2, r3, r4, r5 });
        }

        /*
        //Function for viewing the submitted suggestions
        public static Restaurant[] GetSuggestions()
        {

            return ();
        }*/
    }

}
