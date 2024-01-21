using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Audio;

[Cpp2IlInjected.Token(Token = "0x20002FA")]
public class SoundEffectInstance
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002176")]
	internal SoundEffect _effect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002177")]
	private bool _loop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002178")]
	private float _pan;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002179")]
	private float _volume;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400217A")]
	private float _pitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400217B")]
	private SoundInstance _playingInstance;

	[Cpp2IlInjected.Token(Token = "0x400217C")]
	public static float pitchOffset;

	[Cpp2IlInjected.Token(Token = "0x400217D")]
	public static float pitchScale;

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public virtual bool IsLooped
	{
		[Cpp2IlInjected.Token(Token = "0x6001923")]
		[Cpp2IlInjected.Address(RVA = "0x12E35F4", Offset = "0x12E35F4", VA = "0x12E35F4", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001924")]
		[Cpp2IlInjected.Address(RVA = "0x12E35FC", Offset = "0x12E35FC", VA = "0x12E35FC", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public float Pan
	{
		[Cpp2IlInjected.Token(Token = "0x6001925")]
		[Cpp2IlInjected.Address(RVA = "0x12E3604", Offset = "0x12E3604", VA = "0x12E3604")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001926")]
		[Cpp2IlInjected.Address(RVA = "0x12E360C", Offset = "0x12E360C", VA = "0x12E360C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public float Pitch
	{
		[Cpp2IlInjected.Token(Token = "0x6001927")]
		[Cpp2IlInjected.Address(RVA = "0x12E36E0", Offset = "0x12E36E0", VA = "0x12E36E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001928")]
		[Cpp2IlInjected.Address(RVA = "0x12E36E8", Offset = "0x12E36E8", VA = "0x12E36E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public float Volume
	{
		[Cpp2IlInjected.Token(Token = "0x6001929")]
		[Cpp2IlInjected.Address(RVA = "0x12E3800", Offset = "0x12E3800", VA = "0x12E3800")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600192A")]
		[Cpp2IlInjected.Address(RVA = "0x12E30BC", Offset = "0x12E30BC", VA = "0x12E30BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public virtual SoundState State
	{
		[Cpp2IlInjected.Token(Token = "0x600192B")]
		[Cpp2IlInjected.Address(RVA = "0x12E3808", Offset = "0x12E3808", VA = "0x12E3808", Slot = "6")]
		get
		{
			return default(SoundState);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public float CurrentPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001934")]
		[Cpp2IlInjected.Address(RVA = "0x12E3020", Offset = "0x12E3020", VA = "0x12E3020")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001935")]
		[Cpp2IlInjected.Address(RVA = "0x12E3084", Offset = "0x12E3084", VA = "0x12E3084")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600192C")]
	[Cpp2IlInjected.Address(RVA = "0x12E3470", Offset = "0x12E3470", VA = "0x12E3470")]
	internal SoundEffectInstance(SoundEffect effect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600192D")]
	[Cpp2IlInjected.Address(RVA = "0x12E38DC", Offset = "0x12E38DC", VA = "0x12E38DC", Slot = "7")]
	public virtual void Play()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600192E")]
	[Cpp2IlInjected.Address(RVA = "0x12E3A94", Offset = "0x12E3A94", VA = "0x12E3A94")]
	private static void PlayOnMainThread(object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600192F")]
	[Cpp2IlInjected.Address(RVA = "0x12E3B18", Offset = "0x12E3B18", VA = "0x12E3B18")]
	private static void StopOnMainThread(object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001930")]
	[Cpp2IlInjected.Address(RVA = "0x12E3BA4", Offset = "0x12E3BA4", VA = "0x12E3BA4")]
	public void Restart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001931")]
	[Cpp2IlInjected.Address(RVA = "0x12E3BB8", Offset = "0x12E3BB8", VA = "0x12E3BB8", Slot = "8")]
	public virtual void Pause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001932")]
	[Cpp2IlInjected.Address(RVA = "0x12E3BBC", Offset = "0x12E3BBC", VA = "0x12E3BBC", Slot = "9")]
	public virtual void Resume()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001933")]
	[Cpp2IlInjected.Address(RVA = "0x12E3BC0", Offset = "0x12E3BC0", VA = "0x12E3BC0", Slot = "10")]
	public virtual void Stop(bool immediate = false)
	{
	}
}
