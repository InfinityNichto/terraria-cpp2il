using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Audio;

[Cpp2IlInjected.Token(Token = "0x20002F7")]
public class Cue
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400216F")]
	private bool _paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002170")]
	private float _pausedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002171")]
	private SoundEffectInstance _audioInstance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002172")]
	private SoundEffect _effect;

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public bool IsPaused
	{
		[Cpp2IlInjected.Token(Token = "0x6001911")]
		[Cpp2IlInjected.Address(RVA = "0x12E2F2C", Offset = "0x12E2F2C", VA = "0x12E2F2C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x6001912")]
		[Cpp2IlInjected.Address(RVA = "0x12E2F34", Offset = "0x12E2F34", VA = "0x12E2F34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public bool IsStopped
	{
		[Cpp2IlInjected.Token(Token = "0x6001913")]
		[Cpp2IlInjected.Address(RVA = "0x12E2F74", Offset = "0x12E2F74", VA = "0x12E2F74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001910")]
	[Cpp2IlInjected.Address(RVA = "0x12E2E78", Offset = "0x12E2E78", VA = "0x12E2E78")]
	public Cue(SoundEffect musicSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001914")]
	[Cpp2IlInjected.Address(RVA = "0x12E2FA0", Offset = "0x12E2FA0", VA = "0x12E2FA0")]
	public void Play()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001915")]
	[Cpp2IlInjected.Address(RVA = "0x12E2FC0", Offset = "0x12E2FC0", VA = "0x12E2FC0")]
	public void Pause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001916")]
	[Cpp2IlInjected.Address(RVA = "0x12E3038", Offset = "0x12E3038", VA = "0x12E3038")]
	public void Resume()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001917")]
	[Cpp2IlInjected.Address(RVA = "0x12E3098", Offset = "0x12E3098", VA = "0x12E3098")]
	public void Stop(AudioStopOptions option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001918")]
	[Cpp2IlInjected.Address(RVA = "0x12E30B0", Offset = "0x12E30B0", VA = "0x12E30B0")]
	public void SetVariable(string id, float value)
	{
	}
}
