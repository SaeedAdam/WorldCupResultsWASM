using WorldCupResults.Dtos;

namespace WorldCupResults.Services;

public interface IMatchService
{
    Task<StandingsResponseDto> GetStandings();
    Task<MatchesResponseDto> GetTodayMatches();
}
