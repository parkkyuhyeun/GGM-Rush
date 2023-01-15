using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Image[] lifeIcon;
    public void SetLifeIcon(int life)
    {
        for(int i = 0; i < 5; i++)
        {
            lifeIcon[i].color = new Color(1, 1, 1, 0);
        }
        for(int i = 0; i < life; i++)
        {
            lifeIcon[i].color = new Color(1, 1, 1, 1);
        }
    }
}
