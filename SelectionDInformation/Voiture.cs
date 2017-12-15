using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionDInformation
{
    public class Voiture
    {
        private string marque;
        private string couleur;
        private CaracteristqueVoiture caracteristicVoitures;

        public string MarqueVoiture
        {
            get
            {
                SetMarqueVoiture();
                return marque;
            }

        }

        private void SetMarqueVoiture()
        {
            marque = "GM";
        }

        public string CoulerVoiture
        {
            get
            {
                SetCoulerVoiture();
                return couleur;
            }
        }

        private void SetCoulerVoiture()
        {
            couleur = "jeune";
        }

        
        

    }
}
