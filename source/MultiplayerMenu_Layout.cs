using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017D RID: 381
[global::Cpp2ILInjected.Token(Token = "0x2000207")]
public class MultiplayerMenu_Layout : LayoutDefinition
{
	// Token: 0x06000B97 RID: 2967 RVA: 0x00023E0A File Offset: 0x0002200A
	[global::Cpp2ILInjected.Token(Token = "0x6000CAC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF6D8", Offset = "0x9CF6D8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00023E0D File Offset: 0x0002200D
	[global::Cpp2ILInjected.Token(Token = "0x6000CAD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF724", Offset = "0x9CF724", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000ED1 RID: 3793
	[global::Cpp2ILInjected.Token(Token = "0x400131E")]
	public static MultiplayerMenu_Layout Instance;

	// Token: 0x04000ED2 RID: 3794
	[global::Cpp2ILInjected.Token(Token = "0x400131F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Join;

	// Token: 0x04000ED3 RID: 3795
	[global::Cpp2ILInjected.Token(Token = "0x4001320")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout HostAndPlay;

	// Token: 0x04000ED4 RID: 3796
	[global::Cpp2ILInjected.Token(Token = "0x4001321")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Back;
}
