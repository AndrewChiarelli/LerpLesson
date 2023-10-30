using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpMethod2AnimCurve : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private GameObject completeSignal;
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private AnimationCurve animCurve;

        public void StartLerp()
        {
            StartCoroutine(LerpCoroutine());
        }

        private IEnumerator LerpCoroutine()
        {
            float elapsedTime = 0;
            float interval = 0;
            float timeToComplete = animCurve.keys[animCurve.length - 1].time;
            
            slider.value = slider.minValue;
            completeSignal.SetActive(false);

            while (slider.value != slider.maxValue)
            {
                elapsedTime += Time.deltaTime;
                interval = elapsedTime / timeToComplete;
                
                slider.value = animCurve.Evaluate(interval);
                text.text = slider.value.ToString();
                yield return null;
            }
            
            completeSignal.SetActive(true);
        }
    }
}