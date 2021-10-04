using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegedus_Zsofia_14SZ_dolgozat_2021._10._04
{
    enum AutoMarka
    {
        Mazda,
        Opel,
        BMW,
        Audi,
        Nissan,

    }

    class Autok
    {
        private int _atagfogyasztas;
        private byte _tankmerete;
        private byte _aktbenzinmennyiseg;
        private string _marka;
        private bool _matrica;
        private string _rendszam;

        public int Atagfogyasztas
        { get => _atagfogyasztas;
          set => _atagfogyasztas = value;
        }
        public byte Tankmerete
        { get => _tankmerete;
            set
            {
                Random rnd = new Random();
                int vm = 0;
           
                for (int i = 0; i < 30; i++)
                {
                    int tankm = rnd.Next(20, 101);

                }
              
            }
        }
      
        public byte Aktbenzinmennyiseg
        {
          get => _aktbenzinmennyiseg;
            set
            {

            }
        }
        public string Marka
        {
          get => _marka;
          set => _marka = value;
        }
        public bool Matrica
        {
          get => _matrica;
          set => _matrica = value;
        }
        public string Rendszam
        {
            get => _rendszam;
            set
            {
                char[] betuk = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 30; i++)
                {
                    randomString += betuk[r.Next(20, 101)].ToString();
                    Console.WriteLine("A rendszam első fele: " + betuk);


                }
                
            }


        }

        

        static void Main(string[] args)
        {
            List<AutoMarka> autolista = new List<AutoMarka>();
            Random au = new Random();

            Console.WriteLine("A lista 30 random autóval: ");
            Console.WriteLine("Ez az autó képes a legtöbb kilómétert még menni: ");
            Console.WriteLine("A legtöbb matricával rendelkező, azonos típúsú autók: ");

            Console.ReadKey();
        }
    }

}
        
    

