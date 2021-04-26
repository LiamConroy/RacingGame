using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public EnemyPath path;
    Vector3 target;
    int currentPathPoint = 0;
    public float sensitivity = .01f, speed;
    public Rigidbody sphere;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        target = path.waypoints[currentPathPoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localTarget = sphere.transform.InverseTransformPoint(target);
        float distanceToTarget = Vector3.Distance(target, sphere.transform.position);
        enemy.transform.LookAt(target);

        if (distanceToTarget < 2) {
            currentPathPoint++;
            if(currentPathPoint>= path.waypoints.Length) {
                currentPathPoint = 0;
            }
            target = path.waypoints[currentPathPoint].transform.position;
        }
        
        transform.position = sphere.transform.position;
    }
}
