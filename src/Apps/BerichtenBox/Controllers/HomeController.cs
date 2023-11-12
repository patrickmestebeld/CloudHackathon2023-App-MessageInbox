using System.Diagnostics;
using BerichtenBox.Infra.Models;
using BerichtenBox.Infra.Services;
using BerichtenBox.Models;
using Microsoft.AspNetCore.Mvc;

namespace BerichtenBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageStore _messageStore;

        public HomeController(ILogger<HomeController> logger, IMessageStore messageStore)
        {
            _messageStore = messageStore;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new MessageListViewModel();
            model.Messages = GetMessages();
            
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IEnumerable<MessageViewModel> GetMessages()
        {
            return _messageStore.Messages.OrderBy(m => m.TimeStamp).Select(Convert);
        }

        private MessageViewModel Convert(StoredMessage message)
        {
            return new MessageViewModel
            {
                MessageType = message.MessageType,
                Subject = message.SubjectId,
                Url = message.Url
            };
        }
    }
}