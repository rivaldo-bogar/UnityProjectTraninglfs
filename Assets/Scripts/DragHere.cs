using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems; // harus mengimport ini ketika ingin inheritance class baru

public class DragHere : MonoBehaviour,IDropHandler // Penambahan inheritance dari class IDropHandler
{
    public void OnDrop(PointerEventData eventData) // function ini harus ada ketika menambahkan inheritance dari IDropHandler
    {
        Debug.Log("Dropped item"); // Hanya percobaan dibugging 
        if(eventData.pointerDrag != null ) // kondisi jika event data di deteksi kosong akan menjalankan code didalam if ini.
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; // jika object yang di tarik sudah menyentuh sedikit ke dragboxnya akan otomatis di tempatkan
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
