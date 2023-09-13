namespace Services;

public class State
{
    public bool IsLoading { get; set; } = false;
    public bool HasError { get; set; } = false;

    public override string ToString()
    {
        return $"IsLoading: {IsLoading}\nHasError: {HasError}";
    }
}