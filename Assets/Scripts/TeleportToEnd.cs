using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("End");
        }
    }
}
