using System;
using Models;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float Width;
    private float MaxHealth;
    private float CurrentHealth;

    private Image Image;
    private void Start()
    {
        if (!TryGetComponent(out Image))
            print( "Image not found at HealthBar");
        Image.enabled = true;
    }

    private float FilledNormalized => CurrentHealth/MaxHealth;

    public void UpdateUI()
    {
        Image.fillAmount = FilledNormalized;
    }

}
