using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            winScreen.SetActive(true);
        }
    }
}
