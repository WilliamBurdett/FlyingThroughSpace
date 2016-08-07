using UnityEngine;
using System.Collections;

public class LaserCannon : Weapon {
    [SerializeField] private LaserShot[] laserShots;
    [SerializeField] private float fireRate;
    private float baseFireRate = 0.25f;

    public override Shot[] shots {
        get { return laserShots; } 
        protected set { shots = laserShots; }
    }

    void Start() {
        Debug.Log(laserShots.Length);
        if (fireRate == 0) {
            fireRate = baseFireRate;
        }
        base.FireRate = this.fireRate;
    }
    
    
}
