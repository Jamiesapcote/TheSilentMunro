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


            //find out from the rigidbody what our current horizontal and current speeds are 
            float currentSpeedH = (patrolPoints[currentPointIndex].position - transform.position).x;
            float currentSpeedV = (patrolPoints[currentPointIndex].position - transform.position).y;

            //get the animator companant that we will be using for settingg our aniamtion
            Animator ourAnimator = GetComponent<Animator>();

            // tell our animatior what the speeds are
            ourAnimator.SetFloat("SpeedH", currentSpeedH);
            ourAnimator.SetFloat("SpeedV", currentSpeedV);
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

        //get the animator companant that we will be using for settingg our aniamtion
        Animator ourAnimator = GetComponent<Animator>();

        // tell our animatior what the speeds are
        ourAnimator.SetFloat("SpeedH", 0);
        ourAnimator.SetFloat("SpeedV", 0);

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
