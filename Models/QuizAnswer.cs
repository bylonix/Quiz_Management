using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Game.Models
{
    public class QuizAnswer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int QuizId { get; set; }
        [Required]
        public bool isRightAnswer { get; set; }
        [Required]
        public string Answer { get; set; } = "";

    }
}
