using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 positionOffSet;

    private Renderer rend;

    private Color startColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    private void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("������ �������");
            return;
        }

        //������� �������
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);


    }
    public void OnMouseEnter()
    {
      rend.material.color = hoverColor;
        Debug.Log("�����");
    }
    
    
    public void OnMouseExit()
    {
        rend.material.color = startColor;
        Debug.Log("�����");
    }

}
