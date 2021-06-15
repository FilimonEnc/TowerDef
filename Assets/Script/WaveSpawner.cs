
using System;
using UnityEngine;
using System.Collections;
using Script;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 1;
    public float countdown = 2f;
    private int waveNumber = 0;
    public float SecondsSpawn = 0.5f;
    public Text WaveCountdownText;

    public static WaveSpawner instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;

        }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        WaveCountdownText.text ="Время до следующей волны: " + $"{countdown:00.00}";
    }

    IEnumerator SpawnWave()
    {
        waveNumber++;
        PlayerStats.rounds ++;
        
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(SecondsSpawn);
        }

        waveNumber++;
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }


}
