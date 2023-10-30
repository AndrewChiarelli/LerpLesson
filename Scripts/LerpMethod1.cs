using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpMethod1 : MonoBehaviour
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
            completeSignal.SetActive(false);
            slider.value = slider.minValue;
            
            while (slider.value != slider.maxValue)
            {
                slider.value = Mathf.Lerp(slider.value, slider.maxValue, Time.deltaTime * speed);
                text.text = slider.value.ToString();
                yield return null;
            }
            
            completeSignal.SetActive(true);
        }
    }
}
