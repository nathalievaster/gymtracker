using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GymTracker.Models
{
    public class WorkoutSession
    {
        public int Id { get; set; }
        // Foreign Key till User
        public string UserId { get; set; } = string.Empty;
        // Navigation property till User, så att vi kan få tillgång till all information om användaren som skapade workout sessionen
        public IdentityUser User { get; set; } = default!;

        // Datumet för workout sessionen, default NU men kan ändras av användaren när den skapar sessionen
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty; // Slipper null-problem
        public string? Notes { get; set; }

        // När posten skapas
        public DateTime CreatedAt { get; set; }

        // Hämtar exercises som är kopplade till passet
        public List<WorkoutExercise> WorkoutExercises { get; set; } = new();

    }
}