// GolBet.Repositories/Interfaces/IMatchRepository.cs
using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null,
        string? searchTeamInMatch = null); //Wo#1 ---> Added parameter searchTeamInMatch
    Task<Match?> GetByIdWithDetailsAsync(int id);
}
