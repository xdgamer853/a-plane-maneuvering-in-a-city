using UnityEngine;

public class TowerDestroyer : MonoBehaviour
{
    public GameObject Tower1;
    public Transform Tower1T;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroyer();
    }

    public void Destroyer()
    {
        Vector3 v = new Vector3 (-100, 0, 0);
        if(Tower1T.position == v)
        {
            Destroy(Tower1);
        }
    }
}
