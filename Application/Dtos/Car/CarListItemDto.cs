﻿using Core.Enums;

namespace Application.Dtos.Car
{
    public class CarListItemDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HeadlightsOn { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}