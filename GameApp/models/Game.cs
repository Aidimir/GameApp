using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.models
{
    public class Game
    {
        private GameStage stage = GameStage.NotStarted;
        public GameStage Stage => stage;
        public event Action<GameStage> StageChanged;
        public int score = 0;
        public int BestScore = 0;
        public int LastResult = 0;
        public void Start()
        {
            ChangeStage(GameStage.IsPlaying);
        }
        private void ChangeStage(GameStage stage)
        {
            this.stage = stage;
            StageChanged?.Invoke(stage);
        }
        public void ConfirmedHit()
        {
            score += 10;
        }
        public void EndGame()
        {
            ChangeStage(GameStage.Finished);
            score = 0;
        }
    }
}