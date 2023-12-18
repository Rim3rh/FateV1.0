using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEntryCollider : MonoBehaviour
{
    [SerializeField] Transform pos2;
    [SerializeField] CameraManager camManager;

    [SerializeField] GameObject bossFight;
    private BossUiManager uiManager;
    private BossFightController bossFightController;


    private void Awake()
    {
        uiManager = bossFight.GetComponent<BossUiManager>();
        bossFightController = bossFight.GetComponent<BossFightController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            TpPlayerIntoBossFight(other);

        }
    }


    private void TpPlayerIntoBossFight(Collider other)
    {
        camManager.DisableOldCamera(GameManager.Instance.currentRoom);
        GameManager.Instance.currentRoom = GameManager.Rooms.Room_1_7;
        camManager.SetNewCamera(GameManager.Instance.currentRoom);


        GameManager.Instance.inBelzegorFight = true;
        other.transform.position = pos2.transform.position;
        uiManager.EnableHealth();
        Invoke(nameof(StartBossFight), 2f);
    }


    private void StartBossFight()
    {
        bossFightController.GetRandomBossAttack();

    }
}
