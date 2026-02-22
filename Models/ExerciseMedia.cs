namespace GymTracker.Models;

public class ExerciseMedia
{
    public int Id { get; set; }
    // Foreign Key till WorkoutExercise
    public int WorkoutExerciseId { get; set; }
    // Navigation property
    public WorkoutExercise WorkoutExercise { get; set; } = default!;

    public string FilePath { get; set; } = "";
    public string MediaType { get; set; } = ""; // image / video
    public string? Note { get; set; }

    public DateTime UploadedAt { get; set; } = DateTime.Now;
}
