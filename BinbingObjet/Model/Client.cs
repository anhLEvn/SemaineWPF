using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinbingObjet.Model
{
   public class Client : INotifyPropertyChanged
    {
      //  public int Id { get; set; }

        private int id;

        public int Id
        {
            get { return id; }
            set { 
                id = value;
                JaiChanger("Id");
            }
        }

        private void JaiChanger(string v)
        {
           if(PropertyChanged != null)
            {
                PropertyChanged(this, PropertyChangedEventHandler(v))
            }
                    
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
