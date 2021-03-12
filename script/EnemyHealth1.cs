using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth1 : MonoBehaviour
{
    public float health;
    public float MaxHealth;
    public GameObject healthbarUI;
    public Slider slider;


     void Start()
    {
        health = MaxHealth;
        slider.value = CalculateHealth(); 
    }


     void Update()
    {
        slider.value = CalculateHealth();

        if (health < MaxHealth)
        {
            healthbarUI.SetActive(true);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    float CalculateHealth()
    {
        return health / MaxHealth; 
    }

}
