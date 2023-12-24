namespace Academy.Business.Interfaces;

public interface IStudentService
{
    void Create(string name, string surname, string email, string groupName);
    void Delete (int id);
    void ChangeGroup (int studentId, string newgroupName);
}
