using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x200048B")]
public static class SoundInstanceGarbageCollector
{
	[Cpp2IlInjected.Token(Token = "0x400650C")]
	private static readonly List<SoundEffectInstance> _activeSounds;

	[Cpp2IlInjected.Token(Token = "0x6003317")]
	[Cpp2IlInjected.Address(RVA = "0x11CA540", Offset = "0x11CA540", VA = "0x11CA540")]
	public static void Track(SoundEffectInstance sound)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003318")]
	[Cpp2IlInjected.Address(RVA = "0x11C8418", Offset = "0x11C8418", VA = "0x11C8418")]
	public static void Update()
	{
	}
}
