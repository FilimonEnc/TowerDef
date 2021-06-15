
using System;
using Script;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // переменные. некоторым сразу не даю значение( тем что паблик) что бы в рил тайме менять и подстраивать
   
   
    public float startSpeed = 10f;
    
    [HideInInspector]
    public float speed;
    public int worth = 50;
    public float health = 100;
    public GameObject deathEffect;

    private void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
        
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }
    
    void Die()
    { 
        PlayerStats.Money += worth;
        
      GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
      Destroy(effect, 5f);
      Destroy(gameObject);
    }
}
