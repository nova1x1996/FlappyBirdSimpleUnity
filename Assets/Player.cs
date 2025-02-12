using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rg;
    [SerializeField] float veloJump = 5;
    [SerializeField] GameObject objGameOver;
    [SerializeField] TextMeshProUGUI textDiemHienTai;
    [SerializeField] TextMeshProUGUI textDiemTongKet;
    [SerializeField] AudioSource audioPoint;
    [SerializeField] AudioSource audioHit;
    [SerializeField] AudioSource audioDie;
    [SerializeField] AudioSource audioWing;
    [SerializeField] AudioSource audioSwoosh;



    public int Diem = 0;
    void Start()
    {
        audioSwoosh.Play();
        textDiemHienTai.gameObject.SetActive(true);
        Diem = 0;
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Backspace)){
            rg.AddForce(Vector2.up * veloJump , ForceMode2D.Impulse);
            audioWing.Play();
        }
    }

    public void LoadSceneAgain()
    {
   
        SceneManager.LoadScene(0);
    }
    void GameOver()
    {
        Time.timeScale = 0;
        textDiemTongKet.text = textDiemHienTai.text;
        textDiemHienTai.gameObject.SetActive(false);
        objGameOver.SetActive(true);
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        audioHit.Play();
        audioDie.PlayDelayed(0.3f);
            GameOver();
     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        audioPoint.Play();
        Diem++;
        textDiemHienTai.text = Diem.ToString();
        print("aaaa");
    }
}
 