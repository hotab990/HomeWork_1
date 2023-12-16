using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private IGunType _gun;
    private IGunStats _gunStats;

    private float _timeSinceLastShot =0f;


    private void Update()
    {
        if (_timeSinceLastShot >=_gunStats.TimeBetweenShots)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                StartCoroutine(RealiseShot());

        }
        _timeSinceLastShot += Time.deltaTime;
        Debug.Log(_timeSinceLastShot);
    }

    public void SetGun(IGunType gun)
    {
        _gun?.DisableGun();
        _gun = gun;
        _gun.ActivateGun();
    }

    public void GetGunStats(IGunStats gunStats)
    {
        _gunStats = gunStats;
    }

    IEnumerator RealiseShot()
    {
        _timeSinceLastShot = 0;
        for (int i = 0; i < _gunStats.BulletsPerShot; i++)
        {
            _gun.Shot();
            yield return new WaitForSeconds(0.3f);
        }
    }

}
