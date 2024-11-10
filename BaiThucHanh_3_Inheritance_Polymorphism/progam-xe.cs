using System;
namespace progameXE
{
    public class Xe
    {
        public string BienSo { get; set; }
        public int Nam_sx { get; set; }
        public int Gia { get; set; }
        //ham thiet lap khong co tham co tham so
        public Xe()
        {
            string a = "";
            int nam = 0, GIA = 0;
            BienSo = a;
            Nam_sx = nam;
            Gia = GIA;

        }
    }

    public class XE_CON : Xe
    {
        private int Cho_Ngoi { get; set; }
        private string Loai_Xe { get; set; }
        //ham thiet lap co tham so
        public XE_CON(int chongoi = 0, string d = "")
        {
            Cho_Ngoi = chongoi;
            Loai_Xe = d;
        }

        public void NhapXE()
        {
            Console.Write("Bien so xe:");
            BienSo = Console.ReadLine();

            Console.Write("Nam san xuat:");
            Nam_sx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gia(trieu dong):");
            Gia = Convert.ToInt32(Console.ReadLine());

            Console.Write("So cho ngoi:");
            Cho_Ngoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ten xe:");
            Loai_Xe = Console.ReadLine();
        }
        public void XUATXE()
        {
            Console.Write("TEN XE:{0}\n", Loai_Xe);
            Console.Write("GIA:{0}\n", Gia);
            Console.Write("NAM SAN XUAT:{0}\n", Nam_sx);
            Console.Write("SO CHO NGOI:{0}\n", Cho_Ngoi);
            Console.Write("BIEN SO XE:{0}\n", BienSo);
        }


    }
    public class DSXE
    {
        public int n { get; set; }
        XE_CON[] dsXE;

        public void NHapdsXE()
        {
            Console.Write("Nhap so luong danh sach:");
            n = Convert.ToInt32(Console.ReadLine());
            dsXE = new XE_CON[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("NHAP THONG TIN XE THU {0}\n", i+1);
                dsXE[i] = new XE_CON();
                dsXE[i].NhapXE();
            }
        }
        public void XuatdsXE()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("<<THONG TIN XE THU {0} >>\n", i+1);
                dsXE[i].XUATXE();
            }
        }
// HÀM TÌM VÀ IN RA GIÁ XE CAO NHẤT
        public void GiaXe_CaoNhat()
        {
            int GiaMax = dsXE[0].Gia;
            XE_CON XeMAX= dsXE[0];
            for (int i = 0; i < n; i++)
            {
                if(GiaMax < dsXE[i].Gia)
                {
                    XeMAX = dsXE[i];
                }
            }
            Console.Write("Xe co gia cao nhat la:\n");
            XeMAX.XUATXE();
        }
//HÀM TÌM VÀ IN RA GIÁ XE THẤP NHẤT
    public void GiaXe_ThapNhat()
    {
        int GiaMin = dsXE[0].Gia;
        XE_CON XeMin = dsXE[0];
        for (int i = 0; i < n; i++)
        {
            if (dsXE[i].Gia < GiaMin)
            {
                GiaMin = dsXE[i].Gia;
                XeMin = dsXE[i];
            }
        }
        Console.Write("Xe có gia thap nhat la:\n");
        XeMin.XUATXE();
    }


// HÀM KIỂM TRA VÀ IN RA BIỂN SỐ XE
        public void Inxetheobienso()
        {
            string ktra;
            Console.Write("Nhap bien so can kiem tra:");
            ktra=Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (ktra[0] == dsXE[i].BienSo[0] && ktra[1] == dsXE[i].BienSo[1])
                {
                    dsXE[i].XUATXE();
                }
            }

        }
//  HÀM SẮP XẾP XE TĂNG DẦN THEO NĂM SẢN XUẤT
        public void SapXepXE()
        {
            XE_CON temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(dsXE[i].Gia>dsXE[j].Gia)
                    {
                        temp = dsXE[i];
                        dsXE[i]= dsXE[j];
                        dsXE[j]= temp;
                    }
                }
            }
            Console.WriteLine("\nDanh sach sau khi sap xep la:\n");
            for (int i = 0; i < n; i++)
            {
                dsXE[i].XUATXE();
                Console.Write("\n");
            }
        }


        
    }



    class program
    {
        public static void Main()
        {
            DSXE dsxe = new DSXE();
            dsxe.NHapdsXE();
            dsxe.XuatdsXE();
            dsxe.GiaXe_CaoNhat();
            dsxe.Inxetheobienso();
            dsxe.SapXepXE();

        }
    }


}

