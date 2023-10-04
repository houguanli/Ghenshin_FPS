using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;
using Unity.FPS.UI;
using UnityEngine;
using UnityEngine.UI;

public class Player_Shield_Bar : MonoBehaviour
{
    [Tooltip("Image component dispplaying current health")]
    public Image ShieldFillImage;

    Damageable m_PlayerDamageable;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCharacterController playerCharacterController =
    GameObject.FindObjectOfType<PlayerCharacterController>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerCharacterController, Player_Shield_Bar>(
            playerCharacterController, this);

        m_PlayerDamageable = playerCharacterController.GetComponent<Damageable>();
        DebugUtility.HandleErrorIfNullGetComponent<Damageable, Player_Shield_Bar>(m_PlayerDamageable, this,
            playerCharacterController.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ShieldFillImage.fillAmount = m_PlayerDamageable.ShieldValue / m_PlayerDamageable.MaxShieldValue;

    }
}
