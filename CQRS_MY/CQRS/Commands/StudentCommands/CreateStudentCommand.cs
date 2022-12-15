namespace CQRS_MY.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand
    {
        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentDepartment { get; set; }
    }
}
