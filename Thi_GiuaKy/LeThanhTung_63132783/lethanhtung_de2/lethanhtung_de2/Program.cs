using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lethanhtung_de2
{
    public class Xe
    {
        private string BienSo;

        public string bienso
        {
            get { return BienSo; }
            set { while (BienSo.Length <= 9)
                {
                    BienSo = value;
                }
            }

        }

        private string HangSanXuat;
        public string hangsanxuat
        {
            get { return HangSanXuat; }
            set { HangSanXuat = value; }
        }

        private int NamSanXuat;
        public int namsanxuat
        {
            get { return NamSanXuat; }
            set
            {
                if(1980<NamSanXuat && NamSanXuat<=2023)
                {
                    NamSanXuat = value;
                }
            }
        }

        static private int SoNamLuuHanh = 20;
//HAM THIET LAP
        public Xe(string bienso="", string hangsanxuat="",int namsanxuat=2023,int namluuhanh=0)
        {
            BienSo = bienso;
            HangSanXuat = hangsanxuat;
            NamSanXuat = namsanxuat;
            SoNamLuuHanh = namluuhanh;
        }
//HAM NHAP THONG TIN XE
    public void NhapThongTin()
        {
            Console.Write("Nhap Bien So Xe:");
            BienSo = Console.ReadLine();
            Console.Write("Nhap Hang Xe:");
            HangSanXuat = Console.ReadLine();
            Console.Write("Nhap Nam San Xuat:");
            NamSanXuat = Convert.ToInt32(Console.ReadLine());
            Console.Write("So Nam Luu Hanh:");
            SoNamLuuHanh = Convert.ToInt32(Console.ReadLine());
        }
    public void XuatThongTin()
        {
            Console.Write("Bien So Xe:{0}", BienSo);
            Console.Write("\nHang San Xuat:{0}", HangSanXuat);
            Console.Write("\nNam San Xuat:{0}", NamSanXuat);
            Console.Write("\nSo Nam Luu Hanh :{0}", SoNamLuuHanh);
        }
    public int NAMLUUHANH()
        {
            int n = 2023 - namsanxuat;
            return n;

        }

    }

    public class DSXE
    {
        public int soluong { get; set; }
        Xe[] dsxe;
     public void NhapdsXE()
        {
            Console.Write("so luong xe:");
            soluong = Convert.ToInt32(Console.ReadLine());
            dsxe = new Xe[100];
            for(int i=0;i<soluong;i++)
            {
                dsxe[i] = new Xe();
                Console.Write("\nNhap Thong Tin Xe thu {0}\n", i + 1);
                dsxe[i].NhapThongTin();
            }
        }
        public void XuatdsXE()
        {
            for(int i=0;i<soluong;i++)
            {
                Console.Write("\nTHONG TIN XE THU {0}\n", i + 1);
                dsxe[i].XuatThongTin();


            }


        }

        public void Luuhanhlaunhat()
        {
            int LuuHanhMax = dsxe[0].NAMLUUHANH();
            Xe XeLuuHanhMax = dsxe[0];
            for(int i=0;i<soluong;i++)
            {
                if (dsxe[i].NAMLUUHANH() > LuuHanhMax)
                {
                    LuuHanhMax = dsxe[i].NAMLUUHANH();
                    XeLuuHanhMax = dsxe[i];

                }



            }
            Console.Write("\nXe Co Thoi Gian Luu Hanh Dai Nhat\n");
            XeLuuHanhMax.XuatThongTin();
        }


    }



        


    class Program
    {
        static void Main()
        {
            DSXE DsXe = new DSXE();
            DsXe.NhapdsXE();
            DsXe.XuatdsXE();
            DsXe.Luuhanhlaunhat();



        }
    }
}
