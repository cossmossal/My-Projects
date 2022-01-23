using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioClip DeathOfPlayer, EnemyDeath, JumpSound, PlayerHit, PickUpCoinSound, BackgroundSound, PowerUpSoundEffect;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        DeathOfPlayer = Resources.Load<AudioClip>("DeathOfPlayer");
        EnemyDeath = Resources.Load<AudioClip>("EnemyDeath");
        JumpSound = Resources.Load<AudioClip>("JumpSound");
        PlayerHit = Resources.Load<AudioClip>("PlayerHIT");
        PickUpCoinSound = Resources.Load<AudioClip>("PickUpCoinSound");
        audioSrc = GetComponent<AudioSource>();
        BackgroundSound = Resources.Load<AudioClip>("BackgroundSound");
        PowerUpSoundEffect = Resources.Load<AudioClip>("PowerUpSoundEffect");
    }

    // Update is called once per frame
    void Update()
    {
        
        }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "DeathOfPlayer":
                audioSrc.PlayOneShot(DeathOfPlayer);
                break;
            case "EnemyDeath":
                audioSrc.PlayOneShot(EnemyDeath);
                break;
            case "JumpSound":
                audioSrc.PlayOneShot(JumpSound);
                break;
            case "PlayerHIT":
                audioSrc.PlayOneShot(PlayerHit);
                break;
            case "PickUpCoinSound":
                audioSrc.PlayOneShot(PickUpCoinSound);
                break;
            case "BackgroundSound":
                audioSrc.PlayOneShot(BackgroundSound);
                break;
            case "PowerUpSoundEffect":
                audioSrc.PlayOneShot(PowerUpSoundEffect);
                break;
        }
    }
    public static void StopSound()
    {
        audioSrc.Stop();
    }
}
