using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class QuestionTag
	{
		public int Id { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }
	}
}

