using System.Collections.Generic;

namespace SelectionDInformation
{
    public class CaracteristqueVoiture
    {
        private List<string> listeMarque = new List<string>();
        private List<string> listeCouler = new List<string>();

        public List<string> AfficherProprieteMarqueVoiture
        {
            get
            {
                SetListeMarque();
                return listeMarque;
            }
        }

        private void SetListeMarque()
        {
            listeMarque = new List<string>() {"GM", "AUDI", "BMW" };
        }

        public List<string> AfficherProprieteCoulerVoiture
        {
            get
            {
                SetListeCouler();
                return listeCouler;
            }
        }

        private void SetListeCouler()
        {
            listeCouler = new List<string>() { "jeune", "blue", "rouge" };
        }

    }
}
