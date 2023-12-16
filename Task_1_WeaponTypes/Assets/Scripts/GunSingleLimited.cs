using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSingleLimited : IGunType
{
    private IGunStats _gun;

    private float _time = 0;
    private bool _isShoot = false;
    public void ActivateGun() { }

    public void DisableGun() { }

    public GunSingleLimited(IGunStats stats)
    {
        _gun = stats;
    }

    public void CanShoot(bool isShoot)
    {
        _isShoot = isShoot;

    }

    public void Shot(float deltaTime)
    {
        for (int i = 0; i < _gun.BulletsPerShot; i++)
        {
            GameObject bullet = MonoBehaviour.Instantiate(_gun.BulletPrefab, _gun.BulletSpawnPoint.position, _gun.BulletSpawnPoint.rotation);
            bullet.transform.Translate(_gun.BulletSpawnPoint.forward * deltaTime * _gun.BulletSpeed);
            
                }

    }

    

}
