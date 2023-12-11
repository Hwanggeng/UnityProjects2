using UnityEngine;
using UnityEngine.SceneManagement;



public class chararcterMovement : MonoBehaviour
{
    private Vector3 EndPos;
   
    private void Start() 
    {
        EndPos = new Vector3 (-8, 1, 0);
    }
   private void Update() 
    {
        //새로운 위치 = 현재위치 + (방향*속도)
        //transform.position = transform.position + (new Vector3(0, -1, 0) * 1);
        if(transform.position.y > EndPos.y)
        {
            transform.position += Vector3.down * 1 * Time.deltaTime;
            
        }
        else
        {
            MoveRight();
        }
        //else if(transform.position == EndPos);
        //{
           // transform.position += Vector3.right * 1 * Time.deltaTime;
                
        //}
    
        
    }
    public void MoveRight()
    {
        if(transform.position.y <= 1)
            transform.position += Vector3.right * 2 * Time.deltaTime;

        if (transform.position.x > 10)
        {
            transform.position = new Vector3 (-10, 10, 0);
            SceneManager.LoadScene("thirdScene");
            Debug.Log("The End!");
            
        }
    
    }
}
