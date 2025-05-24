using System;
using UnityEngine;

public class AttackBox : MonoBehaviour
{
    public int dmg = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>() == null) return;
        
        other.gameObject.GetComponent<Health>().Damage(dmg);
    }
}
