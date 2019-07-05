using System;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Aplication-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Aplication-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
        public static int CalculatAge(this DateTime theDateTime)
        {
            var Age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(Age) > DateTime.Today)
                Age--;

            return Age;
        }
    }
}