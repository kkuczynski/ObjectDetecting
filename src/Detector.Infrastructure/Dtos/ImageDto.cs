using System;
using System.Collections.Generic;

namespace Detector.Infrastructure.Dtos
{
    public class ImageDto
    {
        public Guid Id { get;  set; }
        public byte[] ImageProcessed { get;  set; }
        public List<string> Description { get; set; }
        public long ElapsedTime { get; set; }
    }
}