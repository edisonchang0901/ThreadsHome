using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThreadsHome.Domain.Enums;

namespace ThreadsHome.API.Port.In.DTOs
{
    public record EditPostDto
    {
        /// <summary>
        /// 貼文內容
        /// </summary>
        [Required]
        [JsonRequired] 
        public string Content { get; init; } = string.Empty;
    }
}
