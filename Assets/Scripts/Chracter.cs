using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Chracter : MonoBehaviour
{
    public static Chracter Instance;
    public Rigidbody2D rgbd2;
    [SerializeField]
    public float JumpForce;
    [SerializeField]
    public float cooldown;
    private float NextJump;
    private bool YouAreDead;
    public GameObject LoseScreen;
    public TextMeshPro LoseScreenText;
    public GameObject Explosion;
    public GameObject Plane;
    public Transform PlaneT;
    public Transform ExplosionT;
    private int HighScore;
    public TextMeshProUGUI HighScoreT;
    public GameObject HighScoreGO;
    public AudioClip JumpFX;
    public AudioClip ExplosionFX;
    private void Start()
    {
        YouAreDead = false;
        HighScore = PlayerPrefs.GetInt("HighScore", HighScore);
        HighScoreT.text = "High Score: " + HighScore;
    }
    private void Update()
    {  
        Playercontrols();
    }
    private void FixedUpdate()
    {
        
    }

    private void Awake()
    {
            if(Instance == null)
        {
            Instance = this;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            YouAreDead = true;
            SoundFx.Instance.spawnsoundfx(ExplosionFX, transform, 1f);
            ExplosionT.position = new Vector3(PlaneT.position.x,PlaneT.position.y, -9);
            LoseScreen.SetActive(true);
            Explosion.SetActive(true);
            if(Score.Instance.score > HighScore)
            {
                HighScore = Score.Instance.score;
                HighScoreT.text = "New High Score: " + HighScore;
                PlayerPrefs.SetInt("HighScore", HighScore);
            }
            HighScoreGO.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;
            Time.timeScale = 0f;
        }
    }


    private void Playercontrols()
    {
        if (Input.GetKeyDown (KeyCode.Space) && Time.time > NextJump)
        {
            SoundFx.Instance.spawnsoundfx(JumpFX, transform, 1f);
            NextJump = cooldown + Time.time;
            rgbd2.linearVelocity = Vector2.up * JumpForce;
        }
    }
    public float Forcenum()
    {
        return JumpForce;
    }

}
