using System;
using System.Collections.Generic;
using System.Linq;

namespace CTW.EnumObjectPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var c1 = Country.Egypt;
            //var c2 = Country.Egypt;
            //Console.WriteLine(c1.Equals(c2));
            //Console.WriteLine(ReferenceEquals(c1,c2));
            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(c1);
            //foreach (var country in Country.All)
            //{
            //    Console.WriteLine(country);
            //}

            Console.Write("Enter Iso:");
            var iso = Console.ReadLine();
            var country = Country.FromISO(iso);
            Console.WriteLine(country);
            Console.ReadKey();
        }
    } 

    public class Country
    {
        public static readonly Country Algeria = new Country(213, "Algeria", "ALG");
        public static readonly Country Bahrain = new Country(973, "Bahrain", "BHR");
        public static readonly Country Comoros = new Country(213, "Comoros", "COM");
        public static readonly Country Djibouti = new Country(253, "Djibouti", "DJI");
        public static readonly Country Egypt = new Country(20, "Egypt", "EGY");
        public static readonly Country Iraq = new Country(964, "Iraq", "IRQ");
        public static readonly Country Jordan = new Country(962, "Jordan", "JOR");
        public static readonly Country Kuwait = new Country(965, "Kuwait", "KWT");
        public static readonly Country Lebanon = new Country(961, "Lebanon", "LBN");
        public static readonly Country Libya = new Country(218, "Libya", "LBY");
        public static readonly Country Mauritania = new Country(222, "Mauritania", "MRT");
        public static readonly Country Morocco = new Country(212, "Morocco", "MOR");
        public static readonly Country Oman = new Country(968, "Oman", "OMN");
        public static readonly Country Palestine = new Country(970, "Palestine", "PSE");
        public static readonly Country Qatar = new Country(974, "Qatar", "QAT");
        public static readonly Country Saudi_Arabia = new Country(966, "Saudi Arabia", "KSA");
        public static readonly Country Somalia = new Country(252, "Somalia", "SOM");
        public static readonly Country Sudan = new Country(249, "Sudan", "SDN");
        public static readonly Country Syria = new Country(963, "Syria", "SYR");
        public static readonly Country Tunisia = new Country(216, "Tunisia", "TUN");
        public static readonly Country United_Arab_Emirates = new Country(971, "United Arab Emirates", "UAE");
        public static readonly Country Yemen = new Country(967, "Yemen", "YEM");
   
        private Country(int areaCode, string name, string iso3Code)
        {
            Name = name;
            Iso3Code = iso3Code;
            AreaCode = areaCode;
        }

        public string Name { get; private set; }   
        public string Iso3Code { get; private set; } 
        public int AreaCode { get; private set; }


        public static IEnumerable<Country> All =>
            new[] {
                Algeria, Bahrain, Comoros, Djibouti, Egypt, Iraq, Jordan,
            Kuwait, Lebanon, Libya, Mauritania, Morocco, Oman, Palestine,
            Qatar, Saudi_Arabia, Somalia, Sudan, Syria, Tunisia,
            United_Arab_Emirates, Yemen
            };

        public static Country FromISO(string value) => All.Single(x => x.Iso3Code == value);
        public static Country FromAreaCode(int value) => All.Single(x => x.AreaCode == value);
        public override string ToString()
        {
            return $"{Name} ({Iso3Code}) [+{AreaCode}]";

        }
    }
}
