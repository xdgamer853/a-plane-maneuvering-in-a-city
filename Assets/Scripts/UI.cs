using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Text;
    public bool isactive;
    [SerializeField]
    public Rigidbody2D rgbd2;
    void Start()
    {
        isactive = true;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isactive == true)
        {
            Textview();
        }
    }

    private void Textview ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Text.SetActive(false);
            isactive = false;
            Time.timeScale = 1f;
        }
    }
}
