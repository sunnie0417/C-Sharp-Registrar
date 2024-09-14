namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",
      WeeklyHours = 1
    };
    courses.Add(course);

    return courses;
  }

  public static List<string> GetStudentTypes()
  {
    return ["Full Time", "Part Time", "Coop"];
  }

  private static List<Student> students = new List<Student>
  {
    new Student { Id = 111111, FirstName = "Sunnie", LastName = "Sun", Type = "Full Time"},
    new Student { Id = 222222, FirstName = "Harry", LastName = "Smith", Type = "Part Time"},
    new Student { Id = 333333, FirstName = "Alice", LastName = "Chen", Type = "Coop"}
  };

  public static List<Student> GetStudents()
  {
    return students;
  }

  public static Student? GetStudentById(int id)
  {
    return students.FirstOrDefault(s => s.Id == id);
  }
}
