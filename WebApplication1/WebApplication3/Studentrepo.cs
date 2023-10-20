namespace WebApplication3
{
    public class Studentrepo : IStudentrepo
    {
        public int saveDB(student s)
        {
            return 5;
        }
    }

    public interface IStudentrepo
    {
        int saveDB(student s);
    }
}
