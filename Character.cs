public class Character
{
    public string Name { get; set; } = string.Empty;
    public string Age { get; set; } = string.Empty;
    public string Race { get; set; } = string.Empty;
    public string Quote { get; set; } = string.Empty;
    public string Img { get; set; } = string.Empty;
}

public class ApiResponse
{
    public List<Character> Content { get; set; } = new();
}
