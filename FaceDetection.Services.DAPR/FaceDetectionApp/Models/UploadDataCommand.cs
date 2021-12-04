﻿using Microsoft.AspNetCore.Http;
using System;

namespace FaceDetectionApp.Models
{
    public class UploadDataCommand
    {
        public Guid OrderId { get; set; }
        public string UserEmail { get; set; }
        public string PhotoUrl { get; set; }
        public IFormFile File { get; set; }
    }
}
