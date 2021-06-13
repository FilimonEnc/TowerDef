
using Script;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // переменные. некоторым сразу не даю значение( тем что паблик) что бы в рил тайме менять и подстраивать
    public float speed;
    private Transform target;
    private int waypointIndex = 0;

    private void Start()
    {
        target = Waypoints.points[0];

    }
    private void Update()
    {
        //тут скорость для энеми короче происходит
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            GetNextWaypoint();

        
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
