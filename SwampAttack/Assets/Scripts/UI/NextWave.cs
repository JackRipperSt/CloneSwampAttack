using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWavew3 : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemySpawned += OnAllEnemySpawned;
        _nextWaveButton.onClick.AddListener(OnNextWaveButtonClick);

    }

    private void OnDisable()
    {
        _spawner.AllEnemySpawned -= OnAllEnemySpawned;
    }


    public void OnAllEnemySpawned()
    {
        _nextWaveButton.gameObject.SetActive(true);
        _nextWaveButton.onClick.RemoveListener(OnNextWaveButtonClick);
    }

    public void OnNextWaveButtonClick()
    {
        _spawner.nextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }


}
