using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{

    public CollisionScoring collisionScoring;
    public void ResetScore()
    {
        // Load the game scene or start the game
        collisionScoring.ResetScore();

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "GrabVolumeBig" || other.name == "GrabVolumeSmall")
        {
            ResetScore();
        }

    }
}
