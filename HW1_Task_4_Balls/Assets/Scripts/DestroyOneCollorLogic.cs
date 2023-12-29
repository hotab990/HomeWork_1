using System.Collections.Generic;
using UnityEngine;

public class DestroyOneCollorLogic : IGameLogic
{
    private List<Ball> _ballCollector;
    private string _ballCollor;

    private int _ballsInChoosedColor=0;

    private bool _isPlay;

    public DestroyOneCollorLogic(List<Ball> ballCollector, string ballCollor)
    {
        _ballCollector = ballCollector;
        _ballCollor = ballCollor;
    }

    public void CheckBalls()
    {
        _ballsInChoosedColor = 0;
        if (_isPlay == false)
            return;

        foreach (Ball ball in _ballCollector)
            if (ball != null)
                if (ball.ballCollor.ToString() == _ballCollor&& ball.isActiveAndEnabled)
                    _ballsInChoosedColor++;
        
        Debug.Log($"Осталось шариков {_ballsInChoosedColor} цвета {_ballCollor}");
        if(_ballsInChoosedColor == 0)
        {
            StopGame();
            Debug.Log("Game over");
            Debug.Log("Для рестарта нажмите R");
        }
    }

    public void StartGame() => _isPlay = true;

    public void StopGame() => _isPlay = false;
}
