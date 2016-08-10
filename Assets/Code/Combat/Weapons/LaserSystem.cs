using UnityEngine;
using System.Collections;

public class LaserSystem : WeaponSystem {
    [SerializeField] private LaserShot[] laserShots;
    [SerializeField] private float fireRate;
    [SerializeField] private int level;
    private float baseFireRate = 0.25f;

    public override Shot[] shots {
        get { return laserShots; } 
        protected set { shots = laserShots; }
    }

    public override int currentLevel {
        get { return level; }
        protected set { currentLevel = level; }
    }

    void Start() {
        if (fireRate == 0) {
            fireRate = baseFireRate;
        }
        FireRate = fireRate;
    }
    
}
