using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScannerBatteries : MonoBehaviour
{
    [SerializeField] private float rechargeRate = 0.1f;
    [SerializeField] private float decayRate = 0.2f;

    [SerializeField] private float maxBatteries = 10f;

    [SerializeField] private Image batteryBar;

    private float currentBatteries = 0f;
    private bool isUsingScanar = false;

    public bool IsUsingScanar
    {
        set { isUsingScanar = value; }
    }
    private void Awake()
    {
        currentBatteries = maxBatteries;
    }

    private void Update()
    {
        batteryBar.fillAmount = currentBatteries / maxBatteries;
       
        if(isUsingScanar)
        {
            if(currentBatteries > 0)
            {
                currentBatteries -= decayRate * Time.deltaTime;
            }
        }
        else
        {
            currentBatteries += rechargeRate * Time.deltaTime;
        }
    }
}
