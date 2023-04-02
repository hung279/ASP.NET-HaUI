using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class ChucVu
    {
        public String id { get; set; }
        public String name { get; set; }

        public ChucVu()
        {

        }

        public ChucVu(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}