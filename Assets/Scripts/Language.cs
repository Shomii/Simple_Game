using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;
using System.IO;
using System.Text;

[Serializable]
public class Language : MonoBehaviour
{

	public static string code;
	public string name;
	public string description;

	void Start ()
	{

	}

	void Update ()
	{
		
	}

	public void ReadingXML ()
	{

		string path = Path.Combine (Application.dataPath, "StreamingAssets/configShomi.xml");
		XmlDocument xmldoc = new XmlDocument ();
		xmldoc.Load (path);

		XmlNodeList listLang = xmldoc.SelectNodes ("/GameData/languages/Language [@ type='Language']");

		if (code == "en") {
			for (int i = 0; i < listLang.Count; i++) {
				XmlNodeList listLang2 = listLang [0].ChildNodes;
				for (int z = 0; z < listLang2.Count; z++) {
					name = listLang2 [1].InnerText;
					description = listLang2 [2].InnerText;
				}
			}
		} else if (code == "rs") {
			for (int i = 0; i < listLang.Count; i++) {
				XmlNodeList listLang2 = listLang [1].ChildNodes;
				for (int z = 0; z < listLang2.Count; z++) {
					name = listLang2 [1].InnerText;
					description = listLang2 [2].InnerText;
				}
			}
		} else {
			Debug.Log ("NEMA TAKVOG JEZIKA");
		}
	}
}
