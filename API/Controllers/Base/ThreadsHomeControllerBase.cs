using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ThreadsHome.API.Controllers.Base
{
    [ApiController]
    public abstract class ThreadsHomeControllerBase(ISender sender) : ControllerBase
    {
        protected readonly ISender _sender = sender;
    }
}
