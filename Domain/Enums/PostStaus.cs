using System.ComponentModel;

namespace ThreadsHome.Domain.Enums
{
    public enum PostStatus
    {
        [Description("啟用")]
        Active,
        [Description("刪除")]
        Deleted,
        [Description("封存")]
        Archived 
    }
}
