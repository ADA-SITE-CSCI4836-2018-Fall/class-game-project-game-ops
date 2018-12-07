using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class RaceManager : MonoBehaviour {

    public GameObject positionDisplay;
    public List<GameObject> PlayerCarPrefabs;
    public Car[] allCars;
    public Car[] carOrder;
    private string selectedCar = "";

    public void Start()
    {
        selectedCar = CarSelection.selectedCar;
        foreach(GameObject obj in PlayerCarPrefabs)
        {
            if(obj.name == selectedCar)
            {
                Instantiate(obj);
            }
        }

        GameObject[] allAICarsOBJ = GameObject.FindGameObjectsWithTag("AIDriver01");
        GameObject playerOBJ = GameObject.FindGameObjectWithTag("Player");

        allCars = new Car[allAICarsOBJ.Length + 1];

        for(int i = 0; i < allCars.Length - 1; i++)
        {
            allCars[i] = allAICarsOBJ[i].GetComponent<Car>();
        }
        allCars[allCars.Length - 1] = playerOBJ.GetComponent<Car>();

        //Setup FinishTrigger
        Debug.Log("CHILD COUNT!!!!!!!!!" + playerOBJ.transform.childCount);
        RaceComplete.MyCar = playerOBJ;
        RaceComplete.FinishCamera =  playerOBJ.transform.GetChild(9).gameObject; //FinishCube
        RaceComplete.ViewModes = playerOBJ.transform.GetChild(6).gameObject; //Cube
        RaceComplete.LevelMusic = playerOBJ.transform.GetChild(7).GetChild(1).GetChild(0).gameObject; //LevelMusic
        RaceComplete.FinishMusic = playerOBJ.transform.GetChild(7).GetChild(0).GetChild(2).GetComponent<AudioSource>(); //FinishMusic
                                                                                                                        //End Setup

        //Setup StartCountdown
        StartCountdown.getReadyAudio = playerOBJ.transform.GetChild(7).GetChild(0).GetChild(0).GetComponent<AudioSource>(); //Get Ready Audio
        StartCountdown.goAudio = playerOBJ.transform.GetChild(7).GetChild(0).GetChild(1).GetComponent<AudioSource>(); //Go Audio
        StartCountdown.LevelMusic = playerOBJ.transform.GetChild(7).GetChild(1).GetChild(0).GetComponent<AudioSource>(); //Level Music
        //End Setupy
        CarController.value = GameObject.FindGameObjectWithTag("SpeedValue").GetComponent<Text>();
        

        carOrder = new Car[allAICarsOBJ.Length + 1];
        InvokeRepeating("ManualUpdate", 0.5f, 0.5f);
    }

    // this gets called every frame
    public void ManualUpdate()
    {
        foreach (Car car in allCars)
        {
            carOrder[car.GetCarPosition(allCars) - 1] = car;
        }

        for (int i = 0; i < allCars.Length; i++)
        {
            if (carOrder[i].gameObject.tag.Equals("Player"))
            {
                positionDisplay.GetComponent<Text>().text = (i + 1).ToString();
            }
        }
    }
}
