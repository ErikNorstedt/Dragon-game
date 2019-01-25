using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    Image healthBar;
    float maxHealth = 160f;
    public static float health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
