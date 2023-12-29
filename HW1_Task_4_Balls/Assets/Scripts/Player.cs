using UnityEngine;

public class Player : MonoBehaviour
{
    private IGameLogic _gameLogic;

    public void onCheckBalls() => _gameLogic?.CheckBalls();

    public void SetGameLogic(IGameLogic gameLogic)
    {
        _gameLogic?.StopGame();
        _gameLogic = gameLogic;
        _gameLogic?.StartGame();
    }
}
