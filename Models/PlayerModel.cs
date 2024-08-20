namespace FantasyPredictor.Web.Models;

public class PlayerModel
{
    int Id { get; set; }
    string Name { get; set; } = null!;
    int TeamId { get; set; }
    string Position { get; set; } = null!;
    int TotalPoints { get; set; }
    int Price { get; set; }
    int PointsPerGame { get; set; }
    int PredictedPointsNextGame { get; set; }
    int Goals { get; set; }
    int Assists { get; set; }
    int CleanSheets { get; set; }
    int GoalsConceded { get; set; }
    int OwnGoals { get; set; }
    int PenaltiesSaved { get; set; }
    int PenaltiesMissed { get; set; }
    int YellowCards { get; set; }
    int RedCards { get; set; }
    int Saves { get; set; }
    private bool IsInjured { get; set; }
}
