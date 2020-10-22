using System.Collections;
using UnityEngine;
public class gameFlow : MonoBehaviour
{
    public Transform[] Tiles;
    private Vector3 nextTileSpawn;
    public Transform Pumpkin;
    private Vector3 nextPumpkinSpawn;
    private int randX;
    public Transform Grave;
    private Vector3 nextGraveSpawn;
    public Transform GraveTall;
    private Vector3 nextGraveTallSpawn;
    public Transform Coffin;
    private Vector3 nextCoffinSpawn;
    private int randChoice;
    public static int totalCandy = 0;
    public Transform Candy;

    void Start()
    {
       
        nextTileSpawn.z = 30;
        StartCoroutine(spawnTile());

    }

    IEnumerator spawnTile()
    {

        yield return new WaitForSeconds(1);
        randX = Random.Range(-1, 2);
        nextPumpkinSpawn = nextTileSpawn;
        nextPumpkinSpawn.x = randX;
        int tileIndex = Random.Range(0, Tiles.Length);
        Transform tile = Tiles[tileIndex];
        Instantiate(tile, nextTileSpawn, tile.rotation);
        Instantiate(Pumpkin, nextPumpkinSpawn, Pumpkin.rotation);
        nextTileSpawn.z += 3;
        randX = Random.Range(-1, 2);
        nextGraveSpawn.z = nextTileSpawn.z;
        nextGraveSpawn.x = randX;
        Instantiate(tile, nextTileSpawn, tile.rotation);
        Instantiate(Grave, nextGraveSpawn, Grave.rotation);


        if (randX == 0)
        {
            randX = 1;
        }
        else
        if (randX == 1)
        {
            randX = -1;
        }
        else
        {
            randX = 0;
        }
        randChoice = Random.Range(0, 3);
        if (randChoice == 0)
        {
            nextGraveTallSpawn.z = nextTileSpawn.z;
            nextGraveTallSpawn.x = randX;
            Instantiate(GraveTall, nextGraveTallSpawn, GraveTall.rotation);
        }
        else
        if (randChoice == 1)
        {
            nextCoffinSpawn.z = nextTileSpawn.z;
            nextCoffinSpawn.x = randX;
            Instantiate(Coffin, nextCoffinSpawn, Candy.rotation);
        }
        else
        {
            nextCoffinSpawn.z = nextTileSpawn.z;
            nextCoffinSpawn.x = randX;
            Instantiate(Candy, nextCoffinSpawn, Coffin.rotation);
        }

        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());

    }
}
