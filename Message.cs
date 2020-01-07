using System;

namespace Project
{
    // Date/Subject/Message/Reply/Student ID
    class Message
    {
        private static int autoIncId = 1;

        // Constructor
        public Message(DateTime dateCreated, MessageSubject subject, string message, int studentId)
        {
            this.Id = autoIncId;
            this.DateCreated = dateCreated;
            this.Subject = subject;
            this.MessageText = message;
            this.StudentId = studentId;
            autoIncId++;
        }

        // Properties
        public int Id { get; }
        public DateTime DateCreated { get; }
        public MessageSubject Subject { get; }
        public string MessageText { get; }
        public string Reply { get; private set; }
        public int StudentId { get; }

        // Methods
        // Update reply
        public void UpdateReply(int messageId, string reply)
        {
            this.Reply = reply;
        }
    }
}
