using System.ComponentModel.DataAnnotations;
using GymTracker.Data;

namespace GymTracker.Models;

public class Exercise
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public bool IsGlobal { get; set; } = false;

    public string? OwnerId { get; set; }
    public ApplicationUser? Owner { get; set; }

    public List<WorkoutExercise> WorkoutExercises { get; set; } = new();
}