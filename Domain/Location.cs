﻿using System;
namespace Domain
{
    public class Location : Entity
    {
        public string PlaceId { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
