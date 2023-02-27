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

        [Required]
        public string QuestionKey { get; set; } = "";

        [Required]
        public string Language { get; set; } = "";
        
        [Required] 
        public string Question { get; set; } = "";

        [Required]
        public List<QuizAnswer> quizAnswers { get; set; } = new List<QuizAnswer>();


    }
}
