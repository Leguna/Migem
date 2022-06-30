using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private float width;
    private float maxHealth;
    private float currentHealth;
    

    private float FilledNormalized => currentHealth/maxHealth;
    
    public void UpdateUI()
    {
        
    }

}
