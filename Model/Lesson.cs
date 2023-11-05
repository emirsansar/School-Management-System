namespace SchoolManagementSystem.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool Status { get; set; }

        public Lesson(int id, int branchİd, int teacherİd, string date, string time, bool status)
        {
            Id = id;
            BranchId = branchİd;
            TeacherId = teacherİd;
            Date = date;
            Time = time;
            Status = status;
        }

        public Lesson(int id, int branchİd, int teacherİd, int studentİd, string date, string time, bool status)
        {
            Id = id;
            BranchId = branchİd;
            TeacherId = teacherİd;
            StudentId = studentİd;
            Date = date;
            Time = time;
            Status = status;
        }
    }
}