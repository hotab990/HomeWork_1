using UnityEngine;

public class RayCastMouse : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] Player _player;

    RaycastHit hit;
    private bool _isCanPick;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            HitBall(ray, hit);
        }
    }

    private void HitBall(Ray ray, RaycastHit hit)
    {
        if (Physics.Raycast(ray, out hit) && _isCanPick==true)
        {
            Transform objectHit = hit.transform;
            if (objectHit.TryGetComponent<Ball>(out Ball ball) == false)
                return;
            DisableBall(objectHit);

            Debug.Log(GetBallCollor(objectHit));

            _player.onCheckBalls();
            //Debug.Log(objectHit);
        }
    }


    private string GetBallCollor(Transform objectHit)
    {
        return objectHit.GetComponent<Ball>().BallCollor.ToString();
    }
    
    private void DisableBall(Transform objectHit)
    {
        objectHit.gameObject.SetActive(false);
    }

    public void isCanPick(bool canPick)
    {
        _isCanPick = canPick;
    }

}

