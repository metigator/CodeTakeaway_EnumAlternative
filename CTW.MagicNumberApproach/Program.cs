using System; 

namespace CTW.MagicNumberApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var country = Console.ReadLine();

            //if(country == CountryConstants.Egypt)
            //{
            //    // TODO
            //}
            Console.WriteLine($"Country Iso: {CountryConstants.EgyptISO3}");
            Console.WriteLine($"Area Code: {CountryConstants.EgyptAreaCode}");
            Console.ReadKey();
        }
    }   

    public class CountryConstants
    {
        public static int AlgeriaAreaCode = 213;
        public static string AlgeriaISO3 = "ALG";


        public static int BahrainAreaCode = 973;
        public static string BahrainISO3 = "BHR";

        public static int ComorosAreaCode = 269;
        public static string ComorosISO3 = "COM";

        public static int DjiboutiAreaCode = 253;
        public static string DjiboutiISO3 = "DJI";

        public static int EgyptAreaCode = 20;
        public static string EgyptISO3 = "EGY";

        public static int IraqAreaCode = 964;
        public static string IraqISO3 = "IRQ";

        public static int JordanAreaCode = 962;
        public static string JordanISO3 = "JOR";

        public static int KuwaitAreaCode = 965;
        public static string KuwaitISO3 = "KWT";

        public static int LebanonAreaCode = 961;
        public static string LebanonISO3 = "LBN";


        public static int LibyaAreaCode = 218;
        public static string LibyaISO3 = "LBY";

        public static int MauritaniaAreaCode = 222;
        public static string MauritaniaISO3 = "MRT";

        public static int MoroccoAreaCode = 212;
        public static string MoroccoISO3 = "MOR";

        public static int OmanAreaCode = 968;
        public static string OmanISO3 = "OMN";

        public static int PalestineAreaCode = 970;
        public static string PalestineISO3 = "PSE";

        public static int QatarAreaCode = 974;
        public static string QatarISO3 = "QAT";

        public static int Saudi_ArabiaAreaCode = 966;
        public static string Saudi_ArabiaISO3 = "KSA";

        public static int Somalia = 252;
        public static string SomaliaISO3 = "SOM";

        public static int Sudan = 249;
        public static string SudanISO3 = "SDN";

        public static int Syria = 963;
        public static string SyriaISO3 = "SYR";

        public static int Tunisia = 216;
        public static string TunisiaISO3 = "TUN";

        public static int United_Arab_Emirates = 971;
        public static string United_Arab_EmiratesISO3 = "UAE";

        public static int Yemen = 967;
        public static string YemenISO3 = "YEM";
    }
}
