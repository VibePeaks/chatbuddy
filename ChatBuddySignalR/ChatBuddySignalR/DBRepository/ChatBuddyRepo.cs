using ChatModels;
using Microsoft.EntityFrameworkCore;

namespace ChatBuddySignalR.DBRepository
{
    public class ChatBuddyRepo(AppDBContext appDBContext)
    {
        public async Task SaveChatAsync(Chat chat)
        {
            appDBContext.Add(chat);
            await appDBContext.SaveChangesAsync();
        }

        public async Task<List<Chat>> GetChatsAsync() =>
            await appDBContext.Chats.ToListAsync();
    }
}
