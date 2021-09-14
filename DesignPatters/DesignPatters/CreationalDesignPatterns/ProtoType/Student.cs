namespace DesignPatters.CreationalDesignPatterns.ProtoType
{
    public class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Student Clone()
        {
            return (Student)this.MemberwiseClone();
        }
    }
}