using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ThreadsHome.API.Controllers.Base;
using ThreadsHome.API.Port.In.DTOs;
using ThreadsHome.Application.Command;

namespace ThreadsHome.API.Controllers
{
    [Route("api/[controller]")]
    public class PostsController(IMapper mapper, ISender sender, IHttpContextAccessor httpContextAccessor) : AuthenticationControllerBase(sender, httpContextAccessor)
    {
        private readonly IMapper _mapper = mapper;

        // GET /posts/{pid}
        [HttpGet("{pid}")]
        public IActionResult GetPost(string pid)
        {
            // TODO: 取得貼文內容
            // var post = _postService.GetPostById(pid);
            return Ok();
        }

        // POST /posts
        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostDto dto)
        {
            CreateCommand command = _mapper.Map<CreateCommand>(dto);
            int id = await sender.Send(command);
            return Ok();
        }

        // PUT /posts/{pid}
        [HttpPut("{pid}")]
        public IActionResult UpdatePost(string pid, [FromBody] EditPostDto dto)
        {
            // TODO: 更新貼文內容
            // var result = _postService.UpdatePost(pid, dto);
            return NoContent();
        }


        // POST /posts/{pid}/archive
        [HttpPost("{pid}/archive")]
        public IActionResult ArchivePost(string pid)
        {
            // TODO: 封存貼文
            // var result = _postService.ArchivePost(pid);
            return NoContent(); // 範例
        }

        // POST /posts/{pid}/restore
        [HttpPost("{pid}/restore")]
        public IActionResult RestorePost(string pid)
        {
            // TODO: 從封存還原
            // var result = _postService.RestorePost(pid);
            return NoContent(); // 範例
        }

        // DELETE /posts/{pid}
        [HttpDelete("{pid}")]
        public IActionResult DeletePost(string pid)
        {
            // TODO: 刪除貼文
            // var result = _postService.DeletePost(pid);
            return NoContent(); // 範例
        }
    }
}
