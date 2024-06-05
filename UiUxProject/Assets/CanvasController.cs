using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [Header("List Screen")]
    [SerializeField] List<Button> listButtons = new List<Button>();
    [SerializeField] GameObject listScreen;
    [SerializeField] GameObject xImage;
    [SerializeField] Button filterButton;

    [Header("Plant Screen")]
    [SerializeField] GameObject plantScreen;
    [SerializeField] Button plusButton;

    [Header("Popup")]
    [SerializeField] GameObject popupScreen;
    [SerializeField] Button babyPlantButton;
    [SerializeField] Button gardenButton;

    void Start()
    {
        listScreen.SetActive(true);
        plantScreen.SetActive(false);
        popupScreen.SetActive(false);

        foreach (var button in listButtons)
        {
            button.onClick.AddListener(HandleOnListButtonClick);
        }

        plusButton.onClick.AddListener(HandleOnPlusButtonClick);
        babyPlantButton.onClick.AddListener(HandleOnPopupButtonClick);
        gardenButton.onClick.AddListener(HandleOnPopupButtonClick);
        filterButton.onClick.AddListener(HandleOnFiltersButtonClick);
    }

    private void OnDestroy()
    {
        foreach (var button in listButtons)
        {
            button.onClick.RemoveListener(HandleOnListButtonClick);
        }

        plusButton.onClick.RemoveListener(HandleOnPlusButtonClick);
        babyPlantButton.onClick.RemoveListener(HandleOnPopupButtonClick);
        gardenButton.onClick.RemoveListener(HandleOnPopupButtonClick);
        filterButton.onClick.RemoveListener(HandleOnFiltersButtonClick);
    }

    private void HandleOnFiltersButtonClick()
    {
        xImage.SetActive(!xImage.activeSelf);
    }

    private void HandleOnListButtonClick()
    {
        listScreen.SetActive(false);
        plantScreen.SetActive(true);
    }

    private void HandleOnPlusButtonClick()
    {
        popupScreen.SetActive(true);
    }

    private void HandleOnPopupButtonClick()
    {
        listScreen.SetActive(true);
        popupScreen.SetActive(false);
        plantScreen.SetActive(false);
    }
}
