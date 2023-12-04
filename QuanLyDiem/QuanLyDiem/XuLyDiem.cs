using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem
{
    class XuLyDiem
    {
        public Double DiemSo(Double diem) 
        {
            Double d;
            if (diem >= 8.5)
                d = 4;
            else if (diem >= 8)
                d = 3.5;
            else if (diem >= 7)
                d = 3;
            else if (diem >= 6.5)
                d = 2.5;
            else if (diem >= 5.5)
                d = 2;
            else if (diem >= 5)
                d = 1.5;
            else if (diem >= 4)
                d = 1;
            else
                d = 0;
            return d;
        }


        public String DiemChu(Double diem)
        {
            String d;
            if (diem >= 8.5)
                d = "A";
            else if (diem >= 8)
                d = "B+";
            else if (diem >= 7)
                d = "B";
            else if (diem >= 6.5)
                d = "C+";
            else if (diem >= 5.5)
                d = "C";
            else if (diem >= 5)
                d = "D+";
            else if (diem >= 4)
                d = "D";
            else
                d = "F";
            return d;
        }

        public String XepLoai(Double a)
        {
            String x;
            if (a >= 3.6)
                x = "Xuất sắc";
            else if (a >= 3.2)
                x = "Giỏi";
            else if (a >= 2.5)
                x = "Khá";
            else if (a >= 2)
                x = "Trung Bình";
            else
                x = "Yếu";
            return x;
        }
    }
}
