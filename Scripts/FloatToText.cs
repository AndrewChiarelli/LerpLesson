using TMPro;
using UnityEngine;

namespace AC.Lerp
{
    public class FloatToText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        
        public void FloatConvert(float f)
        {
            text.text = f.ToString();
        }
    }
}
