using System;

public class Assignment
{
    public int Id { get; set; }                        // Optional: Useful if you plan to use this in a database
    public string Title { get; set; }                  // Title of the assignment
    public string Description { get; set; }            // Details or instructions
    public bool IsCompleted { get; set; }              // Whether the assignment is done
    public DateTime DueDate { get; set; }              // When it's due

    // ✅ Constructor initializes the key fields
    public Assignment(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false; // Default when creating new assignment
    }
}