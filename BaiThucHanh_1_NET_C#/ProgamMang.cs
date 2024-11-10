using System;
namespace Progam
{
        class ProgamMang 
    {
static bool SapXep(int[] n, int x)
{
    for (int i = 1; i < x; i++)
    {
        if(n[i]<n[i+1])
        {
            return true;
        }
    }
    return false;

}

static void Main()
    {
        int x;
        int[] n;
        //a) Nhập một mảng n số nguyên từ bàn phím.
        Console.Write("nhap so luong phan tu:");
        x= int.Parse(Console.ReadLine());
        n=new int[100];
        for (int i = 1; i <= x; i++)
        {
            Console.Write("n[{0}]",i);
            n[i]= int.Parse(Console.ReadLine());
        }
        //b) In các phần tử của mảng lên màn hình.
        Console.Write("Mang vua nhap la:");
        for(int i=1;i<=x;i++)
        {
            Console.Write("{0} ",n[i]);
        }
        //c) Trả về phần tử lớn nhất của mảng.
        int max= n[1];
        for (int i = 1; i <= x ;i++)
        {
            if(n[i]>max)
            {
              max=n[i];
              

            }
        }
        Console.Write("phan tu lon nhat trong mang la:{0}",max);
        //d)Trả về kiểu boolean kiểm tra mảng đã được sắp xếp tăng dần chưa.
        for (int i = 1; i <= x; i++)
        {
            if(SapXep(n,x) == true)
            {
                Console.Write("\nmang vua nhap la mang tang dan");
            }
            else{
                Console.Write("\nMang ko tang dan");
            }
        }
        //e) Sắp xếp mảng theo thứ tự tăng dần.
        int tam;
        for (int i = 1; i < x; i++)
        {
            for (int j = i+1; j < x; j++)
            {
                
            
         if(n[i]>n[j])
         {
            tam=n[i];
            n[i]=n[j];
            n[j]=tam;
         }  
         }       
        }
        Console.Write("\nMang vua sap xep la:");
        for (int i = 1; i <= x; i++)
        {
            Console.Write("{0} ",n[i]);
        }
    }
}
}