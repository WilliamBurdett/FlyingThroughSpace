using UnityEngine;
using System.Collections;

public interface IHealth {
    float Health { get; set; }
    float MaxHealth { get; set; }
    void TakeDamage(Damage damage);
    float PercentHealth();
}
