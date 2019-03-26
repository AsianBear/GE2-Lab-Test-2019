using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSpawner : Base
{
   // public float tiberiumNumber;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(tiberium >= 10)
        {
            Spawn();
            tiberium -= 10;
            Debug.Log("-10");
        }
    }

    void Spawn()
    {
        GameObject fighter = GameObject.Instantiate<GameObject>(prefab);
        fighter.transform.parent = this.transform;
        fighter.transform.position = this.transform.position;
        fighter.transform.rotation = this.transform.rotation;
    }
}
