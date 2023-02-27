using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_3_StackOverflow.Models
{
	public class User
	{
		public int Id { get; set; }
        public string UserName { get; set; } = null!;
		public int Reputation { get; set; }
	}
}

