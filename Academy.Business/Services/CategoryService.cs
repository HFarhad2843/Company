using Academy.Business.Interfaces;
using Academy.Business.Utilities.Exeptions;
using Academy.Core.Entities;
using AcademyDataAccess.Contexts;

namespace Academy.Business.Services;

public class CategoryService : ICategoryServices
{
    public void Create(string name, string description)
    {
        if (string.IsNullOrEmpty(name))  throw new ArgumentNullException();
        Category? dbcategory =
            AcademyDbContext.Categories.Find(c=>c.Name.ToLower() == name.ToLower());
        if (dbcategory == is not null) throw new AlreadyExistExeption($"{name}");
           
    }
    public void Activate(string name, bool isActive = false)
    {
        throw new NotImplementedException();
    }
    
    public void Delete(string name)
    {
        throw new NotImplementedException();
    }

    public Category GetCategory(int Id)
    {
        throw new NotImplementedException();
    }

    public void GetGroupIncluded(string name)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        throw new NotImplementedException();
    }
}
