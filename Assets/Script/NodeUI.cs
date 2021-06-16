using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
   private Node target;
   public GameObject ui;
   public Text upgradeCost;
   public Button upgradeButton;
   public Text sellCost;
   public void SetTarget(Node _target)
   {
      target = _target;
      transform.position = target.GetBuildPosition();
      
      if (!target.isUpgraded)
      {
         sellCost.text = target.turretBlueprint.sellCost.ToString();
         upgradeCost.text = target.turretBlueprint.upgradeCost.ToString();
         upgradeButton.interactable = true;
      }
      else
      {
         sellCost.text = target.turretBlueprint.sellCost.ToString();
         upgradeCost.text = "Макс";
         upgradeButton.interactable = false;
      }
   
      ui.SetActive(true);
   }

   public void Hide()
   {
      ui.SetActive(false);
   }

   public void Upgrade()
   {
      target.UpgradeTurret();
      BuildManager.instance.DeselectNode();
      
   }

   public void Sell()
   {
      target.SellTurret();
      BuildManager.instance.DeselectNode();
   }
}
