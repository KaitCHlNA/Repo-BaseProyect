using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    
    //cámaras
    public GameObject camRE;
    public GameObject camThirdP;
    //public GameObject camFirstP;

    void Start()
    {
        Debug.Log("Hi there, to change the camera view press P");
    }
    
    void Update()
    {
        Movement();
        ChangeCams();
        //CamsIf();
    }

    void Movement()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horMove,0,verMove) * playerSpeed * Time.deltaTime);
    }

    void ToggleCams()
    {
        if (camRE.activeInHierarchy)
        {
            camRE.SetActive(false);
            camThirdP.SetActive(true);
        }
        else
        {
            camRE.SetActive(true);
            camThirdP.SetActive(false);
        }
    }

    void ChangeCams()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleCams();
        }
    }
    
    /*
    void CamsIf()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            camRE.SetActive(true);
            camThirdP.SetActive(false);
            camFirstP.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            camRE.SetActive(false);
            camThirdP.SetActive(true);
            camFirstP.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            camRE.SetActive(false);
            camThirdP.SetActive(false);
            camFirstP.SetActive(true);
        }
    } --> Nota, esto no es cómodo, implementar switch.
    */
}
