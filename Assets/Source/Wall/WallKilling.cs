using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallKilling : MonoBehaviour
{
    [SerializeField] GameObject _parentObj;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerTrigger>() == true)
        {
            //   Destroy(collision.gameObject);
            Destroy(_parentObj);
        }
    }
}
