using UnityEngine;

public class chickenMove : MonoBehaviour
{
    public float speed;
    public float respawnChicken;
    public float height;
    private bool _isLook;

    // Update is called once per frame
    void Update()
    {
        if (_isLook)
        {
            //se a galinha tiver olhando ao redor
        }else
        {
            //se ela não estiver olhando pode andar
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        
    }

    public void lookAround(){
        _isLook = true;
    }
        
    public void allClear(){
        _isLook = false;        
    }
        
    void OnTriggerEnter2D(Collider2D colisor){
        
        if (colisor.gameObject.CompareTag("limitWall")){ //se encostar em objeto com a tag limitWall
            //Destroy(gameObject); //se destroi     
            
            this.transform.position = new Vector3( respawnChicken, Random.Range(-height,height),0);

        

        }
       
    }
    
}
