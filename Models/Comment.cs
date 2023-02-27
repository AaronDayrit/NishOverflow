using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class Comment
	{
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Upvotes { get; set; }
        public DateTime UploadDate { get; set; }

        [ForeignKey("Answer")]
        public int AnswerId { get; set; }

        //public int UserId { get; set; }
    }
}

