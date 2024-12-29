namespace AlgoExpert;

internal class TournamentWinner
{
    public string FindWinner(List<List<string>> games,List<int> result)
    {
        Dictionary<string,int> teamsResult = new Dictionary<string,int>();
        int maxResult = int.MinValue;
        string topTeam = string.Empty;

        for(int i = 0; i < games.Count; i++) 
        {
            var team = games[i][result[i] == 0 ? 1 : 0];
            if(teamsResult.ContainsKey(team))
                teamsResult[team] += 3;
            else
                teamsResult.Add(team,3);

            if (teamsResult[team] > maxResult)
            {
                topTeam = team;
                maxResult = teamsResult[team];
            }
        }

        return topTeam;
    }
}
