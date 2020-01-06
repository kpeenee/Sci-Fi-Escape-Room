using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicate : MonoBehaviour
{
   [SerializeField] Text textIndicator;
   [SerializeField] float waitTime;
    private string text;

    private void Start()
    {
        textIndicator.enabled = false;
    }

    public void SetIndicator(string indication)
    {
        text = indication;
        StartCoroutine(ShowIndicator());
    }

    IEnumerator ShowIndicator()
    {
        textIndicator.enabled = true;
        textIndicator.text = text;
        yield return new WaitForSeconds(waitTime);
        textIndicator.enabled = false;
    }
}
