using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemDisplayController : MonoBehaviour {

    #region Public variables

    //Item Texts
    public Text itemName;
    public Text itemDescricao;
    public Text itemRegras;


    //Item Images
    public Image itemCard1;
    public Image itemCard2;

    public Canvas mainCanvas;
    public Canvas itemDisplayCanvas;
    #endregion

    private float time = 0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time >= 1f)
        {
            alternateImages();
            time = 0f;
        }
	
	}

    public void configureDisplayItem1()
    {
        itemDisplayCanvas.gameObject.SetActive(true);

        itemName.text = "AquaGame";
        itemDescricao.text = "Exemplo de descriçao foo bar lore";
        itemRegras.text = "Regras\n1: askdkasd\n 2: ajsdkajsd\n";

        mainCanvas.gameObject.SetActive(false);
    }

    void alternateImages()
    {
        if (itemCard1.gameObject.activeSelf) {
            itemCard1.gameObject.SetActive(false);
            itemCard2.gameObject.SetActive(true);
        }
        else
        {
            itemCard2.gameObject.SetActive(false);
            itemCard1.gameObject.SetActive(true);
        }
    }
}
