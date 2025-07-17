using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerMenu : MonoBehaviour
{
    public string nextSceneName = "_Menu"; // Tên scene cần chuyển đến

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}