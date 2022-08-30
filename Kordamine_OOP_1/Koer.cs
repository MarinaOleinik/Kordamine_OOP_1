using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Koer : Koduloom
    {
        public string toug;//tõug-порода
        //public Koer(string toug, string nimi, string varv, char sugu, double kaal, int vanus, bool elav) :base(nimi,varv,sugu,kaal,vanus,elav)  
        //{
        //    this.toug = toug;
        //}
        public Koer(string toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.toug = toug;
        }
        //public override void print_Info()
        //{
        //    string sugu_text = "";
        //    if (sugu == 'I')
        //    {
        //        sugu_text = "Isane";
        //    }
        //    else if (sugu == 'E')
        //    {
        //        sugu_text = "Emane";
        //    }
        //    Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", toug, varv, nimi, sugu_text, kaal, vanus);
        //}
        public override void print_Info()
        {
            Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", toug, varv, nimi, loomaSugu, kaal, vanus);
        }
    }
}
