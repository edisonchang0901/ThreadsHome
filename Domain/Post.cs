using ThreadsHome.Domain.Common;
using ThreadsHome.Domain.Enums;

namespace ThreadsHome.Domain
{
    public sealed class Post
    {
        /// <summary>
        /// Aggregate Root ID
        /// </summary>
        public string Pid { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the process identifier (PID) of the parent process, if available.
        /// </summary>
        public string? ParentPid { get; private set; } = string.Empty;

        /// <summary>
        /// Creator's Member ID
        /// </summary>
        public string Mid { get; private set; } = string.Empty;

        /// <summary>
        /// Post Content
        /// </summary>
        public string Content { get; private set; } = string.Empty;
      
        /// <summary>
        /// Created Time
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Updated Time
        /// </summary>
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Status
        /// </summary>
        public PostStatus Status { get; private set; }

        private void SetLastUpdated() => UpdatedAt = TimeUtil.TaipeiStandardTimeNow();
    }
}
