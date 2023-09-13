using System.Net.Http.Json;
using Models;


namespace Repositories;

public class Repository : IRepository
{

    private readonly HttpClient Http;
    public Repository(HttpClient Http)
    {
        this.Http = Http;
    }
    public List<Assignment> GetTasks()
    {
        return new List<Assignment>(){
            new Assignment(){
                ID =  new Guid("f0dcda47-1f23-4538-92e0-a47dcdcc7850"),
                Description =  "Take Blazor course",
                Done = false,
                CreationDate = Convert.ToDateTime("2023-09-11")
            },
            new Assignment(){
                ID =  new Guid("d21b0f7e-a5a9-45ee-ad9b-eafd911e22fa"),
                Description =  "Study Blazor",
                Done = false,
                CreationDate = Convert.ToDateTime("2023-09-05")
            },

        };
    }

    public Task<List<Assignment>?> GetTasksFromJson()
    {
        return Http.GetFromJsonAsync<List<Assignment>>("data/tasks.json");
    }
}