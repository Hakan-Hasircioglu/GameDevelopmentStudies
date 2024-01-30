using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NerdControl : MonoBehaviour
{
    public float _jumpheight;
    public string SampleScene;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(3, 0) * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpheight);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Renderer>().enabled = false;
        Time.timeScale = 0;
    }
}
