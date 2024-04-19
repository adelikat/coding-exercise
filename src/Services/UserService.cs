namespace CodingExercise.Services;

public class UserService
{
    public async Task<UsersResult> GetUsersAsync()
    {
        var httpClient = new HttpClient();
        
        var json = await httpClient.GetStringAsync("https://dummyjson.com/users");

        // TODO: didn't have time to finish this
        return new UsersResult { Users = json };
    }
}

// TODO: move somewhere
public class UsersResult
{
    public string Users { get; set; }
}
