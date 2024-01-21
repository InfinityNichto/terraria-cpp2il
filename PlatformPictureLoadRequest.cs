using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000219")]
public class PlatformPictureLoadRequest
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A0C")]
	public bool isDone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001A0D")]
	public bool Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A0E")]
	public Texture2D Result;

	[Cpp2IlInjected.Token(Token = "0x6000F29")]
	[Cpp2IlInjected.Address(RVA = "0x10B6864", Offset = "0x10B6864", VA = "0x10B6864", Slot = "4")]
	public virtual void UpdateLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F2A")]
	[Cpp2IlInjected.Address(RVA = "0x10B6868", Offset = "0x10B6868", VA = "0x10B6868")]
	public PlatformPictureLoadRequest()
	{
	}
}
