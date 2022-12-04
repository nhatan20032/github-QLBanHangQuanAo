using _1.DAL.ConText;
using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Reposytorys
{
    public class ChatLieuReps : IChatLieuReps
    {
        private DUAN1DBContext _dbContext;
        private List<ChatLieu> _lstChatLieu;
        public ChatLieuReps()
        {
            _dbContext = new DUAN1DBContext();
            _lstChatLieu = new List<ChatLieu>();
        }

        public bool Add(ChatLieu chatLieu)
        {
            _dbContext.ChatLieus.Add(chatLieu);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChatLieu chatLieu)
        {
            _dbContext.ChatLieus.Remove(chatLieu);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChatLieu> getChatLieuFromDB()
        {
            //return _dbContext.ChatLieus.ToList();
            _lstChatLieu = _dbContext.ChatLieus.ToList();
            return _lstChatLieu;
        }

        public bool Update(ChatLieu chatLieu)
        {
            _dbContext.ChatLieus.Update(chatLieu);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
