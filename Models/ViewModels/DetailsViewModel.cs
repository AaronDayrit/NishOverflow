using System;
using Microsoft.EntityFrameworkCore;

namespace Project_3_StackOverflow.Models.ViewModels
{
	public class DetailsViewModel
	{
        public Question Question;
        public IQueryable<Answer> Answers;

        public DetailsViewModel(Question question, IQueryable<Answer> answers)
        {
            Question = question;
            Answers = answers;
        }
    }
}

