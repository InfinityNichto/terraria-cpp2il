using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Audio;

[Cpp2IlInjected.Token(Token = "0x20002F8")]
public class SoundBank
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002173")]
	private Dictionary<string, Cue> _cues;

	[Cpp2IlInjected.Token(Token = "0x6001919")]
	[Cpp2IlInjected.Address(RVA = "0x12E3174", Offset = "0x12E3174", VA = "0x12E3174")]
	public SoundBank(AudioEngine engine, string contentPath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600191A")]
	[Cpp2IlInjected.Address(RVA = "0x12E31F8", Offset = "0x12E31F8", VA = "0x12E31F8")]
	public void LoadMusicId(int musicIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600191B")]
	[Cpp2IlInjected.Address(RVA = "0x12E3354", Offset = "0x12E3354", VA = "0x12E3354")]
	public Cue GetCue(string cueId)
	{
		return null;
	}
}
