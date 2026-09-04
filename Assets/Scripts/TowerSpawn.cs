using System.Collections;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject Tower1;
    [SerializeField]
    public GameObject Tower2;
    [SerializeField]
    public GameObject Tower3;
    public int Seconds;
    public float HowFarDoYouWantMe;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn ()
    {
        Vector3 v = new Vector3 (HowFarDoYouWantMe, 0f, -1);
        var Towernum = Random.Range(1, 4);
        switch(Towernum)
        {
            case 1:
                Instantiate(Tower1, v, Quaternion.identity);
                break;
            case 2:
                Instantiate(Tower2, v, Quaternion.identity);
                break;
            case 3:
                Instantiate(Tower3, v, Quaternion.identity);
                break;
        }
        yield return new WaitForSeconds(Seconds);
        StartCoroutine(Spawn());
    }

}
