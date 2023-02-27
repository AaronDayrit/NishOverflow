using System;
using Microsoft.EntityFrameworkCore;
using Project_3_StackOverflow.Models;

namespace Project_3_StackOverflow.Data
{
	public class NishOverflowContext: DbContext
	{
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;

        public DbSet<UserAnswerVote> UserAnswerVotes { get; set; } = null!;
        public DbSet<UserQuestionVote> UserQuestionVotes { get; set; } = null!;
        public DbSet<QuestionTag> QuestionTags { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
			Data Source=localhost;
			Database=NishOverflow;
			Integrated Security=false;
			User ID=sa;Password=MyPass@word;
			TrustServerCertificate=true;
			");
        }



        public NishOverflowContext(DbContextOptions<NishOverflowContext> options)
       : base(options)
        {
        }

    }
}

