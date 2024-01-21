using Cpp2IlInjected;
using UnityEngine.Audio;

[Cpp2IlInjected.Token(Token = "0x2000032")]
public class SoundGroup
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public string MixerGroupPath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AudioMixerGroup _group;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public AudioMixerGroup MixerGroup
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1062378", Offset = "0x1062378", VA = "0x1062378")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x10625D0", Offset = "0x10625D0", VA = "0x10625D0")]
	public SoundGroup()
	{
	}
}
