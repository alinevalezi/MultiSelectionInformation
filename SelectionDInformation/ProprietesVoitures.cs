using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionDInformation
{
    public class ProprietesVoitures
    {
        private Propriete proprietes = new Propriete();
        
        public Propriete Propriete
        {
            get { return proprietes; }
            set { proprietes = value; }
        }
    }

    public class Propriete
    {
        private string MarqueVoiture { get; set; }
        private string CoulerVoiture { get; set; }
    }
}
