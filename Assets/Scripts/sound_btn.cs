using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_btn : MonoBehaviour
{
    public AudioClip clickSound; // Suara yang akan diputar
    private AudioSource audioSource; // Komponen Audio Source

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clickSound;
    }

    // Fungsi untuk memainkan suara dan pindah scene
    public void PlaySoundAndChangeScene(string sceneName)
    {
        audioSource.Play();
        // Tunda pindah scene selama beberapa detik agar suara bisa diputar sebelum pindah
        Invoke("ChangeScene", audioSource.clip.length);
        // Atau gunakan Invoke("ChangeScene", delay) jika Anda ingin menambahkan jeda sebelum pindah scene.
    }
    public void Playbtn()
    {
        audioSource.Play();
    }
}
