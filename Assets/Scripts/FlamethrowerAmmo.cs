using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamethowerAmmo : AmmoPickupScript
{
    private Space axis;
    private Space angle;

    // Start is called before the first frame update
    void Start()
    {
        // distinct audio
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3 axis, float angle);

        


    }
}
