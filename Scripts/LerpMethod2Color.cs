using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace AC.Lerp
{
    public class LerpMethod2Color : MonoBehaviour
    {
        [SerializeField] private float speed = 1;
        [SerializeField] private Color startColor = Color.white;
        [SerializeField] private Color endColor = Color.green;
        [SerializeField] private Image image;
        [SerializeField] private GameObject completeSignal;

        public void StartLerp()
        {
            StartCoroutine(LerpCoroutine());
        }
     
        private IEnumerator LerpCoroutine()
        {
            float elapsedTime = 0;
            float interval = 0;
            
            completeSignal.SetActive(false);
            image.color = startColor;

            while (image.color != endColor)
            {
                elapsedTime += Time.deltaTime;
                interval = elapsedTime / speed;
                
                image.color = Color.Lerp(startColor, endColor, interval);
                yield return null;
            }
            
            completeSignal.SetActive(true);
        }
    }
}