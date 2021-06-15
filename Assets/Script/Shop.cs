
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint anotherTurret;
    public TurretBlueprint laserTurret;

    BuildManager buildManager;


    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("������� ������ ����������");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectBigBob()
    {
        Debug.Log("������� ���");
        buildManager.SelectTurretToBuild(anotherTurret);
    }
    public void SelectLaserTurret()
    {
        Debug.Log("�����");
        buildManager.SelectTurretToBuild(laserTurret);
    }
}
