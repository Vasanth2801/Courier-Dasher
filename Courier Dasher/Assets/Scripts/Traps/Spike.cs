using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.025f;

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Damage Done");
        }
    }
}
