using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Student01
    {
        private int SID;
        private string tenSv;
        private string khoa;
        private float diemTB;

        public Student01()
        {
            SID = 1;
            tenSv = "Trần Quang Khải";
            khoa = "Kĩ thuật phần mềm";
            diemTB = 7;
        }
        public Student01(Student01 std01)
        {
            SID = std01.SID;
            tenSv = std01.tenSv;
            khoa=std01.khoa;
            diemTB = std01.diemTB;
        }
        public Student01(int sID, string tenSv, string khoa, float diemTB)
        {
            SID = sID;
            this.tenSv = tenSv;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }
        public int StuSID
        {
            get { return SID; }
            set { SID = value; }
        }
        public string TenSv { get { return tenSv; } set { tenSv = value; } }
        public string Khoa { get { return khoa; } set { khoa = value; } }
        public float DiemTB { get { return diemTB; } set { diemTB = value; } }
        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("TenSV: {0}", this.tenSv);
            Console.WriteLine("Khoa: {0}", this.khoa);
            Console.WriteLine("diemTB: {0}", this.diemTB);

        }
    }
     class Tester
    {
 
        static void Main(string[] args)

        
        {
            Student01[] DSSV;
            int n;
            Console.WriteLine("Nhập số lượng sinh viên ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student01[n];
            Console.WriteLine("\n === NHAP DS SINH VIEN ===");
            for(int i = 0; i < n; i++)
            {
                DSSV[i]=new Student01();
                Console.WriteLine("Nhập mã SV {0}", i + 1);
                DSSV[i].StuSID=int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tên SV " );
                DSSV[i].TenSv=Console.ReadLine();
                Console.WriteLine("Nhập khóa ");
                DSSV[i].Khoa=Console.ReadLine();
                Console.WriteLine("Nhập diem TB ");
                DSSV[i].DiemTB= float.Parse(Console.ReadLine());

            }
            Console.WriteLine("\n=== Xuat DS Sinh vien ===");
            foreach(Student01 s in DSSV)
                s.Show();
            Console.ReadLine();
        }

    }
}
