using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnController : MonoBehaviour
{
    public GameObject dragonBreath;
    public float interval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("cloningDragonBreath", interval, interval);
    }

    private void cloningDragonBreath()
    {
        if (GameObject.FindWithTag("Player")!=null)
        {
            GameObject clonedDragonBreath = Instantiate(dragonBreath, transform.position, Quaternion.identity);
        }

        
    }
}
