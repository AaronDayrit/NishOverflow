using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class UserQuestionVote
	{
		public int Id { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        //[ForeignKey("User")]
        //public int Userid { get; set; }

        public bool? Value { get; set; }
	}
}

