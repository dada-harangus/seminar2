﻿using Seminar2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar2.ViewModel
{
    public class GetCommentsDto


    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool Important { get; set; }

        public int MovieId { get; set; }


    }
}
