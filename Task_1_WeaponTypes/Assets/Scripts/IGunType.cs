using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGunType 
{
    public void ActivateGun() { }

    public void DisableGun() { }

    public void Shot(float deltaTime) { }

    public void CanShoot(bool isShoot) { }

    
}
