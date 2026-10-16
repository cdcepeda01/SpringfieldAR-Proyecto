using UnityEngine;

public class MultiTargets : MonoBehaviour
{
    [SerializeField] private GameObject startModel;

    private int modelsCount;
    private int indexCurrentModel;

    void Start()
    {
        modelsCount = transform.childCount;

        // Apagar TODOS los modelos al iniciar
        for (int i = 0; i < modelsCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        // Determinar cuál será el modelo inicial
        indexCurrentModel = startModel.transform.GetSiblingIndex();

        // Encender solamente el modelo inicial
        startModel.SetActive(true);
    }

    public void ChangeARModel(int direction)
    {
        // Apagar modelo actual
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);

        // Calcular nuevo índice
        indexCurrentModel += direction;

        // Ciclo hacia atrás
        if (indexCurrentModel < 0)
        {
            indexCurrentModel = modelsCount - 1;
        }

        // Ciclo hacia adelante
        if (indexCurrentModel >= modelsCount)
        {
            indexCurrentModel = 0;
        }

        // Encender nuevo modelo
        transform.GetChild(indexCurrentModel).gameObject.SetActive(true);
    }
}