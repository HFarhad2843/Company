using System.Text.RegularExpressions;

namespace Academy.Business.Interfaces;

public interface IGroupService
{
    void Create(string name, int maxStudentCount, string categoryName);
    Group GetById(int id);
    Group GetByname(string name);
    void Avtivate (string name, bool activated);
    void Delete (string name);
    void ShowAllStudent(string name);
    void ShowAll();
}
    