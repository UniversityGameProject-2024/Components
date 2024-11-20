using UnityEngine;

public class Scaler : MonoBehaviour
{
    [Tooltip("The speed of inflation")]
    [SerializeField]
    private float inflateSpeed = 1.0f;

    [Header("This is the range of scale")]
    [SerializeField]
    private float scaleRange = 5.0f;

    private Vector3 initialScale;
    private float count = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // targetScale = new Vector3(maxSize, maxSize, 1);
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        count = count + Time.deltaTime * inflateSpeed;

        float scaleValue = Mathf.Abs(Mathf.Sin(count) * scaleRange);

        transform.localScale = new Vector3(initialScale.x + scaleValue, initialScale.y + scaleValue, 1);
    }
}
