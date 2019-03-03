using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Text;

public class ReadXML : MonoBehaviour
{

	private Translation translate;

	void Start ()
	{
		translate = GetComponent<Translation> ();
	}

	void Update ()
	{
		
	}

	private void ReadingXML ()
	{
		string path = Path.Combine (Application.dataPath, "StreamingAssets/configShomi.xml");
		XmlDocument xmldoc = new XmlDocument ();
		xmldoc.Load (path);

		XmlNodeList listLang = xmldoc.SelectNodes ("/GameData/languages/Language [@ type='Language']");
		XmlNodeList listTrans = xmldoc.SelectNodes ("/GameData/translations/Translation [@ type='Translation']");

		for (int i = 0; i < listLang.Count; i++) {
			XmlNodeList listLang2 = listLang [i].ChildNodes;
			for (int z = 0; z < listLang2.Count; z++) {
			}
		}

		for (int i = 0; i < listTrans.Count; i++) {
			XmlNodeList listTrans2 = listTrans [i].ChildNodes;
			for (int z = 0; z < listTrans2.Count; z++) {
				translate.languageCode = listTrans2 [0].InnerText;
				translate.key = listTrans2 [1].InnerText;
				Translation.content = listTrans2 [2].InnerText;

				//	Debug.Log (listTrans2 [z].InnerText);
			}
		}
	}

}
