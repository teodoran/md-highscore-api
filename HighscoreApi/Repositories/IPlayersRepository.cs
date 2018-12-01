using System.Collections.Generic;
using System.Threading.Tasks;
using HighscoreApi.Dto;
using HighscoreApi.Entities;

namespace HighscoreApi.Repositories
{
  public interface IPlayersRepository
  {
    Player GetSingle(int id);
    Task<PlayerResponse> Add(PlayerUpsert playerCreate);
    Task<(PlayersRepositoryStatus Status, PlayerResponse Player)> Update(int id, PlayerUpsert player);
    void Delete(int id);
    int Count();
    bool Save();
    IEnumerable<Player> GetAll();
  }
}