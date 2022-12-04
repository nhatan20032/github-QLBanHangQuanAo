using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    public class ChatLieu_SP
    {
        public Guid IDCTSP { get; set; }    
        public Guid IDCL { get; set; }    
        public string ChatLieuVai { get; set; }    
        public int TrangThai { get; set; }  
        public ChiTietSP chiTietSP { get; set; }
        public ChatLieu ChatLieu { get; set; }
    }
}
