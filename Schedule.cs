namespace Project
{
    public class Schedule
    {
        // Constructor
        public Schedule(int dateId, TaskType taskType, int studentId, TaskStatus status)
        {
            this.DateId = dateId;
            this.TaskType = taskType;
            this.StudentId = studentId;
            this.Status = status;
        }

        // Properties
        public int DateId { get; }
        public TaskType TaskType { get; }
        public int StudentId { get; }
        public TaskStatus Status { get; private set; }

        // Methods
        public void SetStatus(TaskStatus status)
        {
            this.Status = status;
        }
    }
}
