using ThreadsHome.Application.Command;

namespace ThreadsHome.Application.Port.In.Service
{
    public interface IPostService
    {
        internal Task<int> CreateAsync(CreateCommand command);
    }
}
