using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000485")]
public class CustomSoundStyle : SoundStyle
{
	[Cpp2IlInjected.Token(Token = "0x40064AF")]
	private static readonly UnifiedRandom Random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40064B0")]
	private readonly SoundEffect[] _soundEffects;

	[Cpp2IlInjected.Token(Token = "0x17000641")]
	public override bool IsTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x60032CC")]
		[Cpp2IlInjected.Address(RVA = "0x106EBB0", Offset = "0x106EBB0", VA = "0x106EBB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60032CD")]
	[Cpp2IlInjected.Address(RVA = "0x106EBB8", Offset = "0x106EBB8", VA = "0x106EBB8")]
	public CustomSoundStyle(SoundEffect soundEffect, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032CE")]
	[Cpp2IlInjected.Address(RVA = "0x106ECB4", Offset = "0x106ECB4", VA = "0x106ECB4")]
	public CustomSoundStyle(SoundEffect[] soundEffects, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032CF")]
	[Cpp2IlInjected.Address(RVA = "0x106ED64", Offset = "0x106ED64", VA = "0x106ED64", Slot = "5")]
	public override SoundEffect GetRandomSound()
	{
		return null;
	}
}
