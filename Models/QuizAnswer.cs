using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Game.Models
{
    public class QuizAnswer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int QuizId { get; set; }
        public bool isRightAnswer { get; set; }
        public string Answer { get; set; } = "";

    }
}
