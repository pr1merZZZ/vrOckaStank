using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public int score = 100;
    public void OnCollisionEnter()
    {
        Debug.Log("norm, check score!");
        score = score - 1;
    }
    void Start()
    {

    }


    void Update()
    {

    }
}
