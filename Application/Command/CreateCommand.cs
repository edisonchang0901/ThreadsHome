using MediatR;

namespace ThreadsHome.Application.Command;

    public sealed class CreateCommand : IRequest<int>
    {
        public string? ParentPID { get; init; } = null;
        public string Content { get; init; } = string.Empty;
    }

    public sealed class CreateCommandHandler : IRequestHandler<CreateCommand, int>
    {
        public Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
        }
    }

