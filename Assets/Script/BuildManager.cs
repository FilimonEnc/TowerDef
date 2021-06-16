using Script;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public NodeUI nodeUI;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one buildmanager на сцене");
        }
        instance = this;

    }



    public GameObject buildEffect;
    public GameObject destroyeffect;
    
    
    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public bool CanBuild => turretToBuild != null;
    public bool HasMoney => PlayerStats.Money >= turretToBuild.cost;


    

    public void SelectNode(Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }
        
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;

        nodeUI.Hide();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}

