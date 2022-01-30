using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ease2Win_scr : MonoBehaviour
{
    public Vector2 nons;
    void Start()
    {
        transform.localScale = new Vector3(0.65f, 0.65f, 0.65f);
        transform.position = nons;
    }
}
