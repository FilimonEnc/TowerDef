using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public Color notEnoughMoneyColor;
    public Color hoverColor;
    public Vector3 positionOffSet;
    [Header("Optional")]
    public GameObject turret;

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

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Нельзя ставить");
            return;
        }

        
        buildManager.BuildTurretOn(this);


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
