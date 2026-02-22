namespace GymTracker.Models
{
    public class WorkoutExercise
    {
        public int Id { get; set; }
        // Foreign Key till WorkoutSession

        public int WorkoutSessionId { get; set; }
        // Navigation property till WorkoutSession, så att vi kan få tillgång till all information om workout sessionen som övningen är kopplad till
        public WorkoutSession WorkoutSession { get; set; } = default!;

        public int ExerciseId { get; set; }
        // Navigation property till Exercise, så att vi kan få tillgång till all information om övningen som är kopplad till workout sessionen
        public Exercise Exercise { get; set; } = default!;

        public List<SetEntry> Sets { get; set; } = new();
        public List<ExerciseMedia> Media { get; set; } = new();

    }
}