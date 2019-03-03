using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;
using System.IO;
using System.Text;

[Serializable]
public class Translation : MonoBehaviour
{

	public string languageCode;
	public string key;
	public static string content = "Enter Game";
	public static string content2 = "Highscore";
	public static string content3 = "Enter Name...";
	public static string content4 = "Reset Highscore";
	public static string content5 = "Quit";
	public static string content6 = "HIGHSCORES";
	public static string content7 = "NAME";
	public static string content8 = "SCORE";
	public static string content9 = "Back to main menu";
	public static string content10 = "Score: ";
	public static string content11 = "Player: ";
	public static string content12 = "Shield will last 5 seconds";
	public static string content13 = "RESTART";
	public static string content14 = "MAIN MENU";
	public static string content15 = "Your score was";
	public static string content16 = "Your best score";
	public static string content17 = "Keep playing";


	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

	public void ReadTranslation ()
	{
		string path = Path.Combine (Application.dataPath, "StreamingAssets/configShomi.xml");
		XmlDocument xmldoc = new XmlDocument ();
		xmldoc.Load (path);

		XmlNodeList listTrans = xmldoc.SelectNodes ("/GameData/translations/Translation [@ type='Translation']");
		languageCode = Language.code;


		if (languageCode == "en") {
			for (int i = 0; i < listTrans.Count; i++) {
				
				XmlNodeList listTrans2 = listTrans [0].ChildNodes;
				for (int z = 0; z < listTrans2.Count; z++) {
					key = listTrans2 [1].InnerText;
					content = listTrans2 [2].InnerText;
				}

				XmlNodeList listTrans3 = listTrans [2].ChildNodes;
				for (int z = 0; z < listTrans3.Count; z++) {
					key = listTrans3 [1].InnerText;
					content2 = listTrans3 [2].InnerText;
				}

				XmlNodeList listTrans4 = listTrans [4].ChildNodes;
				for (int z = 0; z < listTrans4.Count; z++) {
					key = listTrans4 [1].InnerText;
					content3 = listTrans4 [2].InnerText;
				}

				XmlNodeList listTrans5 = listTrans [6].ChildNodes;
				for (int z = 0; z < listTrans5.Count; z++) {
					key = listTrans5 [1].InnerText;
					content4 = listTrans5 [2].InnerText;
				}

				XmlNodeList listTrans6 = listTrans [8].ChildNodes;
				for (int z = 0; z < listTrans6.Count; z++) {
					key = listTrans6 [1].InnerText;
					content5 = listTrans6 [2].InnerText;
				}

				XmlNodeList listTrans7 = listTrans [10].ChildNodes;
				for (int z = 0; z < listTrans7.Count; z++) {
					key = listTrans7 [1].InnerText;
					content6 = listTrans7 [2].InnerText;
				}

				XmlNodeList listTrans8 = listTrans [12].ChildNodes;
				for (int z = 0; z < listTrans8.Count; z++) {
					key = listTrans8 [1].InnerText;
					content7 = listTrans8 [2].InnerText;
				}

				XmlNodeList listTrans9 = listTrans [14].ChildNodes;
				for (int z = 0; z < listTrans9.Count; z++) {
					key = listTrans9 [1].InnerText;
					content8 = listTrans9 [2].InnerText;
				}

				XmlNodeList listTrans10 = listTrans [16].ChildNodes;
				for (int z = 0; z < listTrans10.Count; z++) {
					key = listTrans10 [1].InnerText;
					content9 = listTrans10 [2].InnerText;
				}

				XmlNodeList listTrans11 = listTrans [18].ChildNodes;
				for (int z = 0; z < listTrans11.Count; z++) {
					key = listTrans11 [1].InnerText;
					content10 = listTrans11 [2].InnerText;
				}

				XmlNodeList listTrans12 = listTrans [20].ChildNodes;
				for (int z = 0; z < listTrans12.Count; z++) {
					key = listTrans12 [1].InnerText;
					content11 = listTrans12 [2].InnerText;
				}

				XmlNodeList listTrans13 = listTrans [22].ChildNodes;
				for (int z = 0; z < listTrans13.Count; z++) {
					key = listTrans13 [1].InnerText;
					content12 = listTrans13 [2].InnerText;
				}

				XmlNodeList listTrans14 = listTrans [24].ChildNodes;
				for (int z = 0; z < listTrans14.Count; z++) {
					key = listTrans14 [1].InnerText;
					content13 = listTrans14 [2].InnerText;
				}

				XmlNodeList listTrans15 = listTrans [26].ChildNodes;
				for (int z = 0; z < listTrans15.Count; z++) {
					key = listTrans15 [1].InnerText;
					content14 = listTrans15 [2].InnerText;
				}

				XmlNodeList listTrans16 = listTrans [28].ChildNodes;
				for (int z = 0; z < listTrans16.Count; z++) {
					key = listTrans16 [1].InnerText;
					content15 = listTrans16 [2].InnerText;
				}

				XmlNodeList listTrans17 = listTrans [30].ChildNodes;
				for (int z = 0; z < listTrans17.Count; z++) {
					key = listTrans17 [1].InnerText;
					content16 = listTrans17 [2].InnerText;
				}

				XmlNodeList listTrans18 = listTrans [32].ChildNodes;
				for (int z = 0; z < listTrans18.Count; z++) {
					key = listTrans18 [1].InnerText;
					content17 = listTrans18 [2].InnerText;
				}
			}
		} else if (languageCode == "rs") {
			for (int i = 0; i < listTrans.Count; i++) {
				XmlNodeList listTrans2 = listTrans [1].ChildNodes;
				for (int z = 0; z < listTrans2.Count; z++) {
					key = listTrans2 [1].InnerText;
					content = listTrans2 [2].InnerText;
				}

				XmlNodeList listTrans3 = listTrans [3].ChildNodes;
				for (int z = 0; z < listTrans3.Count; z++) {
					key = listTrans3 [1].InnerText;
					content2 = listTrans3 [2].InnerText;
				}

				XmlNodeList listTrans4 = listTrans [5].ChildNodes;
				for (int z = 0; z < listTrans4.Count; z++) {
					key = listTrans4 [1].InnerText;
					content3 = listTrans4 [2].InnerText;
				}

				XmlNodeList listTrans5 = listTrans [7].ChildNodes;
				for (int z = 0; z < listTrans5.Count; z++) {
					key = listTrans5 [1].InnerText;
					content4 = listTrans5 [2].InnerText;
				}

				XmlNodeList listTrans6 = listTrans [9].ChildNodes;
				for (int z = 0; z < listTrans6.Count; z++) {
					key = listTrans6 [1].InnerText;
					content5 = listTrans6 [2].InnerText;
				}

				XmlNodeList listTrans7 = listTrans [11].ChildNodes;
				for (int z = 0; z < listTrans7.Count; z++) {
					key = listTrans7 [1].InnerText;
					content6 = listTrans7 [2].InnerText;
				}

				XmlNodeList listTrans8 = listTrans [13].ChildNodes;
				for (int z = 0; z < listTrans8.Count; z++) {
					key = listTrans8 [1].InnerText;
					content7 = listTrans8 [2].InnerText;
				}

				XmlNodeList listTrans9 = listTrans [15].ChildNodes;
				for (int z = 0; z < listTrans9.Count; z++) {
					key = listTrans9 [1].InnerText;
					content8 = listTrans9 [2].InnerText;
				}

				XmlNodeList listTrans10 = listTrans [17].ChildNodes;
				for (int z = 0; z < listTrans10.Count; z++) {
					key = listTrans10 [1].InnerText;
					content9 = listTrans10 [2].InnerText;
				}

				XmlNodeList listTrans11 = listTrans [19].ChildNodes;
				for (int z = 0; z < listTrans11.Count; z++) {
					key = listTrans11 [1].InnerText;
					content10 = listTrans11 [2].InnerText;
				}

				XmlNodeList listTrans12 = listTrans [21].ChildNodes;
				for (int z = 0; z < listTrans12.Count; z++) {
					key = listTrans12 [1].InnerText;
					content11 = listTrans12 [2].InnerText;
				}

				XmlNodeList listTrans13 = listTrans [23].ChildNodes;
				for (int z = 0; z < listTrans13.Count; z++) {
					key = listTrans13 [1].InnerText;
					content12 = listTrans13 [2].InnerText;
				}

				XmlNodeList listTrans14 = listTrans [25].ChildNodes;
				for (int z = 0; z < listTrans14.Count; z++) {
					key = listTrans14 [1].InnerText;
					content13 = listTrans14 [2].InnerText;
				}

				XmlNodeList listTrans15 = listTrans [27].ChildNodes;
				for (int z = 0; z < listTrans15.Count; z++) {
					key = listTrans15 [1].InnerText;
					content14 = listTrans15 [2].InnerText;
				}

				XmlNodeList listTrans16 = listTrans [29].ChildNodes;
				for (int z = 0; z < listTrans16.Count; z++) {
					key = listTrans16 [1].InnerText;
					content15 = listTrans16 [2].InnerText;
				}

				XmlNodeList listTrans17 = listTrans [31].ChildNodes;
				for (int z = 0; z < listTrans17.Count; z++) {
					key = listTrans17 [1].InnerText;
					content16 = listTrans17 [2].InnerText;
				}

				XmlNodeList listTrans18 = listTrans [33].ChildNodes;
				for (int z = 0; z < listTrans18.Count; z++) {
					key = listTrans18 [1].InnerText;
					content17 = listTrans18 [2].InnerText;
				}
			}
		} else {
			Debug.Log ("The language you are trying to choose not exists");
		}
	}

}
