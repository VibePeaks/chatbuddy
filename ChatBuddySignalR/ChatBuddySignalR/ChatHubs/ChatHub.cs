using ChatBuddySignalR.DBRepository;
using ChatModels;
using Microsoft.AspNetCore.SignalR;

namespace ChatBuddySignalR.ChatHubs
{
    public class ChatHub(ChatBuddyRepo chatBuddyRepo) : Hub
    {
        public async Task SendMessage(Chat chat)
        {
            //await chatBuddyRepo.SaveChatAsync(chat);
            await Clients.All.SendAsync("ReceiveMessage", chat);
        }
    }
}