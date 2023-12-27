using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTrader : ITrader
{

    protected override void Trade(Player player)
    {
        Debug.Log($"Продаю фрукты {player}");
    }


}
