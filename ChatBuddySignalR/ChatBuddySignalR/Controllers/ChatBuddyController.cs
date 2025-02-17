using ChatBuddySignalR.DBRepository;
using ChatModels;
using Microsoft.AspNetCore.Mvc;

namespace ChatBuddySignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatBuddyController(ChatBuddyRepo chatBuddyRepo) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Chat>>> Index() =>
            Ok(await chatBuddyRepo.GetChatsAsync());

    }
}
