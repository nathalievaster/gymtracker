namespace GymTracker.Models;

public class SetEntry
{
    public int Id { get; set; }
    // Foreign Key till WorkoutExercise
    public int WorkoutExerciseId { get; set; }
    // Navigation property 
    public WorkoutExercise WorkoutExercise { get; set; } = default!;

    public int Reps { get; set; }
    public double Weight { get; set; }
}
