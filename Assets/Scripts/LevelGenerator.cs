using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject[] platformPrefabs;
	public Transform player;
	public GameObject platformGenerationPoint;

	public float levelWidth = 3f;		// how far on x the platform can spawn
	public float minY = .2f;            // closest distance a platform can spwan
	public float maxY = 1.5f;           // max distance a platform can spwan

	Vector3 platformSpawnPosition;

	private void Start()
	{
		// Start spawning at the player
		platformSpawnPosition = new Vector3(player.position.x, player.position.y, player.position.z);
	}


	private void Update()
	{
		// Only spawn platforms inside the range.
		if ((platformSpawnPosition.y < platformGenerationPoint.transform.position.y))
		{
			platformSpawnPosition.y += Random.Range(minY, maxY);
			platformSpawnPosition.x = Random.Range(-levelWidth, levelWidth);
			GameObject platformprefab = GetPlatformPrefab();

			RenderPlatform(platformprefab, platformSpawnPosition);
		}
	}

	GameObject GetPlatformPrefab()
	{
		// TODO - Have a random distribution of platforms. Random.uniform()
		return platformPrefabs[Random.Range(0, platformPrefabs.Length)];
	}

	void RenderPlatform(GameObject platformPrefab, Vector3 spwanPos)
	{
		Instantiate(platformPrefab, spwanPos, Quaternion.identity);
	}

	void DestoryOldPlatforms()
	{
		// TODO - Think if I can destory/generate all platforms in here instead of on each platform.
		// Maybe be more optimised.
	}

}
