namespace FantasyPredictor.Web.Models;

public class TeamModel
{
    int Id { get; set; }
    string Name { get; set; } = null!;
    int Wins { get; set; }
    int Draws { get; set; }
    int Losses { get; set; }
    int GoalsFor { get; set; }
    int GoalsAgainst { get; set; }
    int Points { get; set; }
    int Position { get; set; }
    int TopScorerId { get; set; }
    int PredictedResultNextGame { get; set; }
}