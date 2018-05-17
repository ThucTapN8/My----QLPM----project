using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQLPhongMay
{
    class Chitietcauhinh
    {
        public int ma { set; get; }
        public String vixuly { set; get; }
        public String ram { set; get; }
        public String diacung { set; get; } 
        public String manhinh { set; get; }
        public String mota { set; get; }

        public bool Kiemtra(Chitietcauhinh obj) {
            if (this.vixuly == obj.vixuly && this.ram == obj.ram && this.diacung == obj.diacung && this.manhinh == obj.manhinh) {
                return true;
            }
            else if (this.mota == obj.mota && this.vixuly=="" && obj.vixuly=="")
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
