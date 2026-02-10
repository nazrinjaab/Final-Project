using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaroTime.Domain.Entities.common;

namespace TaroTime.Domain.Entities
{
    public class Slide:BaseAccountableEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; } 
    }
}
