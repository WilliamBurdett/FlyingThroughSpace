using UnityEngine;
public abstract class Shot : MonoBehaviour {
    public virtual Bullet bullet { get; protected set; }
    public virtual Vector3[] baseDirections { get; protected set; }


    // Use this for initialization

    protected virtual void Start() {        InstantiateBullets();    }

    protected virtual void InstantiateBullets() {
        foreach(Vector3 direction in baseDirections) {            Instantiate(bullet,transform.position,transform.rotation * Quaternion.Euler(direction));        }
    }

    // Update is called once per frame
    void Update() {}}

