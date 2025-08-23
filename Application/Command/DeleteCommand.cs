using MediatR;

namespace ThreadsHome.Application.Command
{
    public sealed record DeleteCommand(int PID) : IRequest<int>;
}
