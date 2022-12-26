using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stages : MonoBehaviour
{
    public GameObject pannel;
    public string sceneName;
    CircleCollider2D circle;
    void Start()
    {
        circle = GetComponent<CircleCollider2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            pannel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pannel.SetActive(false);
    }
}
