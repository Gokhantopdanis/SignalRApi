using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialServivce;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialServivce, IMapper mapper)
        {
            _testimonialServivce = testimonialServivce;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialServivce.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialServivce.Tadd(new Testimonial()
            {
                Name = createTestimonialDto.Name,
                ImageUrl = createTestimonialDto.ImageUrl,
                Title = createTestimonialDto.Title,
                Comment = createTestimonialDto.Comment,
                Status = createTestimonialDto.Status
            });
            return Ok("Testimonial  Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialServivce.TGetById(id);
            _testimonialServivce.TDelete(value);
            return Ok("Testimonial Medya Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialServivce.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialServivce.Tupdate(new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                Name = updateTestimonialDto.Name,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Title = updateTestimonialDto.Title,
                Comment = updateTestimonialDto.Comment,
                Status = updateTestimonialDto.Status
            });
            return Ok("Testimonial Medya Güncellendi");
        }
    }
}
