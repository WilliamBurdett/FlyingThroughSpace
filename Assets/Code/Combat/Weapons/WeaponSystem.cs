using UnityEngine;
using System.Collections;

public abstract class WeaponSystem : MonoBehaviour {
    public virtual Shot[] shots { get; protected set; }
    public virtual float FireRate { get; protected set; }
    public virtual int currentLevel { get; protected set; }
    public Layers.LayerEnum layer;

    public virtual Vector3[] baseGunPositions { get; protected set; }
    public virtual Vector3[] baseGunDirections { get; protected set; }

    protected float nextFire;

    // Use this for initialization
    void Start() {
        if (baseGunPositions.Length != baseGunDirections.Length) {
            Debug.Log("baseGunPositions & baseGunDirections ARE NOT THE SAME");
        }

        if (currentLevel == 0 || currentLevel == null) {
            currentLevel = 1;
        }
        nextFire = Time.time;
    }


    public virtual bool WeaponReady() {
        if (Time.time > nextFire) {
            nextFire = Time.time + FireRate;
            return true;
        }
        return false;
    }


    public virtual void Shoot() {
        if (WeaponReady()) {
            Shot shot = (Shot) Instantiate(shots[currentLevel - 1], transform.position, transform.rotation);
            shot.SetLayer(layer);
            shot.InstantiateBullets(baseGunDirections, baseGunPositions);
        }
    }
}
