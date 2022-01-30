using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatoring : MonoBehaviour
{
    void Start()
    {
    	GetComponent<Animator>().SetTrigger("ou");
    }
}
