using UnityEngine;

public interface IGunStats 
{
    Transform GunSkin { get; }
    Transform BulletSpawnPoint { get; }
    GameObject BulletPrefab { get; }
    int BulletsPerShot { get; }
    int CurrentBulletCount { get; }
    float TimeBetweenShots { get; }
    float BulletSpeed { get; }
}
