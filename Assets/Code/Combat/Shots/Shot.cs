using UnityEditor.Animations;
using UnityEngine;

public abstract class Shot : MonoBehaviour {
    public virtual Bullet bullet { get; protected set; }
    public virtual Vector3[] baseDirections { get; protected set; }
    public virtual Vector3[] baseGunPositions { get; protected set; }
    public virtual Vector3[] baseGunDirections { get; protected set; }
    private int minSpawnPosDir;
    
    protected virtual void Start() {
        if (baseGunPositions.Length != baseGunDirections.Length) {
            Debug.Log("baseGunPositions & baseGunDirections ARE NOT THE SAME");
        }
        minSpawnPosDir = Mathf.Min(baseGunPositions.Length, baseGunDirections.Length);
        InstantiateBullets();
        //Destroy(gameObject);
    }

    protected virtual void InstantiateBullets() {
        for (int i = 0; i < minSpawnPosDir; i++) {
            foreach (Vector3 baseDirection in baseDirections) {

                //Calculate gun offset spawn location
                Vector3 worldOffset = transform.rotation*baseGunPositions[i];
                Vector3 spawnLocation = transform.position + worldOffset;
                 
                Bullet shotBullet = (Bullet)Instantiate(bullet,spawnLocation,
                                    Quaternion.Euler(transform.rotation.eulerAngles));
                

                //Calculate angles of shots
                //Starts with transform's forward angle
                //Each angle is the difference between the direction of the shot * gun direction
                //Gun direction vector is always 1 to -1 for all directions
                shotBullet.transform.eulerAngles =
                    new Vector3(shotBullet.transform.eulerAngles.x+(baseGunDirections[i].x * baseDirection.x),
                        shotBullet.transform.eulerAngles.y+(baseGunDirections[i].y * baseDirection.y),
                        shotBullet.transform.eulerAngles.z+(baseGunDirections[i].z * baseDirection.z));
                
            }
        }
    }
}

