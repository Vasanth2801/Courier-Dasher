using UnityEngine;
public class Pickup : MonoBehaviour
{
    [SerializeField] Color32 hasGiftColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noGiftColor = new Color32(1, 1, 1, 1);
    [SerializeField] SpriteRenderer spriteRenderer;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gift")
        {
            spriteRenderer.color = hasGiftColor;
            Destroy(other.gameObject);
        }

        if(other.tag == "Person")
        {
            spriteRenderer.color = noGiftColor;
        }
    }       
}