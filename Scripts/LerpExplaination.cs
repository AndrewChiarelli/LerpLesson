using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpExplaination : MonoBehaviour
    { 
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Slider slider;
        [SerializeField] private Vector2 minMaxValue = new Vector2(10, 30);
        
        private void Start()
        {
            slider.value = (slider.minValue + slider.maxValue) / 2;
            OnValueChange(slider.value);
        }

        public void OnValueChange(float newValue)
        {
            text.text = newValue.ToString();
            
            float invertedLerp = Mathf.InverseLerp(slider.minValue, slider.maxValue, newValue);
            text.text = Mathf.Lerp(minMaxValue.x, minMaxValue.y, invertedLerp).ToString("F2");
        }
    }
}
