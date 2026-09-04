using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgain : MonoBehaviour
{
    public TextMeshProUGUI LoseScreen;
    void Start()
    {
        
    }

    void Update()
    {
        if (LoseScreen.isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
