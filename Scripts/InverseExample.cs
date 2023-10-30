using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class InverseExample : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Slider slider;
        [SerializeField] private Image image;
        [SerializeField] private Vector2 minMaxScale = new Vector2(1, 5);
        [SerializeField] private Color minColor = Color.white;
        [SerializeField] private Color maxColor = Color.green;

        private void Start()
        {
            slider.value = slider.minValue;
            OnValueChange(slider.value);
        }

        public void OnValueChange(float newValue)
        {
            text.text = newValue.ToString();
        
            float invertedLerp = Mathf.InverseLerp(slider.minValue, slider.maxValue, newValue);
        
            image.rectTransform.localScale = Mathf.Lerp(minMaxScale.x, minMaxScale.y, invertedLerp) * Vector3.one;
            image.color = Color.Lerp(minColor, maxColor, invertedLerp);
        }
    }
}