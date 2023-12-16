using UnityEngine;

public class GunStats : MonoBehaviour, IGunStats
{
    [SerializeField] private Transform _gunSkin;
    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _bulletsPerShot;
    [SerializeField] private int _currentBulletCount;
    [SerializeField] private float _timeBetweenShots;
    [SerializeField] private float _bulletSpeed;

    public Transform GunSkin => _gunSkin;
    public Transform BulletSpawnPoint => _bulletSpawnPoint;
    public GameObject BulletPrefab => _bulletPrefab;
    public int BulletsPerShot => _bulletsPerShot;
    public int CurrentBulletCount => _currentBulletCount;
    public float TimeBetweenShots => _timeBetweenShots;
    public float BulletSpeed => _bulletSpeed;
}
