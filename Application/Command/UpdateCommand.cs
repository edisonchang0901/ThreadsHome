using MediatR;

namespace ThreadsHome.Application.Command
{
    public sealed class UpdateCommand : IRequest<int>
    {
        public string Content { get; init; } = string.Empty;
    }
}
