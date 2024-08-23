using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200002F RID: 47
[global::Cpp2ILInjected.Token(Token = "0x200004F")]
public class SoundChannel
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600011B RID: 283 RVA: 0x00021EC9 File Offset: 0x000200C9
	// (set) Token: 0x0600011C RID: 284 RVA: 0x00021ECC File Offset: 0x000200CC
	[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
	public SoundInstance CurrentSound
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x706750", Offset = "0x706750", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x706758", Offset = "0x706758", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00021ECF File Offset: 0x000200CF
	[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x70676C", Offset = "0x70676C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SoundChannel()
	{
		throw null;
	}

	// Token: 0x040000C3 RID: 195
	[global::Cpp2ILInjected.Token(Token = "0x400011C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public AudioSource AudioSource;

	// Token: 0x040000C4 RID: 196
	[global::Cpp2ILInjected.Token(Token = "0x400011D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private SoundInstance _currentSound;
}
