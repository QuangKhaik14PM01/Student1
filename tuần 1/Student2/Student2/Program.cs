using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2
{
    class Student02
    {
        private int id { get; set; }
        private string name { get; set; }

        private string khoa { get; set; }
        private float diemtb { get; set; }

        public Student02(int id, string name, string khoa, float diemtb)
        {
            this.id = id;
            this.name = name;
            this.khoa = khoa;
            this.diemtb = diemtb;
        }

        public Student02()
        {
            id = 1;
            name = " Trần Quang Khải";
            khoa = "công nghệ thông tin";
            diemtb = 7;

        }
        public Student02(Student02 STD2)
        {
            this.id = STD2.id;
            this.name = STD2.name;
            this.khoa = STD2.khoa;
            this.diemtb = STD2.diemtb;
        }
        public Student02[] DSSV;
        public void Show()
        {
            Console.WriteLine("MSSV {0}",this.id);
            Console.WriteLine("TenSV {0}", this.name);
            Console.WriteLine("Khoa {0}", this.khoa);
            Console.WriteLine("DiemTB {0}", this.diemtb);
        }
        
        public void Nhap1SV()
        {
            int n;
            Console.WriteLine("Nhập số lượng sinh viên ");
            n=int.Parse(Console.ReadLine());
            DSSV = new Student02[n];
        }

        public void NhapDSSV()
        {
            for (int i = 0; i < DSSV.Length; i++)
            {
                DSSV[i] = new Student02();
                Console.WriteLine("Nhap mã SV {0}", i + 1);
                DSSV[i].id=int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tên sinh viên ");
                DSSV[i].name=Console.ReadLine();
                Console.WriteLine("nhập khóa ");
                DSSV[i].khoa=Console.ReadLine();
                Console.WriteLine("Nhập điểm trung bình ");
                DSSV[i].diemtb=float.Parse(Console.ReadLine());
            }
        }
        public void XuatDSSV()
        {
            foreach (Student02 student in DSSV)
                student.Show();
                    Console.ReadLine();
        }
    }
     class Tester
    {
        static void Main(string[] args)
        {
            Student02 st = new Student02();
            st.Nhap1SV();
            st.NhapDSSV();  
            st.XuatDSSV();

        }
    }
}
