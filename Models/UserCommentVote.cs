using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class UserCommentVote
	{
        public class User
        {
            public int Id { get; set; }

            [ForeignKey("Comment")]
            public int CommentId { get; set; }

            //[ForeignKey("User")]
            //public int Userid { get; set; }

            public bool? Value { get; set; }
        }
    }
}

