using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn_hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button button; // Tombol yang ingin diubah saat cursor di atasnya
    public float scaleFactor = 1.2f; // Faktor perbesaran saat cursor di atas tombol

    private Vector3 originalScale;

    void Start()
    {
        // Simpan skala awal tombol
        originalScale = button.transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Ubah skala tombol saat cursor memasuki
        button.transform.localScale = originalScale * scaleFactor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Kembalikan skala ke nilai awal saat cursor meninggalkan
        button.transform.localScale = originalScale;
    }
}
