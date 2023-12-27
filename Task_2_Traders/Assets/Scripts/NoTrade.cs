using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTrade : ITrader
{
   
    protected override void Trade(Player player)
    {
        Debug.Log($"Не продаю {player}");
    }


}
