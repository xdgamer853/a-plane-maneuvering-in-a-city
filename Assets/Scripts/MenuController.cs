using UnityEngine;

public class MenuController : MonoBehaviour
{
    private Canvas _canvas;
    void Start()
    {
        _canvas = GetComponent<Canvas>();
        _canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _canvas.enabled)
        {
            _canvas.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !_canvas.enabled)
        {
            _canvas.enabled = true;
        }
    }
}
