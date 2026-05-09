using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    internal class GameSession
    {
        private Player? CurrentPlayer { get; set; }

        public GameSession() 
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = string.Empty;
        }
    }
}
