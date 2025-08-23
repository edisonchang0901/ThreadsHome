namespace ThreadsHome.API.Port.In.DTOs
{
    public sealed record CreatePostDto : EditPostDto
    {
        /// <summary>
        /// 父貼文編號
        /// </summary>
        public string? ParentPID { get; init; }
    }
}
