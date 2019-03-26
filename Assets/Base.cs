using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;


    // Start is called before the first frame update
    void Start()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }

        tiberiumStart();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;
        if(tiberium >= 10)
        {
            Spawn();
            tiberium -= 10f;
        }
    }

    void moreTiberium()
    {
        tiberium += 1;
    }

    void tiberiumStart()
    {
        tiberium = 5.0f;
        InvokeRepeating("moreTiberium", 1, 1);
    }

    void Spawn()
    {
        GameObject fighter = GameObject.Instantiate<GameObject>(fighterPrefab);
        fighter.transform.parent = this.transform;
        fighter.transform.position = this.transform.position;
        fighter.transform.rotation = this.transform.rotation;
    }
}
