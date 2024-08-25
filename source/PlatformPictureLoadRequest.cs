using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002C0")]
public class PlatformPictureLoadRequest
{
	[global::Cpp2ILInjected.Token(Token = "0x6001047")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41FE8", Offset = "0xA41FE8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void UpdateLoad()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001048")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41FEC", Offset = "0xA41FEC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public PlatformPictureLoadRequest()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001F38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool isDone;

	[global::Cpp2ILInjected.Token(Token = "0x4001F39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool Error;

	[global::Cpp2ILInjected.Token(Token = "0x4001F3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture2D Result;
}
