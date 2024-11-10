using System;
namespace Bai2_2
{
    //lop phan so
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
        public double GiaTri()
        {
            return (double)tuso/mauso;
        }
    }
    //Khai báo lớp Phân số
    public class DSPhanSo
    {
        private PhanSo _dsPS;
        private int _size;

        public PhanSo DSPS
        {
            get{
                return _dsPS;
            }
            set{_dsPS=value;}
        }
        public int size
        {
            get{return _size;}
            set{_size=value;}
        }
        PhanSo[] ListPhanSo;
        public void nhapds()
        {
            Console.Write("Nhap so luong phan so:");
            size=int.Parse(Console.ReadLine());
            ListPhanSo = new PhanSo[size];
            for (int i = 0; i < size; i++){
                //nhap list phan so
                Console.Write("Phan so thu {0} la\n",i);
                ListPhanSo[i]= new PhanSo();
                ListPhanSo[i].Nhap();
            }
        }
        public void Xuatds()
        {
            Console.Write("\nDanh sach phan so:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("  ");
                // in list phan so
                ListPhanSo[i].Xuat();
            }
        }
        public void PhanSoMax()
        {
            double max = ListPhanSo[0].GiaTri();
            int vitrimax=0;
            for (int i = 0; i < size; i++)
            {
                if(ListPhanSo[i].GiaTri() > max)
                {
                    max=ListPhanSo[i].GiaTri();
                    vitrimax=i;
                }
                
            }
            Console.Write("\nPhan so lon nhat la:");
                ListPhanSo[vitrimax].Xuat();
        }
        public void XapSep()
        {
            PhanSo temp;
            for(int i=0;i<size;i++)
            {
                for(int j=i;j<size;j++)
                {
                    if(ListPhanSo[i].GiaTri()>ListPhanSo[j].GiaTri())
                    {
                        temp = ListPhanSo[i];
                        ListPhanSo[i] = ListPhanSo[j];
                        ListPhanSo[j] = temp;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                ListPhanSo[i].Xuat();
            }
        }
    
    } // End of class DSPhanSo
    
    
    // Main program 
    class Program
    {
        static void Main()
        {
            DSPhanSo dS = new DSPhanSo();
            dS.nhapds();
            dS.Xuatds();
            dS.PhanSoMax();
            dS.XapSep();
            dS.Xuatds();
            
        }
    } // End of class Program
}