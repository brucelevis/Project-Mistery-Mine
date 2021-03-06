﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Объект, ответственный за управление игрой
/// </summary>
public class GameController : MonoBehaviour
{

    #region fields

    protected DialogWindowScript dialogWindow;

    #endregion //fields

    protected void Awake()
    {
        Initialize();
    }

    protected void Initialize()
    {
        Transform interfaceWindows = SpecialFunctions.gameInterface.transform;
        dialogWindow = interfaceWindows.GetComponentInChildren<DialogWindowScript>();
    }

    public static void GoToTheNextLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    ///  Начать диалог
    /// </summary>
    public void StartDialog(NPCController npc, Dialog dialog)
    {
        Transform player = SpecialFunctions.player.transform;
        dialogWindow.BeginDialog(player, npc, dialog);
    }

}
