﻿using System;
using System.Collections.Generic;

namespace Domineering.MinMax.Contracts
{
    public interface IGameState : IComparable<IGameState>
    {
        bool IsTerminal { get; }

        IEnumerable<IGameState> GetMoves(Player player);

        int GetValue(Player player);

        Player CurrentPlayer { get; }

        Player Opponent { get; }
    }
}
