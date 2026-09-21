using ApiProjeKampi.Dtos.MessageDtos;
using ApiProjeKampi.Entities;
using ApiProjeKampi.WebApi.Context;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public MessagesController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var value = _context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDtos>>(value));
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDtos createMessageDto)
        {
            var value = _mapper.Map<Message>(createMessageDto);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("Mesaj Ekleme İşlemi Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Mesaj Silme İşlemi Başarılı");
        }

        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDtos>(value));
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDtos updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("Mesaj Güncelleme İşlemi Başarılı");
        }

        [HttpGet("MessageListByIsReadFalse")]
        public IActionResult MessageListByIsReadFalse()
        {
            var value = _context.Messages.Where(x => x.IsRead == false).ToList();
            return Ok(value);
        }
    }
}