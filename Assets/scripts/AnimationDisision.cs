using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDisision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get our ridigbody that we'll need to find the physics inforamtioin 
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //find out from the rigidbody what our current horizontal and current speeds are 
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        //get the animator companant that we will be using for settingg our aniamtion
        Animator ourAnimator = GetComponent<Animator>();

        // tell our animatior what the speeds are
        ourAnimator.SetFloat("SpeedH", currentSpeedH);
        ourAnimator.SetFloat("SpeedV", currentSpeedV);

    }
}
