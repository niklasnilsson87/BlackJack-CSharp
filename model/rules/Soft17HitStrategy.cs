using System.Collections.Generic;

namespace BlackJack.model.rules
{
  class Soft17HitStrategy : IHitStrategy
  {
    private const int g_hitLimit = 17;

    public bool DoHit(model.Player a_dealer)
    {
      List<Card> list = (List<Card>)a_dealer.GetHand();

      if (a_dealer.CalcScore() == g_hitLimit)
      {
        return list.Exists(x => x.GetValue() == Card.Value.Ace);
      }
      else
      {
        return a_dealer.CalcScore() < g_hitLimit;
      }
    }
  }
}
