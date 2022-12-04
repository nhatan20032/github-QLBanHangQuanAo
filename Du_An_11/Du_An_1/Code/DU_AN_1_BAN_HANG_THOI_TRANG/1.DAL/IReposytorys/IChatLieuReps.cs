using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IChatLieuReps
    {
        bool Add(ChatLieu chatLieu);
        bool Update(ChatLieu chatLieu);
        bool Delete(ChatLieu chatLieu);
        List<ChatLieu> getChatLieuFromDB();
    }
}
