using System;
using System.ComponentModel;
using System.Reflection;

namespace CTW.Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var country = Country.Egypt;
            Console.WriteLine($"Country: {country}");
            FieldInfo fi = country.GetType().GetField(country.ToString());
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if(attributes is { } && attributes.Length>0)
            {
                Console.WriteLine($"ISO: { attributes[0].Description}");

            }
            Console.WriteLine($"Area Code: {(int)country}");

            Console.WriteLine($"Country: {(Country)39}");
            Console.ReadKey();
        }
    }

    public enum Country
    {
        [Description("ALG")]
        Algeria = 213,

        [Description("BHR")]
        Bahrain = 973,

        [Description("COM")]
        Comoros = 269,

        [Description("DJI")]
        Djibouti = 253,

        [Description("EGY")]
        Egypt = 20,

        [Description("IRQ")]
        Iraq = 964,

        [Description("JOR")]
        Jordan = 962,

        [Description("KWT")]
        Kuwait = 965,

        [Description("LBN")]
        Lebanon = 961,

        [Description("LBY")]
        Libya = 218,

        [Description("MRT")]
        Mauritania = 222,

        [Description("MOR")]
        Morocco = 212,

        [Description("OMN")]
        Oman = 968,

        [Description("PSE")]
        Palestine = 970,

        [Description("QAT")]
        Qatar = 974,

        [Description("KSA")]
        Saudi_Arabia = 966,

        [Description("SOM")]
        Somalia = 252,

        [Description("SDN")]
        Sudan = 249,

        [Description("SYR")]
        Syria = 963,

        [Description("TUN")]
        Tunisia = 216,

        [Description("UAE")]
        United_Arab_Emirates = 971,

        [Description("YEM")]
        Yemen = 967
    }

}
