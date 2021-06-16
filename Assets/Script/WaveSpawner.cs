
using System;
using UnityEngine;
using System.Collections;
using Script;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public AudioSource mySource;
    public static int enemyLive = 0;
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 1;
    public float countdown = 2f;
    public int waveNumber = 0;
    public float SecondsSpawn = 0.5f;
    public Text WaveCountdownText;

    public static WaveSpawner instance;
    
    
  

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        
        if (enemyLive > 0)
        {
            return;
        }
        
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;

        }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        WaveCountdownText.text ="Время до следующей волны: " + $"{countdown:00.00}";
    }

    IEnumerator SpawnWave()
    {
      waveNumber++;
      PlayerStats.rounds++;
        for (int i = 0; i < waveNumber; i++)
        {
            mySource.Play();
            SpawnEnemy();
            yield return new WaitForSeconds(SecondsSpawn);
            
        }

        
    }
    void SpawnEnemy()
    {
        enemyLive++;
        
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    

}
