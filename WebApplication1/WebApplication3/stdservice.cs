namespace WebApplication3
{
   
    public class stdservice
    {
        private IStudentrepo studentrepo;
        public stdservice(IStudentrepo studentrepo)
        {
            this.studentrepo = studentrepo;
        }
        public int save(string name , int age)
        {
            if(name == string.Empty)
            {
                return 0;
            }
            if(age == 0)
            {
                throw new Exception("Age is not valid");
            }
            student obj = new student();
            obj.Age = age;
            obj.Name = name.ToLower();           

            return studentrepo.saveDB(obj);
        }
    }
}
