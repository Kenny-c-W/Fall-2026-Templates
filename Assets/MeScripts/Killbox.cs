using UnityEngine;

namespace LevelDesign.Systems
{   
    public class Killbox : MonoBehaviour
    {
        public GameObject Player;
       //ublic PlayerStateMachine PSM;
        public Health Current;
        void Start()
        {
            //   PSM = GetComponent<PlayerStateMachine>();
            Current = GetComponent<Health>();
        }
        void OnTriggerEnter(Collider collsion)
        {
            Debug.Log("shit");
            //PSM.isDead = true;
            if (collsion.CompareTag ("player"))
            {
                Current.Fell();
                //PSM.isDead = true;
                Debug.Log("I fell");
            }
        }
    }
}
