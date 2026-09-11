using UnityEngine;

namespace LevelDesign
{
    public class WIN : MonoBehaviour
    {
        public GameObject WInScreen;
        void start()
        {
            WInScreen.SetActive (false);
        }
        void OnTriggerEnter(Collider coillsion)
        {
            WInScreen.SetActive(true);
            Debug.Log("I winnnnnn");
        }
    }
}
