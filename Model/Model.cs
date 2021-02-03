using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Model
    {
        public Model()
        {

        }
        public Model(string marka, string model, string numara)
        {
            Marka = marka;
            Model = model;
            Numara = numara;
        }
        public Model(int stokid, string marka, string model, string numara)
        {
            Stokid = stokid;
            Marka = marka;
            Model = model;
            Numara = numara;
        }
        public int Stokid { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Numara { get; set; }
    }
}
