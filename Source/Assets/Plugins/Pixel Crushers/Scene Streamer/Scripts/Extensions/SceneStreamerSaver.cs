namespace PixelCrushers
{

#if USE_SAVESYSTEM
    public class SceneStreamerSaver : Saver
    {

        public override string RecordData()
        {
            return SaveSystem.Serialize(SceneStreamer.SceneStreamer.RecordState());
        }

        public override void ApplyDataImmediate()
        {
            var s = SaveSystem.currentSavedGameData.GetData(key);
            if (string.IsNullOrEmpty(s)) return;
            var state = SaveSystem.Deserialize<SceneStreamer.SceneStreamerState>(s);
            if (state == null) return;
            SceneStreamer.SceneStreamer.ApplyState(state);
        }

        public override void ApplyData(string s)
        {
            // Handled in ApplyDataImmediate.
        }
    }
#else
    public class SceneStreamerSaver : UnityEngine.MonoBehaviour { }
#endif
}
