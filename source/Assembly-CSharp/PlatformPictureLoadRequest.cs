using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000218 RID: 536
[global::Cpp2ILInjected.Token(Token = "0x20002C0")]
public class PlatformPictureLoadRequest
{
	// Token: 0x06000F14 RID: 3860 RVA: 0x00024839 File Offset: 0x00022A39
	[global::Cpp2ILInjected.Token(Token = "0x6001047")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41FE8", Offset = "0xA41FE8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void UpdateLoad()
	{
		throw null;
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x0002483C File Offset: 0x00022A3C
	[global::Cpp2ILInjected.Token(Token = "0x6001048")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41FEC", Offset = "0xA41FEC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public PlatformPictureLoadRequest()
	{
		throw null;
	}

	// Token: 0x04001A03 RID: 6659
	[global::Cpp2ILInjected.Token(Token = "0x4001F38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool isDone;

	// Token: 0x04001A04 RID: 6660
	[global::Cpp2ILInjected.Token(Token = "0x4001F39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool Error;

	// Token: 0x04001A05 RID: 6661
	[global::Cpp2ILInjected.Token(Token = "0x4001F3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture2D Result;
}
