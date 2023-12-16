using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    [SerializeField] private GameObject _gunSingleLimited;
    

    private void Awake()
    {
         _gun.SetGun(new GunSingleLimited(_gunSingleLimited.GetComponent<GunStats>()));
    }
}
