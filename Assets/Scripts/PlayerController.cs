using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float playerSpeed = 5.0f;

	// Update is called once per frame
	void Update () {
        // Make a Vector2 of the players current Position
        Vector2 playerPos = gameObject.transform.position;

        // Check which key is pressed and move in the direction
        if (Input.GetKey("a")) { playerPos.x -= playerSpeed * Time.deltaTime; }
        if (Input.GetKey("d")) { playerPos.x += playerSpeed * Time.deltaTime; }
        if (Input.GetKey("w")) { playerPos.y += playerSpeed * Time.deltaTime; }
        if (Input.GetKey("s")) { playerPos.y -= playerSpeed * Time.deltaTime; }

        // Update the players position
        gameObject.transform.position = playerPos;
    }
}
