using Academy.Core.Interfaces;

namespace Academy.Core.Entities;

public class Student:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Email { get; set;}
    public Group Group { get; set; }
    public bool IsDeleted { get; set; }
    private static int _id;
    public Student (string name)
    {
        Id = _id++;
        Name = name;
    }
}
