using System;
using System.Threading.Tasks;
using Detector.Core.DatabaseModel;
using Detector.Infrastructure.Commands;
using Detector.Infrastructure.Database;
using Detector.Infrastructure.Services;
using Detector.Infrastructure.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Detector.Api.Controllers
{
    [ApiController]
    public class ImagesController : ApiControllerBase
    {
        private readonly IImageService _imageService;
        private readonly IImageMLService _test;
        private readonly DataContext context;

        public ImagesController(IImageService imageService, ICommandDispatcher commandDispatcher, IImageMLService test,
        DataContext context) : base(commandDispatcher)
        {
            _imageService = imageService;
            _test = test;
            this.context = context;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Post([FromForm(Name = "File")] AddImage command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return Ok();
        }

        [HttpPost("test")]
        public async Task<IActionResult> Post()
        {
            //var context = new DataContext();
            var x = new ImageDb
            {
                Id = Guid.NewGuid(),
                ImageBytes = new byte[]{10,20,30},
                FileName = "test",
                Url = "test",
                PublicId = "test",
                //Stats = new StatisticsDb()
            };

            await context.Image.AddAsync(x);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {  
            //var image = await _imageService.GetImage(guid);
            return Ok();
        }
    }
}