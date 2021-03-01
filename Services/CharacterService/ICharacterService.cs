using rpg_game.Models;
using System.Collections.Generic;

namespace rpg_game.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllChracters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}