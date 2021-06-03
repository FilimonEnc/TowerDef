using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 positionOffSet;

    private Renderer rend;

    private Color startColor;


    BuildManager buildManager;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (turret != null)
        {
            Debug.Log("Нельзя ставить");
            return;
        }

        //ставить туррели
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);


    }
    public void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
        Debug.Log("Навел");
    }
    
    
    public void OnMouseExit()
    {
        rend.material.color = startColor;
        Debug.Log("убрал");
    }

}
