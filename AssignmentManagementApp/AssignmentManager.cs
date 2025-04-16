using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentManagementApp
{
    public class AssignmentManager
    {
        private List<Assignment> assignments = new List<Assignment>();

        public void Add(Assignment assignment)
        {
            assignments.Add(assignment);
        }

        public Assignment GetById(int id)
        {
            return assignments.FirstOrDefault(a => a.Id == id);
        }

        public bool Update(int id, string newTitle, string newDescription)
        {
            var assignment = GetById(id);
            if (assignment == null) return false;

            if (string.IsNullOrWhiteSpace(newTitle) || string.IsNullOrWhiteSpace(newDescription))
                throw new ArgumentException("Title and Description cannot be empty");

            assignment.Title = newTitle;
            assignment.Description = newDescription;
            return true;
        }

        public bool Delete(int id)
        {
            var assignment = GetById(id);
            return assignment != null && assignments.Remove(assignment);
        }

        public List<Assignment> GetAll()
        {
            return assignments;
        }
    }
}
