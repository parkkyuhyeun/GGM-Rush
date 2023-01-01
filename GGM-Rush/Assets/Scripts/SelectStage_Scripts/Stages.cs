using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stages : MonoBehaviour
{
    public GameObject pannel;
    private bool changeEnable;
    public string sceneName;
    CircleCollider2D circle;
    void Start()
    {
        circle = GetComponent<CircleCollider2D>();
    }
    public void Update()
    {

        if (Input.GetKey(KeyCode.Space) && changeEnable)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        changeEnable = true;
        if (collision.gameObject.name == "Player")
        {
            pannel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pannel.SetActive(false);
        changeEnable = false;
    }
}
