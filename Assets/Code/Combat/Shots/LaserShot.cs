using UnityEngine;
using System.Collections;

public class LaserShot : Shot {
    [SerializeField] private Laser laser;

    [SerializeField] private Vector3[] relativeDirections = {
        new Vector3(1, 1, 1),
        new Vector3(-1, -1, 0),
    };

    [SerializeField] private Vector3[] directions;

    [SerializeField] private Vector3[] gunPositions = {
        new Vector3(0, 1, 0),
        new Vector3(0, -1, 0),
    };

    public override Bullet bullet {
        get { return laser; }
        protected set { bullet = laser; }
    }

    public override Vector3[] baseRelativeDirections {
        get { return relativeDirections; }
        protected set { baseRelativeDirections = baseRelativeDirections; }
    }

    public override Vector3[] baseDirections {
        get { return this.directions; }
        protected set { baseDirections = directions; }
    }

    public override Vector3[] baseGunPositions {
        get { return this.gunPositions; }
        protected set { baseGunPositions = gunPositions; }
    }
}
