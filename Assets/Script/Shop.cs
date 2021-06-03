
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
        Debug.Log("Обычная турель поставлена");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseBigBob()
    {
        Debug.Log("Большой боб");
        buildManager.SetTurretToBuild(buildManager.AnotherdTurrelPrefab);
    }
    public void PurchasePiuPiu()
    {
        Debug.Log("Пиупиу");
        buildManager.SetTurretToBuild(buildManager.AnotherdTurrelPrefab);
    }
}
