using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài4
{
   class Vienkhoahoc
    {
        private string hoten { get; set; }
        private int namsinh { get; set; }   
        private string bangcap { get; set; }

        public Vienkhoahoc(string hoten, int namsinh, string bangcap)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.bangcap = bangcap;
        }
        public Vienkhoahoc() { }

    }
    class Nhakhoahoc : Vienkhoahoc
    {
        private string chucvu { get; set; }
        private int sobaocaodacongbo { get; set; }
        private int songaycongbotrongthang { get; set; }
        private string bacluong { get; set; }

        public Nhakhoahoc(string hoten, int namsinh, string bangcap, string chucvu, int sobaocaodacongbo, int songaycongbotrongthang, string bacluong)
        {
            this.chucvu = chucvu;
            this.sobaocaodacongbo = sobaocaodacongbo;
            this.songaycongbotrongthang = songaycongbotrongthang;
            this.bacluong = bacluong;
            
        }
        public Nhakhoahoc() { }
    }
    class Nhaquanly : Vienkhoahoc
    {
        private Nhakhoahoc songaydacongbotrongthang { get; set; }
        private Nhakhoahoc bacluong { get; set; }
        public Nhaquanly(string hoten, int namsinh, string bangcap,Nhakhoahoc songaydacongbotrongthang, Nhakhoahoc bacluong)
        {
            this.songaydacongbotrongthang = songaydacongbotrongthang;
            this.bacluong = bacluong;
        }
        class NhanVienPhongThiNghiem : Vienkhoahoc
        {
            private float luongtronthang { get; set; }
            public NhanVienPhongThiNghiem() { }
            public NhanVienPhongThiNghiem(string hoten, int namsinh, string bangcap, float luongtronthang)
            {
                this.luongtronthang = luongtronthang;
            }
        }

        public Nhaquanly() { }

    }
       
    
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
