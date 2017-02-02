using UnityEngine;
using System.Collections;


public class CarNav : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private int state;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
        state = 0;
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;
        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        Vector3 _rot = transform.localEulerAngles;
        switch ( state )
        {
            case 1:
                if (_rot.y >= 180.0f && _rot.y < 185.0f )
                {
                    _rot.y = 180.0f;
                    agent.angularSpeed = 0.0f;
                    state = 0;
                }
                break;
            case 2:
                if ( _rot.y >= 270.0f && _rot.y < 275.0f )
                {
                    _rot.y = 270.0f;
                    agent.angularSpeed = 0.0f;
                    state = 0;
                }
                break;
            case 3:
                if (_rot.y >= 90.0f && _rot.y < 95.0f)
                {
                    _rot.y = 90.0f;
                    agent.angularSpeed = 0.0f;
                    state = 0;
                }
                break;
            case 4:
                if ( _rot.y >= 0.0f && _rot.y < 5.0f)
                {
                    _rot.y = 0.0f;
                    agent.angularSpeed = 0.0f;
                    state = 0;
                }
                break;
        }
        transform.localEulerAngles = _rot;
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 1.5f)
            GotoNextPoint();
    }
    void OnTriggerEnter(Collider col)
    {
        if ( col.name.Equals("Point1"))
        {
            agent.angularSpeed = 120.0f;
            state = 1;
        }
        if ( col.name.Equals("Point2"))
        {
            agent.angularSpeed = 120.0f;
            state = 2;
        }
        if (col.name.Equals("Point3"))
        {
            agent.angularSpeed = 120.0f;
            state = 3;
        }
        if (col.name.Equals("Point4"))
        {
            agent.angularSpeed = 120.0f;
            state = 4;
        }
    }
}