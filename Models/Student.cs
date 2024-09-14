namespace Registrar;

public class Student
{
    private static Random random = new Random();
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Type { get; set; } = "";
    public List<Course> Courses { get; set; } = new List<Course>();
    public static int GenerateRandomId()
    {
        return random.Next(100000, 1000000);
    }
}
