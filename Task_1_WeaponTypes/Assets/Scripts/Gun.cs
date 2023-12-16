using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private IGunType _gun;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _gun.Shot(Time.deltaTime);
        }
        
    }

    public void SetGun(IGunType gun)
    {
        _gun?.DisableGun();
        _gun = gun;
        _gun.ActivateGun();
    }

}
