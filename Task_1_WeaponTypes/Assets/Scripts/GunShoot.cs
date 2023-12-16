using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    private Transform _bulletSpawnPoint;
    private GameObject _bulletPrefab;
    private int _bulletsPerShot;
    private int _currentBulletCount;
    private int _maxBulletCOunt;
    private float _timeBetweenShots;

    private float _bulletSpeed = 80f;
//    private bool _canShoot = true;//пока что сделаю тру, позже сделаю проверку патронов
    private float _time;

    public GunShoot(Transform bulletSpawnPoint, GameObject bulletPrefab, int bulletsPerShot,
        int currentBulletCount, int maxBulletCOunt, float timeBetweenShots)
    {
        _bulletSpawnPoint = bulletSpawnPoint;
        _bulletPrefab = bulletPrefab;
        _bulletsPerShot = bulletsPerShot;
        _currentBulletCount = currentBulletCount;
        _maxBulletCOunt = maxBulletCOunt;
        _timeBetweenShots = timeBetweenShots;
    }

    public void Shot(float deltaTime)
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            if (_time > _timeBetweenShots)
            {
                _time = 0f;
                GameObject bullet = Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = _bulletSpawnPoint.forward * _bulletSpeed * deltaTime;

            }
            _time += deltaTime;
        }
    }
}
