using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Enums;

namespace WebAPIBank.Models.Entities
{
    public abstract class BaseEntitiy
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public BaseEntitiy()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }
    }
}