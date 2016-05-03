using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
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

        if (Input.GetKey(KeyCode.Escape))
        {
            GoToMenu();
        }

    }


    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void configureDisplayItem1()
    {
        itemDisplayCanvas.gameObject.SetActive(true);

        itemName.text = "SENHA";
        itemDescricao.text = "Jogadores devem encontrar a palavra passe para ganhar o desafio, a palavra passe será SAUDE";
        itemRegras.text = "Regras\n1: Devem ser imprimidos, pelo menos, dez (10) cartões. Destes, metade serão alimentos saudáveis e a outra não saudáveis.\n"  +
            "2: Os cartões de alimentos saudáveis e não saudáveis devem ser espalhados no ambiente distributivamente\n" +
            "3: Os jogadores devem procurar os cartões, escaneá-los e levar apenas os alimentos saudáveis ao jogador guia\n" +
            "4: Recomenda-se a cronometragem de tempo para a atividade\n" +
            "5: O critério de vitória é achar a palavra passe\n";

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

    public void backToMain()
    {
        itemDisplayCanvas.gameObject.SetActive(false);
        mainCanvas.gameObject.SetActive(true);
    }
}
