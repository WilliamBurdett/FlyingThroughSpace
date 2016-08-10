using UnityEditor.Animations;
using UnityEngine;

public abstract class Shot : MonoBehaviour {
    public virtual Bullet bullet { get; protected set; }
    public virtual Vector3[] baseDirections { get; protected set; }
    public virtual Vector3[] baseGunPositions { get; protected set; }
    public virtual Vector3[] baseRelativeDirections { get; protected set; }
    private int minSpawnPosDir;
    

    protected virtual void Start() {
        if (baseGunPositions.Length != baseRelativeDirections.Length) {
            Debug.Log("baseGunPositions & baseRelativeDirections ARE NOT THE SAME");
        }
        minSpawnPosDir = Mathf.Min(baseGunPositions.Length, baseRelativeDirections.Length);
        InstantiateBullets();
        //Destroy(gameObject);
    }

    protected virtual void InstantiateBullets() {
        for (int i = 0; i < minSpawnPosDir; i++) {
            foreach (Vector3 baseDirection in baseDirections) {
                 
                Bullet shotBullet = (Bullet)Instantiate(bullet,transform.position + baseGunPositions[i],
                                    Quaternion.Euler(transform.rotation.eulerAngles));
                
                shotBullet.transform.eulerAngles =
                    new Vector3(shotBullet.transform.eulerAngles.x+(baseRelativeDirections[i].x * baseDirection.x),
                        shotBullet.transform.eulerAngles.y+(baseRelativeDirections[i].y * baseDirection.y),
                        shotBullet.transform.eulerAngles.z+(baseRelativeDirections[i].z * baseDirection.z));
                
            }
        }
    }
}

