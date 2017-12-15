using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionDInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture();

            // InicializaAVariavel

            Console.WriteLine($"Marque: "+voiture.MarqueVoiture);
            Console.WriteLine($"Couler: " + voiture.CoulerVoiture);

            CaracteristqueVoiture caracteristqueVoiture = new CaracteristqueVoiture();
            var coulers = caracteristqueVoiture.AfficherProprieteCoulerVoiture;
            var marques = caracteristqueVoiture.AfficherProprieteMarqueVoiture;

            Console.WriteLine($"Options Marques ");
            foreach (var item in marques)
            {
                Console.WriteLine($"Marque: " + marques.ToString());
            }

            Console.WriteLine($"Options Couler ");
            foreach (var item in coulers)
            {
                Console.WriteLine($"Couler: " + item.ToString());
            }

            IList<ProprietesVoitures> proprietesVoitures = new List<ProprietesVoitures>
            {
                new ProprietesVoitures
                {
                    Propriete = new Propriete() { CoulerVoiture = "Jaune", MarqueVoiture = "GM" }
                }
            };

            Console.ReadKey();

        }
    }
}
