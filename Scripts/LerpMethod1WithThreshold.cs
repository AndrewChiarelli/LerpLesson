using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpMethod1WithThreshold : MonoBehaviour
    {
        [SerializeField] private float speed = 1;
        [SerializeField] private float threshold = 0.001f;
        [SerializeField] private Slider slider;
        [SerializeField] private GameObject completeSignal;
        [SerializeField] private TextMeshProUGUI text;

        public void StartLerp()
        {
            StartCoroutine(LerpCoroutine());
        }

        private IEnumerator LerpCoroutine()
        {
            completeSignal.SetActive(false);
            slider.value = slider.minValue;
            
            while (slider.value < slider.maxValue - threshold)
            {
                slider.value = Mathf.Lerp(slider.value, slider.maxValue, Time.deltaTime * speed);
                UpdateText();
                yield return null;
            }
            
            slider.value = slider.maxValue;
            UpdateText();
            completeSignal.SetActive(true);
        }
        
        private void UpdateText()
        {
            text.text = slider.value.ToString();
        }
    }
}
