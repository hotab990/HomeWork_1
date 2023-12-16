using UnityEngine;

public class GunSingleUnlimited : IGunType
{
    private IGunStats _gun;

    public void ActivateGun()
    {
        _gun.GunSkin.gameObject.SetActive(true);
    }

    public void DisableGun()
    {
        _gun.GunSkin.gameObject.SetActive(false);
    }

    public GunSingleUnlimited(IGunStats stats)
    {
        _gun = stats;
    }

    public void Shot()
    {
        GameObject bullet = MonoBehaviour.Instantiate(_gun.BulletPrefab,
            _gun.BulletSpawnPoint.position, _gun.BulletSpawnPoint.rotation);
        //bullet.transform.Translate(_gun.BulletSpawnPoint.forward * deltaTime * _gun.BulletSpeed);
        bullet.GetComponent<Rigidbody>().AddForce(_gun.BulletSpawnPoint.forward * _gun.BulletSpeed);
    }





}
