using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Image pewterBar;
    public Image energyBar;
    public Text killsText;
    public Text lossesText;

    public Button buildTowerButton;
    public Button buildTankButton;
    public Button buildAircraftButton;
    public Button buildBuilderButton;

    public Button fireAtWillButton;
    public Button holdPositionButton;
    public Button reclaimButton;
    public Button repairButton;
    public Button captureButton;
    public Button moveButton;
    public Button stopButton;
    public Button guardButton;
    public Button patrolButton;
    public Button attackButton;

    void Start()
    {
        pewterBar.fillAmount = 1f;
        energyBar.fillAmount = 1f;
        killsText.text = "0";
        lossesText.text = "0";
    }

    void Update()
    {
        pewterBar.fillAmount = Player.GetPewterPercentage();
        energyBar.fillAmount = Player.GetEnergyPercentage();
        killsText.text = Player.GetKills().ToString();
        lossesText.text = Player.GetLosses().ToString();
    }

    public void OnBuildTowerButtonClick()
    {
        Player.BuildTower();
    }

    public void OnBuildTankButtonClick()
    {
        Player.BuildTank();
    }

    public void OnBuildAircraftButtonClick()
    {
        Player.BuildAircraft();
    }

    public void OnBuildBuilderButtonClick()
    {
        Player.BuildBuilder();
    }

    public void OnFireAtWillButtonClick()
    {
        Player.GiveOrder(Order.FireAtWill);
    }

    public void OnHoldPositionButtonClick()
    {
        Player.GiveOrder(Order.HoldPosition);
    }

    public void OnReclaimButtonClick()
    {
        Player.GiveOrder(Order.Reclaim);
    }

    public void OnRepairButtonClick()
    {
        Player.GiveOrder(Order.Repair);
    }

    public void OnCaptureButtonClick()
    {
        Player.GiveOrder(Order.Capture);
    }

    public void OnMoveButtonClick()
    {
        Player.GiveOrder(Order.Move);
    }

    public void OnStopButtonClick()
    {
        Player.GiveOrder(Order.Stop);
    }

    public void OnGuardButtonClick()
    {
        Player.GiveOrder(Order.Guard);
    }

    public void OnPatrolButtonClick()
    {
        Player.GiveOrder(Order.Patrol);
    }

    public void OnAttackButtonClick()
    {
        Player.GiveOrder(Order.Attack);
    }
}
