using UnityEngine;
using System.Collections;

public class Laser : Bullet {
    [SerializeField] private float speed;

    void Start() {
        if (speed == 0 || speed == null) {
            speed = 120;
        }
    }

    public override float baseSpeed {
        get { return speed; }
        protected set { baseSpeed = speed; }
    }
    
}
