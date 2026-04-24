using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; } 
        public string Title { get; set; } 
        public string Author {  get; set; }
        public string Category { get; set; }
        public int CopiesAvailable { get; set; }

        public bool IsAvailable(int CopiesAvailable)
        {
            if (CopiesAvailable > 0)
                {
                    return true;
                }else {
                    return false;
                }
        }

    }
}
