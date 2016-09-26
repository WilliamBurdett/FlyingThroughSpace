using UnityEditor.Animations;
using UnityEngine;

public abstract class Shot : MonoBehaviour {
    public virtual Bullet bullet { get; protected set; }
    public virtual Vector3[] baseDirections { get; set; }

    public virtual void InstantiateBullets(Vector3[] baseGunDirections, Vector3[] baseGunPositions) {
        int minSpawnPosDir = Mathf.Min(baseGunPositions.Length, baseGunDirections.Length);
        for (int i = 0; i < minSpawnPosDir; i++) {
            foreach (Vector3 baseDirection in baseDirections) {
                Vector3 spawnLocation = GetSpawenLocation(baseGunPositions[i]);

                Bullet shotBullet = (Bullet) Instantiate(bullet, spawnLocation,
                    Quaternion.Euler(transform.rotation.eulerAngles));
                if (gameObject.layer != (int) Layers.LayerEnum.Default) {
                    shotBullet.gameObject.layer = gameObject.layer;
                }

                //Calculate angles of shots
                //Starts with transform's forward angle
                //Each angle is the difference between the direction of the shot * gun direction
                //Gun direction vector is always 1 to -1 for all directions
                shotBullet.transform.eulerAngles =
                    new Vector3(shotBullet.transform.eulerAngles.x + (baseGunDirections[i].x*baseDirection.x),
                        shotBullet.transform.eulerAngles.y + (baseGunDirections[i].y*baseDirection.y),
                        shotBullet.transform.eulerAngles.z + (baseGunDirections[i].z*baseDirection.z));
            }
        }
    }

    public void SetLayer(Layers.LayerEnum layer) {
        gameObject.layer = (int) layer;
    }

    protected Vector3 GetSpawenLocation(Vector3 baseGunPosition) {
        Vector3 worldOffset = transform.rotation*baseGunPosition;
        return transform.position + worldOffset;
    }
}

