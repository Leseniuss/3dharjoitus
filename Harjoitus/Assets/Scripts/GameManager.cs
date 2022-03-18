using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text Ohje;

    int points = 0;

    public void DecreasePoints()
    {

        points -= 1;
        Ohje.text = "Vie pallo valkoiselle maalialueelle => Pisteet: " + points;
    }

    public void IncreasePoints()
    {

        points += 1;
        Ohje.text = "Vie pallo valkoiselle maalialueelle => Pisteet: " + points;
    }

    public void Finish()
    {

        SceneManager.LoadScene(2);
    }
    public void Finish2()
    {
        SceneManager.LoadScene(0);
    }

}
