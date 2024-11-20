using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 90f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
