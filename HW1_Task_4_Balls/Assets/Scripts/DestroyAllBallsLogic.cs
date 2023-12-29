using System.Collections.Generic;
using UnityEngine;

public class DestroyAllBallsLogic : IGameLogic
{
    private List<Ball> _ballCollector;
    private bool _isPlay;

    private int _currentCountOfBalls;

    public DestroyAllBallsLogic(List<Ball> ballCollector)
    {
        _ballCollector = ballCollector;
    }

    public void CheckBalls()
    {
        _currentCountOfBalls = 0;
        if (_isPlay == false)
            return;

        foreach (Ball ball in _ballCollector)
            if (ball != null)
                if (ball.isActiveAndEnabled)
                    _currentCountOfBalls++;

        if (_currentCountOfBalls == 0)
        {
            StopGame();
            Debug.Log("Game over");
        }
    }

    public void StartGame() => _isPlay = true;

    public void StopGame() => _isPlay = false;
}

    