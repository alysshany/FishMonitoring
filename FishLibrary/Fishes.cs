using System;
using System.Collections.Generic;
using System.Text;

namespace FishLibrary
{
    public class Fishes
    {
        public static string Info(string name)
        {
            switch (name)
            {
                case "Pollack":
                    string pollack = Pollack.maxTemp.ToString() + " " + Pollack.maxTempTime.ToString() + " " +
                        Pollack.minTemp.ToString() + " " + Pollack.minTempTime.ToString();
                    return pollack;
                case "Salmon":
                    string salmon = Salmon.maxTemp.ToString() + " " + Salmon.maxTempTime.ToString() + " " +
                        Salmon.minTemp.ToString() + " " + Salmon.minTempTime.ToString();
                    return salmon;
                default:
                    return null;
            }
        }
    }
}
