using System.ComponentModel;

namespace ThreadsHome.Domain.Enums;

public enum PostTrigger
{
    [Description("編輯貼文")]
    Edit,

    [Description("刪除貼文")]
    Delete,

    [Description("封存貼文")]
    Archive,

    [Description("還原貼文")]
    Restore
}

