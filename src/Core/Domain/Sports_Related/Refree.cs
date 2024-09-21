using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Refree : HumanBeing
    {
        
        public string? HistoryId { get; set; }
        public History? History { get; set; }

        public string? HonorsList   { get; set; }

        public ERefreeType RefreeType   { get; set; } = ERefreeType.None;
        
        public Refree()
        {
            super();
        }
    }
}