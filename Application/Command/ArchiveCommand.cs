using MediatR;

namespace ThreadsHome.Application.Command
{
    public sealed record ArchiveCommand(int PID) : IRequest<int>;

    public sealed class ArchiveCommandHandler: IRequestHandler<ArchiveCommand, int>
    {
        public Task<int> Handle(ArchiveCommand request, CancellationToken cancellationToken)
        {
            // Implementation for archiving a thread with the given PID
            // This is a placeholder implementation and should be replaced with actual logic
            return Task.FromResult(request.PID);
        }
    }
}
