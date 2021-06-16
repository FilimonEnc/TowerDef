
using System;
using Script;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // переменные. некоторым сразу не даю значение( тем что паблик) что бы в рил тайме менять и подстраивать
   
    public AudioSource mySource;
    public float startSpeed = 10f;
    
    [HideInInspector]
    
    public float speed;
    public int worth = 50;
    public float startHealth = 100;
    public float health;
    
    public GameObject deathEffect;
    public Image healthBar;
    private void Start()
    {
        if (WaveSpawner.instance.waveNumber <= 9)
        {
            health = (startHealth + WaveSpawner.instance.waveNumber * 2);
        }
        else
        {
            if ((WaveSpawner.instance.waveNumber >= 9) && (WaveSpawner.instance.waveNumber <= 25))
            {
                health = (startHealth + WaveSpawner.instance.waveNumber * 3);
            }
            else
            {
                health = (startHealth + WaveSpawner.instance.waveNumber * 8);
                speed = startSpeed;
            }
        }
        

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        
        healthBar.fillAmount = health / startHealth;
        
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

      WaveSpawner.enemyLive--;
      mySource.Play();
      Destroy(gameObject);
    }
}
