using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive: SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;
    public GameObject bulletPrefab;

    public bool shoot = false;
        
    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = targetGameObject.transform.position;
        }
        if(Vector3.Distance(targetPosition, targetGameObject.transform.position) < 1)
        {
            shoot = !shoot;
        }

        if(shoot)
        {
            OnArrive();
        }
    }

    void OnArrive()
    {
        for(int i = 0; i < 7; i++)
        {
            GameObject bullets = GameObject.Instantiate<GameObject>(bulletPrefab);
            bullets.transform.parent = this.transform;
            bullets.transform.position = this.transform.position;
            bullets.transform.rotation = this.transform.rotation;
        }
        shoot = false;
    }
}