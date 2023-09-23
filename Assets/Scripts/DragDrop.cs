using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // import EventSystem untuk inheritance beberapa library draganddrop

// ada beberapa class inheritance yang ditambahakan
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private void Update()
    {
      
            float minX = -830.0f;
            float maxX = 833.0f;
            float minY = -495.0f;
            float maxY = -323.0f;

            Vector3 currentPosition = transform.position;

            if (currentPosition.x < minX || currentPosition.x < maxX || currentPosition.y < minY || currentPosition.y < maxY)
            {
                Debug.Log("Dalam Kotak");
                // Objek berada di luar area yang benar
               // return true;
            }
            if (currentPosition.x > minX || currentPosition.x > maxX || currentPosition.y > minY || currentPosition.y > maxY)
        {
            Debug.Log("Diluar kotak");
        }
            // Implementasikan logika untuk memeriksa apakah objek berada di tempat yang benar
            // Misalnya, Anda dapat memeriksa jarak antara objek dan posisi target
            // Jika objek berada dalam jarak tertentu dari posisi target, Anda dapat mengembalikan true
            // Jika tidak, Anda dapat mengembalikan false


           // return false;
        
    }
    private RectTransform recttransform;
    private CanvasGroup canvasGrup; // Mendeklarasikan CanvasGroup dengan nama variabel canvasgrup
    [SerializeField] private Canvas canvas; // Deklarsai drag object canvas dengan Akses member private
    private void Awake() // pembuatan function Awake() akan dipanggil atau dijalankan lebih awal dari constructor
    {
        recttransform = GetComponent<RectTransform>(); // Pengambilan component
        canvasGrup = GetComponent<CanvasGroup>(); // Pengambilan component
    }

    public void OnBeginDrag(PointerEventData eventData) // function untuk pertama kali ketika obj di drag atau digeser
    {
        Debug.Log("on begin drag"); // Test dibugging apakah berfungsi
        canvasGrup.alpha = 0.6f;// belum terlalu mengerti
        canvasGrup.blocksRaycasts = false; // belum terlalu mengerti
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("on Drag");// Test dibugging apakah berfungsi
        recttransform.anchoredPosition += eventData.delta / canvas.scaleFactor; // akan mengatur posisi obj akan bergerak ketika di drag objectnya
      
    }

    public void OnEndDrag(PointerEventData eventData) // function untuk obj sudah selesai di click dan di drag
    {
        Debug.Log("on end drag");// Test dibugging apakah berfungsi
        canvasGrup.alpha = 0.1f;// belum terlalu mengerti
        canvasGrup.blocksRaycasts = true; // belum terlalu mengerti
    }

    public void OnPointerDown(PointerEventData eventData) // function untuk ketika obj ditekan atau diclick
    {
        // Code yang akan dijalankan ketika objek ditekan
        Debug.Log("Objek ditekan!");// Test dibugging apakah berfungsi

        // Tambahkan kode sesuai kebutuhan, misalnya mengubah warna, memicu suara, dll.
    }

   
}
