using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    [SerializeField] private string nextSceneName = "Level2"; // Cảnh tiếp theo

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("Chạm vào Door");

            if (BossHealth.bossDefeated)
            {
                Debug.Log("Boss đã bị tiêu diệt, chuyển cảnh...");
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                Debug.Log("Boss vẫn còn sống, chưa thể qua cửa!");
            }
        }
    }
}