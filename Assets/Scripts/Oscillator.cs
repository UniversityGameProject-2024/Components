using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float speed = 1f;
    public float range = 3f;
    // direction:  +1 - at first go right
    //             -1 - at first go left
    public float direction = 1f;
    punbhd
    private Vector3 initialPosition;
    private float count = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        count = count + Time.deltaTime * speed;

        float moveX = Mathf.Sin(count) * direction * range;

        transform.position = new Vector3(initialPosition.x + moveX, initialPosition.y, initialPosition.z);
    }
}
