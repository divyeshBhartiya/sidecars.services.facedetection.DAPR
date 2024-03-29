﻿using System;

namespace FaceDetectionApp.Events
{
    public class OrderReceivedEvent
    {
        public OrderReceivedEvent(Guid orderId, string photoUrl, string userEmail, byte[] imageData)
        {
            OrderId = orderId;
            PhotoUrl = photoUrl;
            UserEmail = userEmail;
            ImageData = imageData;
        }
        public Guid OrderId { get; set; }
        public string PhotoUrl { get; set; }
        public string UserEmail { get; set; }
        public byte[] ImageData { get; set; }
    }
}
