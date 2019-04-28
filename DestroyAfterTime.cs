using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public RandomGen rand;
    public Rigidbody rb;
    private Vector3 vel;
    float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        rand = GameObject.Find("ObjectDropPoint").GetComponent<RandomGen>();
        rb = GetComponentInParent<Rigidbody>();
        x = rand.GetRandom() / 100.0f;
        y = rand.GetRandom() / 100.0f;
        z = rand.GetRandom() / 100.0f;
        if (x < 5.0f)
        {
            x *= -1;
        }
        if (y < 5.0f)
        {
            y *= -1;
        }
        if (z < 5.0f)
        {
            z *= -1;
        }
        vel = new Vector3(x, y, z);
        rb.velocity = vel;
        Destroy(this.gameObject, 6.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
