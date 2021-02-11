using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public static class TempStorage
    {
        private static List<Restaurant> suggestions = new List<Restaurant>();

        public static IEnumerable<Restaurant> Applications => suggestions;

        public static void AddSuggestion(Restaurant suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}