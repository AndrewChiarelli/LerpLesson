using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpMethod2 : MonoBehaviour
    {
        [SerializeField] private float speed = 1;
        [SerializeField] private Slider slider;
        [SerializeField] private GameObject completeSignal;
        [SerializeField] private TextMeshProUGUI text;

        public void StartLerp()
        {
            StartCoroutine(LerpCoroutine());
        }

        private IEnumerator LerpCoroutine()
        {
            float elapsedTime = 0;
            float interval = 0;
            slider.value = slider.minValue;
            
            completeSignal.SetActive(false);

            while (slider.value != slider.maxValue)
            {
                elapsedTime += Time.deltaTime;
                interval = elapsedTime / speed;
                
                slider.value = Mathf.Lerp(slider.minValue, slider.maxValue, interval);
                text.text = slider.value.ToString();
                yield return null;
            }
            
            completeSignal.SetActive(true);
        }
    }
}