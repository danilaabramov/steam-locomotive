using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce;

    public Rigidbody2D rb;

    public GameObject grob;

    public GameObject obj;
    
    private float _time;

    public GameObject gameStartUi;

    public GameObject score;
    
    public GameObject scoreFinal;
    
    private bool _isTransformNotNull;

    public void Start()
    {


        _isTransformNotNull = obj.transform != null;
        _time = 1;
        rb = GetComponent<Rigidbody2D>();
        // ReSharper disable once ConditionIsAlwaysTrueOrFalse
        if (PlayerPrefs.GetInt("flag").ToString() == "0" || PlayerPrefs.GetInt("flag").ToString() == null)
        {
            
            Time.timeScale = 0f;
            score.SetActive(false);
            gameStartUi.SetActive(true);
            scoreFinal.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("flag", 0);
            Time.timeScale = 1.5f;
            //score.SetActive(false);
            gameStartUi.SetActive(false);
        }
    }
    public void Update()
    {
         _time -= Time.deltaTime;
        if (_time < 0)
        {
            Instantiate(grob, new Vector3(10, -0.73f, 0), Quaternion.identity);
            _time = Random.Range(1.2f,2.2f);
        }

       
        if ( _isTransformNotNull && ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0) || Input.touchCount > 0) && obj.transform.position.y < -0.4 ))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

}
