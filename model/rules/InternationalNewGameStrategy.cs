﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
  class InternationalNewGameStrategy : INewGameStrategy
  {

    public bool NewGame(Dealer a_dealer, Player a_player)
    {
      bool showCard = true;
      a_dealer.Deal(a_player, showCard);
      a_dealer.Deal(a_dealer, showCard);
      a_dealer.Deal(a_player, showCard);

      return true;
    }
  }
}
