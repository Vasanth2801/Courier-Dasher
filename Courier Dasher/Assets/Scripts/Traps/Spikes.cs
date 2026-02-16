using UnityEngine;

public class Spikes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerHealth.instance.TakeDamage(10);
            Debug.Log("Damage Done");
        }
    }
}
