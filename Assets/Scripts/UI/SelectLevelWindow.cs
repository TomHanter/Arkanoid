using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.UI
{
    public class SelectLevelWindow : MonoBehaviour
    {
        [SerializeField] private LevelButton _levelButtonPrefab;
        [SerializeField] private RectTransform _content;

        [SerializeField] private LevelsConfigs _levelsConfigs;

        private void Awake()
        {
            for (int i = 0; i < _levelsConfigs.Levels.Length; i++)
            {
                var buttonInstance = Instantiate(_levelButtonPrefab, _content);

                var levelConfig = _levelsConfigs.Levels[i];

                // кнопка отображается активной, если
                // 1 текущ ур пройден
                // ИЛИ предыдущ пройден
                // или это первый уровень
                bool active = levelConfig.Completed ||
                              (i - 1 >= 0 &&
                               _levelsConfigs.Levels[i - 1].Completed) ||
                               i == 0;

                buttonInstance.DrawLevel(
                    (i + 1).ToString(),
                    levelConfig.SceneName,
                    active);
            }
        }
    }
}