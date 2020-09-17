using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
	public GameObject myPrefab;
	private List<GameObject> bricks = new List<GameObject>();
	public static int tilesDown = 5, tilesAcross = 12;
	public int TILEWIDTH  = 5, TILEHEIGHT = 2,
	           offset = 0,
	           startX = -120, startY = 50;

    void Start() {
      createTiles(tilesDown, tilesAcross, offset, startX, startY);
    }

    public void createTiles(int tilesDown, int tilesAcross, int offset, int startX, int startY) {
			for (int y = 0; y < tilesDown; y++) {
				for(int x = 0; x < tilesAcross; x++) {
					GameObject brick = Instantiate(myPrefab, new Vector2(x*TILEWIDTH + offset + startX, y*TILEHEIGHT + offset + startY), Quaternion.identity);
					bricks.Add(brick);
				}
			}
		}

    void Update() {}
}
