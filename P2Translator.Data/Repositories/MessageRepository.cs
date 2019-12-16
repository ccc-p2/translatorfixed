using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2Translator.Data.Models;

namespace P2Translator.Data.Repositories
{
    public class MessageRepository
    {
    private readonly P2TranslatorDbContext _db;
    public MessageRepository(P2TranslatorDbContext _db)
    {
        this._db = _db;
    }
    public List<Message> GetAllMessages()
    {
      return _db.Message.ToList();
    }
    // public async Task<List<Message>> GetAllMessages(string language)
    // {
    //   List<Message> messages = _db.Message.ToList();
    //   List<Message> translatedMessageList = new List<Message>();
    //   TR tr = new TR();
    //   foreach(Message m in messages)
    //   {
    //     Message translatedMessage = new Message();
    //     translatedMessage.Content = await tr.Translate(m.Content, language);
    //     translatedMessage.MessageDateTime = m.MessageDateTime;
    //     translatedMessageList.Add(translatedMessage);
    //   }
    //   return translatedMessageList;
    // }
    public void Create(Message m)
    {
      _db.Message.Add(m);
      _db.SaveChanges();
    }
    }
}