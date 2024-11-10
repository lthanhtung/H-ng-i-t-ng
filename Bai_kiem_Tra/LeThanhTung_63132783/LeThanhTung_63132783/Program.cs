using System;
namespace LeThanhTung_63132783_De1
{
    public class XeMay
    {
        public string BienSo { get; set; }
        public int Namsanxuat { get; set; }
        public double Gia { get; set; }
        public XeMay(string bienso = "", int namsanxuat = 0, double gia = 0)
        {
        BienSo = bienso;
        Namsanxuat= namsanxuat;
        Gia = gia;
        }
        public void NhapTT()
        {
            Console.Write("Bien so xe:");
            BienSo = Console.ReadLine();
            Console.Write("Nam san xuat:");
            Namsanxuat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gia:");
                Gia = Convert.ToDouble(Console.ReadLine());
        }
        public void XuatTT()
        {
            Console.WriteLine("Bien so xe:{0}", BienSo);
            Console.WriteLine("Nam san xuat{0}", Namsanxuat);
            Console.WriteLine("Gia:{0}", Gia);
        }
        public virtual int ThoiHanSuDung()
        {
            return 0;
        }

    }
    public class XeXang : XeMay
    {
        public int Dungtich;

        public int dungtich
        {
            get { return Dungtich; }
            set { Dungtich = value; }
        }
        public XeXang(string bienso ="",int namsanxuat =0,double gia =0, int dungtich =0 ) : base(bienso,namsanxuat,gia)
        {
            Dungtich = dungtich;
        }
        public void Nhap()
        {
            base.NhapTT();
            Console.Write("Dung tich dong co:");
            Dungtich = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            base.XuatTT();
            Console.Write("Dung tich dong co:{0}", Dungtich);
        }
        public override int ThoiHanSuDung()
        {
            return 20 - (2023 - Namsanxuat);
        }
    }
    public class XeDien : XeMay
    {
        int DongCo { get; set; }
        public XeDien(string bienso = "", int namsanxuat = 0, double gia = 0, int dongco = 0) : base(bienso, namsanxuat, gia)
        {
            DongCo = dongco;
        }
        public void Nhap()
        {
            base.NhapTT();
            Console.Write("Cong xuat dong co:");
            DongCo = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            base.XuatTT();
            Console.Write("Cong xuat dong co:{0}", DongCo);
        }
        public override int ThoiHanSuDung()
        {
            return 10 - (2023 - Namsanxuat);
        }
    }
    public class dsXe
    {
        XeMay[] ds;
        int n;
        int loaixe;
        public void Nhapds()
        {
            Console.Write("nhap so luong xe:");
            n = Convert.ToInt32(Console.ReadLine());
            ds = new XeMay[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--NHAP THONG TIN XE THU {0}--",i+1);
                ds[i] = new XeMay();
                Console.Write("nhap loai xe:(1-xe xang, 2 - xe dien):");
                loaixe = Convert.ToInt32(Console.ReadLine());
                switch (loaixe)
                {
                    case 1:
                        {
                            int Dungtich;
                            ds[i] = new XeXang(ds[i].BienSo, ds[i].Namsanxuat, ds[i].Gia);
                            Console.Write("Dung tich xe:");
                            Dungtich = Convert.ToInt32(Console.ReadLine());
                            ds[i].NhapTT();
                        }
                        break;
                    case 2:
                        {
                            int CSdongco;
                            ds[i] = new XeXang(ds[i].BienSo, ds[i].Namsanxuat, ds[i].Gia);
                            Console.Write("Cong xuat dong co:");
                            CSdongco = Convert.ToInt32(Console.ReadLine());
                            ds[i].NhapTT();
                        }
                        break ;
                }
            }
        }
        public void Xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--THONG TIN XE THU {0}", i + 1);
                ds[i].XuatTT();
                Console.WriteLine(" Thoi han su dung cua xe:{0}", ds[i].ThoiHanSuDung());
            }
        }
        public void Demsl()
        {
            int s;
            int t;
            for (int i = 0; i < n; i++)
            {
                if (loaixe == 1)
                {
                    s = i + 1;
                    Console.WriteLine("so luong xe loai 1:{0}", s);
                }
            }
            for (int j = 0; j < n; j++)
            {
                t = j + 1;
                Console.WriteLine("so luong xe loai 2:{0}", t);
            }
        }
        public void Sapxepxe()
        {
            XeMay temp;
            for(int i = 0; i < n; i++)
                for (int j = i+1; j < n; j++)
                {
                    if (ds[i].ThoiHanSuDung() < ds[j].ThoiHanSuDung()) 
                    {
                        temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }
                }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--DANH SACH SAU KHI SAP XEP--");
                ds[i].XuatTT();
            }

        }
        public void Hansudung()
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].ThoiHanSuDung() <= 0)
                {
                    Console.WriteLine("--DANH SACH XE HET HAN SU DUNG--");
                    ds[i].XuatTT();
                }
            }
        }
    }

    public class program
    {

       public static void Main(string[] args)
        {
            dsXe ds = new dsXe();
            ds.Nhapds();
            ds.Xuatds();
           // ds.Sapxepxe();
            //ds.Hansudung();
            ds.Demsl();

        }


    }
}
