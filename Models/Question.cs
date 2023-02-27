using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class Question
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string? Description { get; set; }
		public int Upvotes { get; set; }
		public DateTime UploadDate { get; set; }
		public bool Answered { get; set; }

        //[ForeignKey("User")]
        //public int UserId { get; set; }
	}
}

