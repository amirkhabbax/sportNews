using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.News_Related
{
    public class Tag : BaseEntity
    {
        public string? RelatedTagId { get; set; }

        public Tag? RelatedTag { get; set; }
    }
}