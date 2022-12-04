using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChatLieuServices : IChatLieuServices
    {
        private IChatLieuReps _IChatLieuReps;
        private List<ChatLieu> _lstChatLieu;
        public ChatLieuServices()
        {
            _IChatLieuReps = new ChatLieuReps();
            _lstChatLieu = new List<ChatLieu>();

        }

        public bool Add(ChatLieu chatLieu)
        {
            _IChatLieuReps.Add(chatLieu);
            return true;
        }

        public bool Delete(ChatLieu chatLieu)
        {
            _IChatLieuReps.Delete(chatLieu);
            return true;

        }

        public List<ChatLieu> getChatLieuFromDB()
        {
            _lstChatLieu = _IChatLieuReps.getChatLieuFromDB();
            return _lstChatLieu;
        }

        public bool Update(ChatLieu chatLieu)
        {
            _IChatLieuReps.Update(chatLieu);
            return true;
        }
    }
}
