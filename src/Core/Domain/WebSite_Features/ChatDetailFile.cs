using Domain.Common;
using Domain.WebSite_Features;
using SportNews.src.Core.Domain.Enumerations;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class ChatDetailFile : BaseEntity
    {
        public string? ChatDetailId { get; set; }
        public ChatDetail? ChatDetail { get; set; }
        public string? FileLink { get; set; }
        public string? FilePath { get; set; }
        public string? AlternateText { get; set; }

        public EFileType FileType { get; set; } = EFileType.None;

        public ChatDetailFile():base()
        {
        }
    }
}
