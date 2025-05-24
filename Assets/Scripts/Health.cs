using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 100;

    public void Damage(int points)
    {
        this.points -= points;
    }

    public void Heal(int points)
    {
        this.points += points;
    }
    
}
