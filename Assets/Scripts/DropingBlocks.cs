using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropingBlocks : MonoBehaviour
{

	public GameObject[] FirstBlocks;
	public GameObject[] SecondBlocks;
	public GameObject[] ThirdBlocks;
	public MainBlock scoreMain;
	private GameObject block;
	private Block_1 block_1;
	private Block_2 block_2;
	private Block_3 block_3;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject rewordBlock1;
	public GameObject rewordBlock2;
	public GameObject rewordBlock3;
	public GameObject shieldBlock;
	bool isStarted2 = false;
	bool isStarted3 = false;
	bool isStartedReword10 = false;
	bool isStartedReword20 = false;
	bool isStartedReword30 = false;
	bool isStartedShield = false;



	void Start ()
	{
		StartCoroutine (GetFirstBlockss ());
	}

	void Update ()
	{

		if (!isStarted2) {
			if (scoreMain.score > 20) {
				StartCoroutine (GetSecondBlockss ());
			}
		}
		if (!isStarted3) {
			if (scoreMain.score > 70) {
				StartCoroutine (GetThirdBlockss ());
			}
		}

		if (!isStartedReword10) {
			if (scoreMain.score > 30) {
				StartCoroutine (GetRewordBlockss_10Points ());
			}
		}
		if (!isStartedReword20) {
			if (scoreMain.score > 50) {
				StartCoroutine (GetRewordBlockss_20Points ());
			}
		}
		if (!isStartedReword30) {
			if (scoreMain.score > 100) {
				StartCoroutine (GetRewordBlockss_30Points ());
			}
		}
		if (!isStartedShield) {
			if (scoreMain.score > 50) {
				StartCoroutine (GetRewordBlockss_Shield ());
			}
		}
	}

	private void Awake ()
	{

	}

	public Block_1 Block1 ()
	{
		block1 = Instantiate<GameObject> (Resources.Load<GameObject> ("DropBlock_1"));
		
		block1.transform.SetParent (transform, false);
		return block1.GetComponent<Block_1> ();

	}

	public Block_2 Block2 ()
	{
		block2 = Instantiate<GameObject> (Resources.Load<GameObject> ("DropBlock_2"));
		
		block2.transform.SetParent (transform, false);
		return block2.GetComponent<Block_2> ();

	}

	public Block_3 Block3 ()
	{
		block3 = Instantiate<GameObject> (Resources.Load<GameObject> ("DropBlock_3"));
		
		block3.transform.SetParent (transform, false);
		return block3.GetComponent<Block_3> ();

	}

	public RewordBlock_1 RewordBlock1 ()
	{
		rewordBlock1 = Instantiate<GameObject> (Resources.Load<GameObject> ("RewordBlock_1"));

		rewordBlock1.transform.SetParent (transform, false);
		return rewordBlock1.GetComponent<RewordBlock_1> ();

	}

	public RewordBlock_2 RewordBlock2 ()
	{
		rewordBlock2 = Instantiate<GameObject> (Resources.Load<GameObject> ("RewordBlock_2"));

		rewordBlock2.transform.SetParent (transform, false);
		return rewordBlock2.GetComponent<RewordBlock_2> ();

	}

	public RewordBlock_3 RewordBlock3 ()
	{
		rewordBlock3 = Instantiate<GameObject> (Resources.Load<GameObject> ("RewordBlock_3"));

		rewordBlock3.transform.SetParent (transform, false);
		return rewordBlock3.GetComponent<RewordBlock_3> ();

	}

	public Shield ShieldBlock ()
	{
		shieldBlock = Instantiate<GameObject> (Resources.Load<GameObject> ("RewordBlock_shield"));

		shieldBlock.transform.SetParent (transform, false);
		return shieldBlock.GetComponent<Shield> ();

	}

	public IEnumerator GetFirstBlockss ()
	{

		while (true) {

			float PositionX = Random.Range (-421, 421);
			Quaternion q = Quaternion.identity;
			Vector3 location = new Vector3 (PositionX, 500f, 0f);

			Block_1 instBlocks = Block1 ();
		
			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;
			instBlocks.transform.rotation = q;

			yield return new WaitForSeconds (0.5f);
		}

	}

	public IEnumerator GetSecondBlockss ()
	{

		isStarted2 = true;
		while (true) {

			float PositionX = Random.Range (-421, 421);
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			Block_2 instBlocks = Block2 ();
		
			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (2f);
		}
	}

	public IEnumerator GetThirdBlockss ()
	{

		isStarted3 = true;
		while (true) {

			float PositionX = Random.Range (-421, 421);
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			Block_3 instBlocks = Block3 ();
		
			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (4f);
		}
	}

	public IEnumerator GetRewordBlockss_10Points ()
	{

		isStartedReword10 = true;
		while (true) {

			float PositionX = Random.Range (-421, 421);
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			RewordBlock_1 instBlocks = RewordBlock1 ();

			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (10f);
		}
	}

	public IEnumerator GetRewordBlockss_20Points ()
	{
		
		isStartedReword20 = true;
		while (true) {
			
			float PositionX = Random.Range (-421, 421);			
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			RewordBlock_2 instBlocks = RewordBlock2 ();

			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (10f);
		}	
	}

	public IEnumerator GetRewordBlockss_30Points ()
	{
		
		isStartedReword30 = true;
		while (true) {
			
			float PositionX = Random.Range (-421, 421);			
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			RewordBlock_3 instBlocks = RewordBlock3 ();

			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (10f);
		}	
	}

	public IEnumerator GetRewordBlockss_Shield ()
	{

		isStartedShield = true;
		while (true) {

			float PositionX = Random.Range (-421, 421);			
			Vector3 location = new Vector3 (PositionX, 500f, 0f);
			Shield instBlocks = ShieldBlock ();

			instBlocks.transform.SetParent (transform, false);
			instBlocks.transform.localPosition = location;

			yield return new WaitForSeconds (25f);
		}
	}
}
