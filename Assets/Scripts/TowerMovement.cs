using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    public Rigidbody2D rgbd2;
    void Start()
    {
        Rigidbody2D rgbd2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Force = new Vector2(-20, 0);
        rgbd2.linearVelocity = Force;
    }
}
