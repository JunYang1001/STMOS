using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STMOS.Models
{
    public class BaseModel
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
