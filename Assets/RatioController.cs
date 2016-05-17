using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RatioController : MonoBehaviour
{

    private Text ratio;

	// Use this for initialization
	void Start ()
	{
	    ratio = this.transform.gameObject.GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Up()
    {
        int result;
        bool parse = Int32.TryParse(ratio.text, out result);
        result++;
        if (parse)
        {
            ratio.text = result.ToString();
        }
    }

    public void Down()
    {
        int result;
        bool parse = Int32.TryParse(ratio.text, out result);
        result--;
        if (parse)
        {
            ratio.text = result.ToString();
        }
    }
}
