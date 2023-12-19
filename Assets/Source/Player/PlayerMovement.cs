using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed; // Скорость персонажа
   // [SerializeField] private int _increaseRate;
                                           //  void Update() =>


    private void SpeedIncrease()
    {
        //  _speed = _speed * 2;
        PlayerPrefs.SetFloat("_speed", PlayerPrefs.GetFloat("_speed")*2); //Сохранение скорости при старте

        Debug.Log("Speed Increased");
    }
    private void Start()
    {
        PlayerPrefs.SetFloat("_speed", _speed); //Сохранение скорости при старте
        InvokeRepeating("SpeedIncrease",15,15);
    }
    void Update()
    {
        transform.position += Vector3.right * PlayerPrefs.GetFloat("_speed") * Time.deltaTime; //Перемещение персонажа
    }
}