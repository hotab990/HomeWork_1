using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] public enum BallCollors { Green, Red, White };
    [SerializeField] public BallCollors ballCollor;

    public BallCollors BallCollor => ballCollor;
}
