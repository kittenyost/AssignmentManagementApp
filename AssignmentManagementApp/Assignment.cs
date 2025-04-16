using System;

namespace AssignmentManagementApp
{
    /// <summary>
    /// Represents a task or assignment with details and a due date.
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// Unique identifier for the assignment.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title or name of the assignment.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description or details of the assignment.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the assignment is completed.
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The due date of the assignment.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Parameterless constructor for frameworks that require it (e.g., EF).
        /// </summary>
        public Assignment() { }

        /// <summary>
        /// Creates a new assignment with the provided title, description, and due date.
        /// </summary>
        public Assignment(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }
    }
}