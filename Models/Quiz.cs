using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Quiz_Game.Models
{
    [Index(nameof(QuestionKey), nameof(Language), IsUnique = true)]
    public class Quiz {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string QuestionKey { get; set; } = "";
        
        public string Language { get; set; } = "";
        public string Question { get; set; } = "";

        public List<QuizAnswer> quizAnswers { get; set; } = new List<QuizAnswer>();


    }
}
