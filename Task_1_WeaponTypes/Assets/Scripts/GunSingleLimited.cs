using UnityEngine;

public class GunSingleLimited : IGunType
{
    private IGunStats _gun;

    private bool _isShoot = false;

    private int _bulletsInGun;

    public void ActivateGun() {
        _gun.GunSkin.gameObject.SetActive(true);
        _bulletsInGun = _gun.CurrentBulletCount;
    }

    public void DisableGun() {
        _gun.GunSkin.gameObject.SetActive(false);
    }

    public GunSingleLimited(IGunStats stats)
    {
        _gun = stats;
    }

    public void Shot()
    {

        if (_bulletsInGun <= 0)
            return;
        _bulletsInGun--;
            GameObject bullet = MonoBehaviour.Instantiate(_gun.BulletPrefab,
                _gun.BulletSpawnPoint.position, _gun.BulletSpawnPoint.rotation);

            //bullet.transform.Translate(_gun.BulletSpawnPoint.forward * deltaTime * _gun.BulletSpeed);
            bullet.GetComponent<Rigidbody>().AddForce(_gun.BulletSpawnPoint.forward * _gun.BulletSpeed);
        
    }



    





}
