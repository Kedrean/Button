using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI healthValueText;
    public float healthValue;

    private float duration = 0f;
    private float poisonInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // healthValueText.text = healthValue.ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        healthValueText.text = healthValue.ToString();

        duration += Time.deltaTime;

        // Check if it's time to apply poison
        if (duration >= poisonInterval)
        {
            Poison();
            // Reset the time since last poison
            duration = 0f;
        }
    }

    public void DamagePlayer()
    {
        healthValue -= 5;
    }

    public void Poison()
    {
        healthValue -= 5f;
    }
}
