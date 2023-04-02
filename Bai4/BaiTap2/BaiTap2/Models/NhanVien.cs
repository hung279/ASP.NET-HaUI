using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class NhanVien
    {
        public String id { get; set; }
        public int bacLuong { get; set; }
        public int ngayCong { get; set; }

        public String chucVu { get; set; }
        public Boolean gioiTinh { get; set; }
        public String ngoaiNgu { get; set; }
        public int tienLinh { get
            {
                int nlnc, pc = 0;

                if (ngayCong < 25)
                {
                    nlnc = ngayCong;
                } else
                {
                    nlnc = (ngayCong - 25) * 2 + 25;
                }

                if(chucVu == "truong-phong")
                {
                    pc = 500000;
                } else if(chucVu == "pho-phong")
                {
                    pc = 300000;
                }

                return bacLuong * 650000 * nlnc + pc;
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string id, int bacLuong, int ngayCong, string chucVu, bool gioiTinh, string ngoaiNgu)
        {
            this.id = id;
            this.bacLuong = bacLuong;
            this.ngayCong = ngayCong;
            this.chucVu = chucVu;
            this.gioiTinh = gioiTinh;
            this.ngoaiNgu = ngoaiNgu;
        }
    }
}