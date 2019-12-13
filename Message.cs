using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // Date/Subject/Message/Reply/Student ID
    class Message
    {
        private static int autoIncId = 1;
        private int id;
        private DateTime dateCreated;
        private MessageSubject subject;
        private string message;
        private string reply;
        private int studentId;

        // Constructor
        public Message(DateTime dateCreated, MessageSubject subject, string message, int studentId)

        {
            this.id = autoIncId;
            this.dateCreated = dateCreated;
            this.subject = subject;
            this.message = message;
            this.studentId = studentId;
            autoIncId++;
        }


        // Methods
        // Update reply
        public void UpdateReply(int messageId, string reply)
        {
            this.reply = reply;
        }

        // Get methods
        public int GetId()
        {
            return id;
        }

        public DateTime GetDateCreated()
        {
            return dateCreated;
        }

        public MessageSubject GetSubject()
        {
            return subject;
        }

        public string GetMessage()
        {
            return message;
        }

        public string GetReply()
        {
            return reply;
        }

        public int GetStudentId()
        {
            return studentId;
        }
    }
}
