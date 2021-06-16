using Script;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public Color notEnoughMoneyColor;
    public Color hoverColor;
    public Vector3 positionOffSet;
    [HideInInspector] public GameObject turret;
    [HideInInspector] public TurretBlueprint turretBlueprint;
    [HideInInspector] public bool isUpgraded = false;
    
    private Renderer rend;

    private Color startColor;
    

    BuildManager buildManager;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffSet;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (turret != null)
        {
            buildManager.SelectNode(this);
            return;
        }
        if (!buildManager.CanBuild) 
            return;
        
        

        BuildTurret(buildManager.GetTurretToBuild());
    }

    void BuildTurret(TurretBlueprint blueprint)
    {
        if (PlayerStats.Money < blueprint.cost)
        {
            Debug.Log("Бомж");
            return;
        }
        
        PlayerStats.Money -= blueprint.cost;
        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprint = blueprint;
        
        GameObject effect = (GameObject) Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
           
        
    }

    public void UpgradeTurret()
    {
        if (PlayerStats.Money < turretBlueprint.upgradeCost)
        {
            Debug.Log("Бомж для апдейта");
            return;
        }
        
        PlayerStats.Money -= turretBlueprint.upgradeCost;
        
        Destroy(turret);
        GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

       
        
        GameObject effect = (GameObject) Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        isUpgraded = true;
    }

    public void SellTurret()
    {
        PlayerStats.Money += turretBlueprint.sellCost;
        GameObject effect = (GameObject) Instantiate(buildManager.destroyeffect, GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(turret);
        turretBlueprint = null;
    }
    
    public void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {   return;}
        if (!buildManager.CanBuild)
        {  return;}

        rend.material.color = buildManager.HasMoney ? hoverColor : notEnoughMoneyColor;



    }
    
    
    public void OnMouseExit()
    {
        rend.material.color = startColor;
       
    }

}
