using UnityEngine;

public class PlayerExample : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    [Header("GUNS")]
    [SerializeField] private GameObject _gunSingleLimited;
    [SerializeField] private GameObject _gunSingleUnlimited;
    [SerializeField] private GameObject _gunMultishotLimited;
    

    private void Awake()
    {
         _gun.SetGun(new GunSingleLimited(_gunSingleLimited.GetComponent<GunStats>()));
        _gun.GetGunStats(_gunSingleLimited.GetComponent<GunStats>());
         
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _gun.SetGun(new GunSingleLimited(_gunSingleLimited.GetComponent<GunStats>()));
            _gun.GetGunStats(_gunSingleLimited.GetComponent<GunStats>());
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _gun.SetGun(new GunSingleUnlimited(_gunSingleUnlimited.GetComponent<GunStats>()));
            _gun.GetGunStats(_gunSingleUnlimited.GetComponent<GunStats>());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _gun.SetGun(new GunMultishotLimited(_gunMultishotLimited.GetComponent<GunStats>()));
            _gun.GetGunStats(_gunMultishotLimited.GetComponent<GunStats>());
        }
    }
}
