using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagementApp.Services
{
    public class AssignmentService
    {
        private readonly List<Assignment> assignments = new();

        public void AddAssignment(Assignment assignment)
        {
            if (assignment == null)
            {
                throw new ArgumentNullException(nameof(assignment));
            }
            assignments.Add(assignment);
        }

        public List<Assignment> GetAllAssignments()
        {
            return assignments;
        }

        public Assignment GetAssignmentById(int id)
        {
            return assignments.FirstOrDefault(a => a.Id == id);
        }

    }
}
