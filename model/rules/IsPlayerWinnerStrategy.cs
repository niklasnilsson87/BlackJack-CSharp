namespace BlackJack.model.rules
{
  class IsPlayerWinnerStrategy : IWinnerStrategy
  {

    public bool IsDealerWinner(model.Player a_dealer, model.Player a_player, int g_maxScore)
    {
      if (a_player.CalcScore() > g_maxScore)
      {
        return true;
      }
      else if (a_dealer.CalcScore() > g_maxScore)
      {
        return false;
      }
      else if (a_dealer.CalcScore() == a_player.CalcScore())
      {
        return false;
      }

      return a_dealer.CalcScore() > a_player.CalcScore();
    }
  }
}
