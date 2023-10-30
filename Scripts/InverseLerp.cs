using UnityEngine;

namespace AC.Lerp
{
    public class InverseLerp : MonoBehaviour
    {
        [SerializeField] private Vector2 minMaxValue = new Vector2(0, 50);
        [SerializeField] private float interval = 25;
        
        // Start is called before the first frame update
        void Start()
        {
            float invertedLerp = Mathf.InverseLerp(minMaxValue.x, minMaxValue.y, interval);
            Debug.Log(invertedLerp);
        }
    }
}