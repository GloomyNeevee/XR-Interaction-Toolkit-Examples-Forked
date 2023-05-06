using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHoverCounter : MonoBehaviour
{
    [SerializeField] public GameObject ObjectToCount;
    [SerializeField] public TextMeshPro CounterToDisplay;

    // Update is called once per frame
    void Update()
    {
         CounterToDisplay.text = ObjectToCount.GetComponent<SelectCounter>().hoverCounter.ToString();
    }
}
