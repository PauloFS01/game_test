using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody;

    // first valiables test
    // int numberHere = 3;
    // string stringHere = "This is a string";
    // float floaHere = 6.345f;

    // Start is called before the first frame update
    void Start()
    {
        // PrintToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        MovingCube();
        OutOfBounds();
             
    }

    public string PrintFromOutSide(){
        return "This is the real life ?";
    }

    private void MovingCube(){
        // first iput buttons
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            myRigidBody.velocity = new Vector2(0f, 10f);
            // print("up");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            myRigidBody.velocity = new Vector2(0f, -10f);
            // print("Down");
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            myRigidBody.velocity = new Vector2(-10f, 0f);
            // print("Lefth");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            myRigidBody.velocity = new Vector2(10f, 0f);
            // print("Right");
        }         
    }

    private void OutOfBounds(){
        //area bounds limits
        if(transform.position.x > 10){
            print("Out of bounds!");
        }
        if(transform.position.x < -10){
            print("Out of bounds!");
        }
        if(transform.position.y > 4.5){
            print("Out of bounds!");
        }          
    }

    private void PrintToConsole(int numberHere, string stringHere, float floaHere){
        //first message test
        Debug.Log("That's first print of this project!");
        Debug.LogWarning("That's first warning of this project!");
        Debug.LogError("That's first error of this project!");

        Debug.Log("That's first integer of: " + numberHere +", this project!");
        Debug.Log("That's first string: " + stringHere + ", of this project!");
        Debug.Log("That's first float: " + floaHere + ", of this project!");        
    }
}
