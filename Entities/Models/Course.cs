namespace Entities.Models;

public class Course:Entity
{
    public string PicturePath { get; set; }
    public string Contents { get; set; }
    public Instructor Instructor { get; set; }
    public string Program { get; set; }
}