namespace Project
{
    class Schedule
    {
        private int dateId;
        private TaskType taskType;
        private int studentId;
        private TaskStatus status;

        // Constructor
        public Schedule(int dateId, TaskType taskType, int studentId, TaskStatus status)
        {
            this.dateId = dateId;
            this.taskType = taskType;
            this.studentId = studentId;
            this.status = status;
        }

        // Methods
        public int GetDateId()
        {
            return dateId;
        }

        public TaskType GetTask()
        {
            return taskType;
        }

        public int GetStudentId()
        {
            return studentId;
        }

        public TaskStatus GetStatus()
        {
            return status;
        }

        public void SetStatus(TaskStatus status)
        {
            this.status = status;
        }
    }
}
