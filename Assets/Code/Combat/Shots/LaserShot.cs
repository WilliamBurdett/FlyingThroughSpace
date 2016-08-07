using UnityEngine;
using System.Collections;

public class LaserShot : Shot {
    
    [SerializeField] private Laser laser;
    [SerializeField] private Vector3[] directions;

    public override Bullet bullet {
        get { return laser; }
        protected set { bullet = laser; }
    }

    public override Vector3[] baseDirections {
        get { return this.directions; }
        protected set { baseDirections = directions; }
    }
    
	// Update is called once per frame
	void Update () {
	
	}
}
