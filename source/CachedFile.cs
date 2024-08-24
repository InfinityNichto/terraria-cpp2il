using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000044 RID: 68
[global::Cpp2ILInjected.Token(Token = "0x2000069")]
public class CachedFile
{
	// Token: 0x060001A0 RID: 416 RVA: 0x00022058 File Offset: 0x00020258
	[global::Cpp2ILInjected.Token(Token = "0x6000233")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D388", Offset = "0x70D388", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public CachedFile(string filename)
	{
		throw null;
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x0002205B File Offset: 0x0002025B
	// (set) Token: 0x060001A2 RID: 418 RVA: 0x0002205E File Offset: 0x0002025E
	[global::Cpp2ILInjected.Token(Token = "0x17000074")]
	public byte[] Data
	{
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x70D3B8", Offset = "0x70D3B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x70D3C0", Offset = "0x70D3C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04000112 RID: 274
	[global::Cpp2ILInjected.Token(Token = "0x4000205")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public CachedFile.Modifications ModificationFlag;

	// Token: 0x04000113 RID: 275
	[global::Cpp2ILInjected.Token(Token = "0x4000206")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public readonly string Filename;

	// Token: 0x04000114 RID: 276
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x4000207")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private byte[] <Data>k__BackingField;

	// Token: 0x02000787 RID: 1927
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public enum Modifications
	{
		// Token: 0x040078D9 RID: 30937
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		Delete,
		// Token: 0x040078DA RID: 30938
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		Write,
		// Token: 0x040078DB RID: 30939
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		None
	}
}
