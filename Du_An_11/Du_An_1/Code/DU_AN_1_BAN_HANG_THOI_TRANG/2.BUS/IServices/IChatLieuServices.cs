using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChatLieuServices
    {
        bool Add(ChatLieu chatLieu);
        bool Update(ChatLieu chatLieu);
        bool Delete(ChatLieu chatLieu);
        List<ChatLieu> getChatLieuFromDB();
    }
}
