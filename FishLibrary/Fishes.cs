using System;
using System.Collections.Generic;
using System.Text;

namespace FishLibrary
{
    public class Fishes
    {
        public static List<Fish> fish;
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

        public static string Fab(string name, string data, string temp)
        {
            string s = null;
            switch (name)
            {
                case "Pollack":
                    fish.Add(new Pollack(data, temp));
                    if (Checking(name, temp, data) == null)
                    {
                        return null;
                    }
                    s = Checking(name, temp, data);
                    return s;
                case "Salmon":
                    if (Checking(name, temp, data) == null)
                    {
                        return null;
                    }
                    s = Checking(name, temp, data);
                    return s;
                default:
                    return null;
            }
        }

        public static string Checking(string name, string temp, string data)
        {
            DateTime newData = DateTime.Parse(data);
            string[] newTemp = temp.Split(" ");
            int countMin = 0;
            int countMax = 0;
            string errors = "";
            switch (name)
            {
                case "Pollack":
                    for (int i = 0; i <= newTemp.Length; i++)
                    {
                        if (Convert.ToInt32(newTemp[i]) > Pollack.maxTemp)
                        {
                            errors += newData.AddMinutes((i + 1) * 10) + " " + newTemp[i] + " " +  Pollack.maxTemp + ";";
                            countMax++;
                        }
                    }
                    if (countMax*10 >= Pollack.maxTempTime)
                    {
                        return errors + " " + countMax*10;
                    }
                    return null;
                case "Salmon":
                    for (int i = 0; i < newTemp.Length; i++)
                    {
                        if (Convert.ToInt32(newTemp[i]) > Salmon.maxTemp)
                        {
                            int k = i;
                            errors += newData.AddMinutes((k+1) * 10) + " " + newTemp[i] + " " + Salmon.maxTemp + ";";
                            countMax++;
                        }
                        else if (Convert.ToInt32(newTemp[i]) < Salmon.minTemp)
                        {
                            errors += newData.AddMinutes((i + 1) * 10) + " " + newTemp[i] + " " + Salmon.minTemp + ";";
                            countMin++;
                        }
                    }
                    if (countMax * 10 >= Salmon.maxTempTime)
                    {
                        return errors;
                    }
                    else if (countMin * 10 >= Salmon.minTempTime)
                    {
                        return errors;
                    }
                    return null;
                default:
                    return null;
            }
        }
    }
}
