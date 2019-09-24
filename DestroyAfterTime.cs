using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAfterTime : MonoBehaviour
{
    public RandomGen rand;
    public Rigidbody rb;
    private Vector3 vel;
    float x, y, z;
    public Sprite image;
    // Start is called before the first frame update
    void Start()
    {
        rand = GameObject.Find("ObjectDropPoint").GetComponent<RandomGen>();
        rb = GetComponentInParent<Rigidbody>();
        if (rand.droppedNotSpawned == false) { 
            x = rand.GetRandom() / 100.0f;
            y = rand.GetRandom() / 100.0f;
            z = rand.GetRandom() / 100.0f;
            if (x < 5.0f)
            {
                x -= 5.0f;
            }
            if (y < 5.0f)
            {
                y -= 5.0f;
            }
            if (z < 5.0f)
            {
                z -= 5.0f;
            }
            vel = new Vector3(x, y, z);
            rb.velocity = vel;
        }
        else if (rand.droppedNotSpawned == true)
        {
            Vector3 dropDir = rand.playerDropPoint.position - rand.playerPos.position;
            rb.velocity = new Vector3(dropDir.x * 50 * Time.deltaTime , 0.0f, dropDir.z * 50 * Time.deltaTime);
        }

        Destroy(this.gameObject, 60.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public Sprite GetImage()
    {
        return image;
    }
}
