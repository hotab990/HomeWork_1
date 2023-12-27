using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTrader : ITrader
{
   
    protected override void Trade(Player player)
    {
        Debug.Log($"Продаю броню {player}");
    }


}
