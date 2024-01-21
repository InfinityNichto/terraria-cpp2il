using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000489")]
public class LegacySoundStyle : SoundStyle
{
	[Cpp2IlInjected.Token(Token = "0x4006504")]
	private static readonly UnifiedRandom Random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006505")]
	private readonly int _style;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006506")]
	public readonly int Variations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006507")]
	public readonly int SoundId;

	[Cpp2IlInjected.Token(Token = "0x17000642")]
	public int Style
	{
		[Cpp2IlInjected.Token(Token = "0x60032F7")]
		[Cpp2IlInjected.Address(RVA = "0x11C7680", Offset = "0x11C7680", VA = "0x11C7680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000643")]
	public override bool IsTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x60032F8")]
		[Cpp2IlInjected.Address(RVA = "0x11C7724", Offset = "0x11C7724", VA = "0x11C7724", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60032F9")]
	[Cpp2IlInjected.Address(RVA = "0x11C7738", Offset = "0x11C7738", VA = "0x11C7738")]
	public LegacySoundStyle(int soundId, int style, SoundType type = SoundType.Sound)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032FA")]
	[Cpp2IlInjected.Address(RVA = "0x11C7810", Offset = "0x11C7810", VA = "0x11C7810")]
	public LegacySoundStyle(int soundId, int style, int variations, SoundType type = SoundType.Sound)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032FB")]
	[Cpp2IlInjected.Address(RVA = "0x11C78B8", Offset = "0x11C78B8", VA = "0x11C78B8")]
	private LegacySoundStyle(int soundId, int style, int variations, SoundType type, float volume, float pitchVariance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032FC")]
	[Cpp2IlInjected.Address(RVA = "0x11C799C", Offset = "0x11C799C", VA = "0x11C799C")]
	public LegacySoundStyle WithVolume(float volume)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032FD")]
	[Cpp2IlInjected.Address(RVA = "0x11C7A40", Offset = "0x11C7A40", VA = "0x11C7A40")]
	public LegacySoundStyle WithPitchVariance(float pitchVariance)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032FE")]
	[Cpp2IlInjected.Address(RVA = "0x11C7AE4", Offset = "0x11C7AE4", VA = "0x11C7AE4")]
	public LegacySoundStyle AsMusic()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032FF")]
	[Cpp2IlInjected.Address(RVA = "0x11C7B8C", Offset = "0x11C7B8C", VA = "0x11C7B8C")]
	public LegacySoundStyle AsAmbient()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003300")]
	[Cpp2IlInjected.Address(RVA = "0x11C7C34", Offset = "0x11C7C34", VA = "0x11C7C34")]
	public LegacySoundStyle AsSound()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003301")]
	[Cpp2IlInjected.Address(RVA = "0x11C7CDC", Offset = "0x11C7CDC", VA = "0x11C7CDC")]
	public bool Includes(int soundId, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003302")]
	[Cpp2IlInjected.Address(RVA = "0x11C7D14", Offset = "0x11C7D14", VA = "0x11C7D14", Slot = "5")]
	public override SoundEffect GetRandomSound()
	{
		return null;
	}
}
