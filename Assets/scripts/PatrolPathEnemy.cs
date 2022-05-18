using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPathEnemy : MonoBehaviour
{
    public float speed;
    public Transform[] patrolPoints;
    public float WaitTime;
    int currentPointIndex;

    bool once;

    private void Update()
    {
        if(transform.position != patrolPoints[currentPointIndex].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
        }
        else
        {
            if (once == false)
            {
                once = true;
                StartCoroutine(Wait());
            }
            
        }

    
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(WaitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }else
        {
            currentPointIndex = 0;
        }
        once = false;
        
    }

    
}
