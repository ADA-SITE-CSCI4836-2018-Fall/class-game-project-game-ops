using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour {

    public static string selectedCar = "";
    public List<GameObject> cars = new List<GameObject>();
    private int currentCarIndex = 0;

    void Update ()
    {
        if (Input.GetButtonDown("rightButton"))
        {
            cars[currentCarIndex].SetActive(false);
            if(currentCarIndex == cars.Count - 1)
            {
                currentCarIndex = 0;
            }
            else
            {
                currentCarIndex++;
            }
            cars[currentCarIndex].SetActive(true);
        }
        else if (Input.GetButtonDown("leftButton"))
        {
            cars[currentCarIndex].SetActive(false);
            if (currentCarIndex == 0)
            {
                currentCarIndex = cars.Count - 1;
            }
            else
            {
                currentCarIndex--;
            }
            cars[currentCarIndex].SetActive(true);
        }

        if (Input.GetButtonDown("selectCar"))
        {
            selectedCar = cars[currentCarIndex].name;
            SceneManager.LoadScene("RaceInBakuF1Circuit");
        }

    }
}
