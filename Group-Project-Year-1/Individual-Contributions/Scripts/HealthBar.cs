using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    /* pretty simple script that adds a slider which is then used as a percentage for the health bar, a gradient colour and a fill
     This script ended up not being used or was hidden within unity*/
    public Slider slider; // created a public Slider called slider
    public Gradient gradient; // created a public Gradient called gradient
    public Image fill; // an image called fill

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health; // the sliders is set to the max value and assigned to health.
        slider.value = health; // sliders value is health
        fill.color = gradient.Evaluate(1f); // 1f being full is the assigned gradient colour
    }

    public void SetHealth(int health)
    {
        slider.value = health; // sliders value is assigned as health
        fill.color = gradient.Evaluate(slider.normalizedValue); // fill colour is the sliders normalised value.
                                                                // A normalised value being a way of correcting raw data and normalising it so that it is not misinterpretated
    }

    
}
