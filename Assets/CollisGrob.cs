using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisGrob : MonoBehaviour
{
    public void Update()
    { 
        if (gameObject.transform.position.x < -14.4) Destroy(gameObject);
    }
}
