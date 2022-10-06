using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyController : MonoBehaviour
{
    private bool hasKey;
    
    void Start()
    {
        hasKey = false;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            hasKey = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            if (hasKey)
            {
                Debug.Log("Kazandiniz!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Restart Scene Code

                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Once anahtari almalisin");
            }
        }
    }
}
