using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepToanPhanSo
{
    public class PhanSo
    {
        private int tuso, mauso;
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { mauso = (value == 0 ? 1 : value); }
        }
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int ts, int ms)
        {
            tuso = ts;
            mauso = (ms == 0 ? 1 : ms);
        }
        public PhanSo congPhanSo(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.mauso + this.mauso * p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.toiGianPhanSo();
            return kq;
        }
        public PhanSo truPhanSo(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.mauso - this.mauso * p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.toiGianPhanSo();
            return kq;
        }
        public PhanSo nhanPhanSo(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.tuso;
            kq.mauso = this.mauso * p.mauso;
            kq.toiGianPhanSo();
            return kq;
        }
        public PhanSo chiaPhanSo(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = this.tuso * p.mauso;
            kq.mauso = this.mauso * p.tuso;
            kq.toiGianPhanSo();
            return kq;
        }
        private void toiGianPhanSo()
        {
            int u = FactoryStatic.UCLN(tuso, mauso);
            if (u != 0)
            {
                tuso /= u;
                mauso /= u;
            }    
        }

        public static PhanSo congPhanSo(PhanSo ps1, PhanSo ps2)
        {
            return ps1.congPhanSo(ps2);
        }

        public static PhanSo truPhanSo(PhanSo ps1,PhanSo ps2)
        {
            return ps1.truPhanSo(ps2);
        }

        public static PhanSo nhanPhanSo(PhanSo ps1,PhanSo ps2)
        {
            return ps1.nhanPhanSo(ps2);
        }

        public static PhanSo chiaPhanSo(PhanSo ps1,PhanSo ps2)
        {
            return ps1.chiaPhanSo(ps2);
        }
    }
}
