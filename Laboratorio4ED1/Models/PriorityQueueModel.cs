﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4ED1.Models
{
    public class PriorityQueueModel:IComparable
    {
        public int priority { get; set; }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}