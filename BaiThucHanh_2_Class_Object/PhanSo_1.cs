using System;
namespace ProgamPhanso
{
    public class PhanSo
    {
        private int tuso;
        private int mauso;
        public int TuSo
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int MauSo
        {
            get { return mauso; }
            set { if (value != 0) mauso = value; }
        }
        public PhanSo(int ts = 0, int ms = 1)
        {
            tuso = ts;
            mauso = ms;
        }
        public PhanSo(PhanSo p)
        {
            tuso=p.tuso;
            mauso=p.mauso;
        }
        public void Nhap()
        {
            Console.Write("Tu so:");
            tuso = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Mau so:");
                mauso = int.Parse(Console.ReadLine());
            } while (mauso == 0);

        }
        public void Xuat()
        {
            Console.Write("{0}/{1}", tuso, mauso);

        }
        public int UCLN(int a, int b)
        {
            while (a * b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        public void ToiGian()
        {
            int temp = UCLN(tuso, mauso);
            tuso /= temp;
            mauso /=temp;
        }
        public PhanSo Cong(PhanSo a)
        {
            PhanSo PsTong = new PhanSo();
           PsTong.tuso=this.tuso*a.mauso+a.tuso*this.mauso;
            PsTong.mauso=this.mauso*a.mauso;
            return PsTong;
        }
    }

    class Progam
    {
        public static void Main()
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            ps1.Nhap();
            ps1.Xuat();
            Console.Write("\n");
            ps2.Nhap();
            Console.Write("\n");
            Console.Write("Phan so toi gian la:");
            ps1.ToiGian();
            ps1.Xuat();
            Console.Write("\n Tong 2 phan so:");
            ps3= ps1.Cong(ps2);
            ps3.ToiGian();
            ps3.Xuat();


        }
    }
}
