using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000030")]
public class SoundChannel
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public AudioSource AudioSource;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private SoundInstance _currentSound;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public SoundInstance CurrentSound
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1061978", Offset = "0x1061978", VA = "0x1061978")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1061980", Offset = "0x1061980", VA = "0x1061980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1061998", Offset = "0x1061998", VA = "0x1061998")]
	public SoundChannel()
	{
	}
}
