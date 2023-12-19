using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawKilling : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControls>() == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
