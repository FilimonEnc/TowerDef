using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    private int waypointIndex = 0;
    public Transform enemyR;
    private Enemy enemy;
    public float enemyrotatespeed = 20;
    private void Start()
    {
        enemy = GetComponent<Enemy>();
        target = Waypoints.points[0];

    }
    private void Update()
    {
       
        Vector3 dir = target.position - transform.position ;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(enemyR.rotation, lookRotation, Time.deltaTime* enemyrotatespeed).eulerAngles;
        transform.Translate(dir.normalized * (enemy.speed * Time.deltaTime), Space.World);
        enemyR.rotation = Quaternion.Euler(0f,rotation.y,0f);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
           GetNextWaypoint(); 
        }

        enemy.speed = enemy.startSpeed;


    }
    void GetNextWaypoint()
    {
        // иф для того что бы енеми уничтожался, ретурн, что бы ошибку не выдавало
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }
        //увеличение индекса вейпоинта идет, что бы не стоять на месте.
        waypointIndex++;
        target = Waypoints.points[waypointIndex];
        
    }

    void EndPath()
    {
        PlayerStats.Lives --;
        Destroy(gameObject);
    }
}
