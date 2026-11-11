using System.Collections.Generic;

namespace UniversityDbApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}