using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManagerWorld : MonoBehaviour
{
    public Transform rightHandTransform; // Right hand reference
    public Transform leftHandTransform;  // Left hand reference
    private CollisionScoring collisionScoring;
    public void ResetWorld()
    {
        // Exit the game
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "GrabVolumeBig" || other.name == "GrabVolumeSmall") {
            ResetWorld();
        }
        
    }
}
