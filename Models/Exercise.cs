using System.ComponentModel.DataAnnotations;

namespace GymTracker.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Hämtar workout exercises som är kopplade till övningen
        public List<WorkoutExercise> WorkoutExercises { get; set; } = new();
    }
}