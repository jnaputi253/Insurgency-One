using System;
using System.ComponentModel.DataAnnotations;

namespace InsurgencyOne.Models
{
    public class TaskItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Creator { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public DateTime? DateCompleted { get; set; }
    }
}
