using UnityEngine;
using System.Collections;

public abstract class WeaponSystem : MonoBehaviour {
    public virtual Shot[] shots { get; protected set; }
    public virtual float FireRate { get; protected set; }
    public virtual int currentLevel  { get; protected set; }
    protected float nextFire;

    // Use this for initialization
    void Start() {
        if(currentLevel == 0 || currentLevel == null) {
            currentLevel = 1;
        }
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update() {}

    public virtual bool WeaponReady() {
        if (Time.time > nextFire) {
            nextFire = Time.time + FireRate;
            return true;
        }
        return false;
    }


    public virtual void Shoot() {
        
        if (WeaponReady()) {
            Instantiate(shots[currentLevel-1], transform.position, transform.rotation);
        }
    }
}
