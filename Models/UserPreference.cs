namespace GiftCraft.Models;

public class UserPreference
{
    public string Occasion { get; set; }
    public string Budget { get; set; }
    public string Category { get; set; }

    public UserPreference(string occasion, string budget, string category)
    {
        Occasion = occasion;
        Budget = budget;
        Category = category;
    }
}