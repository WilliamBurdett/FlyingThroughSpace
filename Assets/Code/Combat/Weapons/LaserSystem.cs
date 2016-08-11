using UnityEngine;
using System.Collections;

public class LaserSystem : WeaponSystem {
    [SerializeField] private LaserShot[] laserShots;
    [SerializeField] private float fireRate;
    [SerializeField] private int level;
    private float baseFireRate = 0.25f;

    //Default for laser
    private Vector3[] gunDirections = {
        new Vector3(1, 1, 1),
        new Vector3(-1, -1, 0),
    };

    //Default for laser
    private Vector3[] gunPositions = {
        new Vector3(1, 0, 0),
        new Vector3(-1, 0, 0),
    };

    public override Shot[] shots {
        get { return laserShots; }
        protected set { shots = laserShots; }
    }

    public override int currentLevel {
        get { return level; }
        protected set { currentLevel = level; }
    }

    public override Vector3[] baseGunPositions {
        get { return this.gunPositions; }
        protected set { baseGunPositions = gunPositions; }
    }

    public override Vector3[] baseGunDirections {
        get { return gunDirections; }
        protected set { baseGunDirections = gunDirections; }
    }

    void Start() {
        if (fireRate == 0) {
            fireRate = baseFireRate;
        }
        FireRate = fireRate;
    }
}
