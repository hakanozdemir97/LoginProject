﻿using LoginProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoginProject.Entities.Concrete
{

    public class User : IEntity
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
