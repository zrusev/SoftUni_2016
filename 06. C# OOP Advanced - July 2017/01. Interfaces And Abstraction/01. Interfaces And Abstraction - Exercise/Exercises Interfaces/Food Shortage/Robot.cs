﻿using Food_Shortage.Interfaces;

namespace Food_Shortage
{
    public class Robot : IIdentify, IRobort
    {
        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}