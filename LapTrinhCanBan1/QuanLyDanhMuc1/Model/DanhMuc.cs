using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhMuc1.Model
{
    class DanhMuc
    {
        public Guid Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        private static List<DanhMuc> _Danhmuc { get; set; }
        public static void ThemDanhMuc(DanhMuc dm)
        {
            if (_Danhmuc == null)
                _Danhmuc = new List<DanhMuc>();
            _Danhmuc.Add(dm);
        }
        /// <summary>
        /// Lay Danh Sach Danh Muc
        /// </summary>
        /// <returns></returns>
        public static List<DanhMuc> GetDanhMuc()
        {
            if (_Danhmuc == null)
                _Danhmuc = new List<DanhMuc>();
           return _Danhmuc;
        }
    }
}
