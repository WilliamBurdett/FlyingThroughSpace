using UnityEngine;
using System.Collections;

public class LaserSystem : WeaponSystem {
    [SerializeField] private LaserShot[] laserShots;
    [SerializeField] private float fireRate;
    private float baseFireRate = 0.25f;

    public override Shot[] shots {
        get { return laserShots; } 
        protected set { shots = laserShots; }
    }

    void Start() {
        if (fireRate == 0) {
            fireRate = baseFireRate;
        }
        FireRate = fireRate;
    }
    
}
