using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGunStats 
{
    Transform BulletSpawnPoint { get; }
    GameObject BulletPrefab { get; }
    int BulletsPerShot { get; }
    int CurrentBulletCount { get; }
    int MaxBulletCount { get; }
    float TimeBetweenShots { get; }
    float BulletSpeed { get; }
}
