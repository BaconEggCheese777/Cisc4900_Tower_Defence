using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 50f;
	private Transform target;
	private int waypointIndex = 0;
	
	void Start()
{
	target = WayPoint.waypoints[0];
}
	void Update()
{
	Vector3 dir = target.position - transform.position;
	transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
	
	if(Vector3.Distance(transform.position, target.position) <= 0.2f)
	{
	GetNextWayPoint();
}
}

	void GetNextWayPoint()
{
	if(waypointIndex >= WayPoint.waypoints.Length - 1)
{
	Destroy(gameObject);
}

	waypointIndex++;
	target = WayPoint.waypoints[waypointIndex];
	
}

}
