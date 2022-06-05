using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    public bool canShoot = true;

    //action fire a projectile
    public void FireProjectile()
    {
        //clone the projctile 
        GameObject clonedProjectile;
        //fire it in a direction
        clonedProjectile = Instantiate(projectilePrefab);

        clonedProjectile.transform.position = transform.position;

        //fire it in a dirtion 
        Rigidbody2D projectilerigidbody;

        //get the rigidbody from our cloned projectile and store it 
        projectilerigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        //set the velocity on the rigidbody to the editor setting
        projectilerigidbody.velocity = projectileVelocity;


    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if (!canShoot)
            return;


    }

}
