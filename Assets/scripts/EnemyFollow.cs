using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;

    private void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > minimumDistance)
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //find out from the rigidbody what our current horizontal and current speeds are 
        float currentSpeedH = (target.position - transform.position).x;
        float currentSpeedV = (target.position - transform.position).y;

        //get the animator companant that we will be using for settingg our aniamtion
        Animator ourAnimator = GetComponent<Animator>();

        // tell our animatior what the speeds are
        ourAnimator.SetFloat("SpeedH", currentSpeedH);
        ourAnimator.SetFloat("SpeedV", currentSpeedV);
    } 
}
