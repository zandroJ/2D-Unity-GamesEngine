using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
public float speed; // player speed
private Rigidbody2D rb; //physics for moving
private Vector2 playerDirection; // for player input movement


void Start(){
rb = GetComponent<Rigidbody2D>();
}




void Update(){ //detection and inputs goes here.
float directionX = Input.GetAxisRaw("Horizontal")* speed;;
float directionY = Input.GetAxisRaw("Vertical") * speed;
playerDirection =  new Vector2(directionX, directionY).normalized;
transform.position += new Vector3(directionX, directionY, 0f) * Time.deltaTime;
}

void FixedUpdate(){ //everything that happens in rigidbody goes here.
rb.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
}
}