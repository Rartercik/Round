using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iskat : MonoBehaviour
{
    public Transform a;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector2(a.position.x, a.position.y);
    }
}
