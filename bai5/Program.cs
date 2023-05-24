using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập ngày sinh: ");
        int ngaySinhInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập tháng sinh: ");
        int thangSinhInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập năm sinh: ");
        int namSinhInput = int.Parse(Console.ReadLine());
        
        DateTime ngayHienTai = DateTime.Now;
            
        DateTime ngaySinhNhat = new DateTime(ngayHienTai.Year, thangSinhInput, ngaySinhInput);
        if (ngaySinhNhat < ngayHienTai)
        {
            ngaySinhNhat = ngaySinhNhat.AddYears(1);
        }
            
        int soNgayDenSinhNhat = (ngaySinhNhat - ngayHienTai).Days;
            
        Console.WriteLine("Số ngày sinh nhật tiếp theo: " + soNgayDenSinhNhat);
    }
}
