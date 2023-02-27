using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class UserAnswerVote
	{
		public int Id { get; set; }

        [ForeignKey("Answer")]
        public int AnswerId { get; set; }

        //[ForeignKey("User")]
        //public int UserId { get; set; }

        public bool? Value { get; set; }
    }
}

