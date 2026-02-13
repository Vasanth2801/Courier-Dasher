using System.Collections;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    [SerializeField] private float activationDelay = 0.5f;
    [SerializeField] private float activeDuration = 1.3f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    bool isActive = false;
    bool isTriggered = false;

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
        spriteRenderer.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!isTriggered)
            {
                StartCoroutine(ActivateTrap());
            }

            if(isActive)
            {
                Debug.Log("Damage Doing to the Player");
            }
        }
    }

    IEnumerator ActivateTrap()
    {
        isTriggered = true;

        yield return new WaitForSeconds(activationDelay);
        spriteRenderer.enabled = true;
        isActive = true;
        animator.SetBool("activated", true);
        yield return new WaitForSeconds(activeDuration);
        isActive = false;
        spriteRenderer.enabled = false;
        isTriggered = false;
        animator.SetBool("activated", false);
    }
}
