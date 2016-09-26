using UnityEngine;
using System.Collections;

public static class Layers {
    public enum LayerEnum {
        Default = 0,
        TransparentFX = 1,
        IgnoreRaucast = 2,
        Water = 4,
        UI = 5,
        PlayerBullet = 8,
        Rocket = 9,
        Player = 10,
        Enemy = 11,
        EnemyBullet = 12
    };
}
