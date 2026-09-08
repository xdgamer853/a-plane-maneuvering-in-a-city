using UnityEngine;

public class Scorepoint : MonoBehaviour
{
    public GameObject Ring;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chracter")
        {
            Score.Instance.AddScore(1);
            Ring.SetActive(false);
        }
    }
}
