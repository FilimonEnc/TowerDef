using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one buildmanager на сцене");
        }
        instance = this;

    }


    public GameObject standardTurretPrefab;
    public GameObject AnotherdTurrelPrefab;

    public TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }





    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Бомж");
        }
        else
        {
            PlayerStats.Money -= turretToBuild.cost;
            GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
            node.turret = turret;
            Debug.Log("Дело сделано, осталось грошей:" + PlayerStats.Money);
        }
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
       
    }
}

