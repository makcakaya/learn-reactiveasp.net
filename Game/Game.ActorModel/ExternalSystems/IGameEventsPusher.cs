using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ActorModel.ExternalSystems
{
    public interface IGameEventsPusher
    {
        void PlayerJoined(string playerName, int playerHealth);
        void UpdatePlayerHealth(string playerName, int playerHealth);
    }
}
