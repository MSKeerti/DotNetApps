using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class ToOne
    {
        public int Id { get; set; }
        public string RelatedToOne { get; set; } = null!;
    }
}
