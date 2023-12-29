using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private RayCastMouse _rayCastMouse;

    [SerializeField] private Transform _ballsCollector;
    [SerializeField] private List<Ball> _ballsCollectorList;
    [SerializeField] private string CurrentBallCollor;

    private bool _isGameChoosed;

    void Start()
    {
        _isGameChoosed = false;
        _rayCastMouse.isCanPick(false);
        AddBallsInCollectorList();

        CurrentBallCollor = null;
        Debug.Log("Выберите режим игры:");
        Debug.Log($"Для выбора режима {"ОДИН ЦВЕТ"} нажмите Q ");
        Debug.Log($"Для выбора режима {"ВСЕ ШАРИКИ"} нажмите W ");
    }

    private void Update()
    {   //Это выбор игры шариками одного цвета
        if (Input.GetKeyDown(KeyCode.Q) && _isGameChoosed == false)
        {
            Debug.Log("Выберите цвет: Белый - 1, Красный - 2, Зеленый-3");
            _isGameChoosed = true;
        }

        //Это выбор игры всеми шариками
        if (Input.GetKeyDown(KeyCode.W) && _isGameChoosed == false)
        {
            Debug.Log("Сломайте все шарики");
            _rayCastMouse.isCanPick(true);
            _player.SetGameLogic(new DestroyAllBallsLogic(_ballsCollectorList));
            _player.onCheckBalls();
            
        }
        //кнопка рестарта
        if (Input.GetKeyDown(KeyCode.R))
            Restart();

        //Выбор цвета для игры одним цветом
        if (_isGameChoosed == false)
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1)&& CurrentBallCollor == null)
            OneCollorStartGame("White");

        if (Input.GetKeyDown(KeyCode.Alpha2) && CurrentBallCollor == null)
            OneCollorStartGame("Red");

        if (Input.GetKeyDown(KeyCode.Alpha3) && CurrentBallCollor == null)
            OneCollorStartGame("Green");
    }

    private void OneCollorStartGame(string color)
    {
        _player.SetGameLogic(new DestroyOneCollorLogic(_ballsCollectorList, color));
        _rayCastMouse.isCanPick(true);
        _player.onCheckBalls();
    }

    private void AddBallsInCollectorList()
    {
        foreach(Transform ball in _ballsCollector)
        {
            _ballsCollectorList.Add(ball.GetComponent<Ball>());
        }
    }

    private void Restart() {
        CurrentBallCollor = null;
        _player.SetGameLogic(null);
        for(int i =0; i < _ballsCollectorList.Count; i++)
        {
            _ballsCollectorList[i].gameObject.SetActive(true);
        }
        Debug.Log("Рестарт");
        Start();
    }
}