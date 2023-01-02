using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [Header("Main Objects")]
    [SerializeField] GameObject profileCard;
    [SerializeField] GameObject nodeToInstantiate;
    [SerializeField] Transform nodeTree;

    [Header("Other Fields")]
    [SerializeField] string relationShip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void OnClickCreateNode(){

//Instantiate New Node Object.
var newNode = Instantiate(nodeToInstantiate, transform.position, Quaternion.identity);
newNode.transform.SetParent(nodeTree);

//Link that node child to the nodes list.


//Assign The RelationShip of that new node.


}
    private void OnMouseDown() {
        Debug.Log("Clicked on Node!" + gameObject.name);
        bool isActive = false;
        if(isActive == false){

profileCard.SetActive(true);
        }
        if(isActive == true){
            profileCard.SetActive(false);
        }
        isActive = true;
       // profileCard.transform.position = this.transform.position;

        //Should Show The Panel of Users. (Animation desired)
    }
}
