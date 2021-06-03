
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("������� ������ ����������");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseBigBob()
    {
        Debug.Log("������� ���");
        buildManager.SetTurretToBuild(buildManager.AnotherdTurrelPrefab);
    }
    public void PurchasePiuPiu()
    {
        Debug.Log("������");
        buildManager.SetTurretToBuild(buildManager.AnotherdTurrelPrefab);
    }
}
