using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace findRes.Models
{
    public static class TempStorage
    {
        private static List<cusFavRes> applications = new List<cusFavRes>();

        public static IEnumerable<cusFavRes> Applications => applications;

        public static void AddApplication(cusFavRes application)
        {
            applications.Add(application);
        }
    }
}
