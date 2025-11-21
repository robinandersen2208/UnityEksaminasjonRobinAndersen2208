using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Denna metod kan kopplas till knappar
    public void LoadPickupScene()
    {
        SceneManager.LoadScene("PickupScene"); // Byt till namnet på din pickup-scene
    }

    // Om du vill ladda via index istället:
    // public void LoadPickupScene()
    // {
    //     SceneManager.LoadScene(1); // Index 1 i Build Settings
    // }
}