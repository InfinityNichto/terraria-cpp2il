using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x200048D")]
public abstract class SoundStyle
{
	[Cpp2IlInjected.Token(Token = "0x400650E")]
	private static UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400650F")]
	private float _volume;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006510")]
	private float _pitchVariance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006511")]
	private SoundType _type;

	[Cpp2IlInjected.Token(Token = "0x17000645")]
	public float Volume
	{
		[Cpp2IlInjected.Token(Token = "0x6003325")]
		[Cpp2IlInjected.Address(RVA = "0x11CA6A4", Offset = "0x11CA6A4", VA = "0x11CA6A4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000646")]
	public float PitchVariance
	{
		[Cpp2IlInjected.Token(Token = "0x6003326")]
		[Cpp2IlInjected.Address(RVA = "0x11CA6AC", Offset = "0x11CA6AC", VA = "0x11CA6AC")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000647")]
	public SoundType Type
	{
		[Cpp2IlInjected.Token(Token = "0x6003327")]
		[Cpp2IlInjected.Address(RVA = "0x11CA6B4", Offset = "0x11CA6B4", VA = "0x11CA6B4")]
		get
		{
			return default(SoundType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000648")]
	public abstract bool IsTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x6003328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003329")]
	[Cpp2IlInjected.Address(RVA = "0x11C796C", Offset = "0x11C796C", VA = "0x11C796C")]
	public SoundStyle(float volume, float pitchVariance, SoundType type = SoundType.Sound)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600332A")]
	[Cpp2IlInjected.Address(RVA = "0x11C77E0", Offset = "0x11C77E0", VA = "0x11C77E0")]
	public SoundStyle(SoundType type = SoundType.Sound)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600332B")]
	[Cpp2IlInjected.Address(RVA = "0x11C913C", Offset = "0x11C913C", VA = "0x11C913C")]
	public float GetRandomPitch()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600332C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract SoundEffect GetRandomSound();
}
