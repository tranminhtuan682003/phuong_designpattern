namespace phuong.baocao;

public class AudioAdapter : ISoundPlayer
{
    private readonly OldAudioSystem _oldAudioSystem;

    public AudioAdapter(OldAudioSystem oldAudioSystem)
    {
        _oldAudioSystem = oldAudioSystem;
    }

    public void PlaySound()
    {
        _oldAudioSystem.StartAudio();
    }

    public void StopSound()
    {
        _oldAudioSystem.EndAudio();
    }
}
