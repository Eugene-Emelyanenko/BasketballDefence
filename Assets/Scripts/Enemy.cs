using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < -6)
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        FindObjectOfType<Score>().IncreaseScore();
    }
}
