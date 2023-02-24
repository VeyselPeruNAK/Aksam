using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    public class Bisiklet
    {
        private int ID;
        private string _Marka;
        public string Marka
        {
            get { return this._Marka; }
            set { this._Marka = value; }
        }

        private string _Model;
        public string Model
        {
            get { return this._Model; } 
            set { this._Model= value; } 
        }

        private float _JantBoyutu;
        public float JantBoyutu
        {
            get { return this._JantBoyutu; }
            set { this._JantBoyutu = value; }
        }

        public byte VitesSayisi { get => _VitesSayisi; set => _VitesSayisi = value; }
        private byte _VitesSayisi;
    }
}
