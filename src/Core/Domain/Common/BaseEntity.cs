using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public string Id { get; set;}

        public string Title { get; set;}

        public string Code { get; set;}

        public int Timestamp  { get; set;}

        public BaseEntity()
        {
            Id =  Guid.NewGuid().ToString("N");

            Timestamp = DateTime.Now;
        }
    }
}