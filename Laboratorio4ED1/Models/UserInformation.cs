﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomGenerics.Structures;

namespace Laboratorio4ED1.Models
{
    public class UserInformation
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PriorityQueue<PriorityQueueModel> Tasks = new PriorityQueue<PriorityQueueModel>();

    }
}