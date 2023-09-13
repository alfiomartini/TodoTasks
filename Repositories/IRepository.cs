using Models;

namespace Repositories;

interface IRepository
{
    public List<Assignment> GetTasks();
    public Task<List<Assignment>?> GetTasksFromJson();
}