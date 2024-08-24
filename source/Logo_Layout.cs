using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000173 RID: 371
[global::Cpp2ILInjected.Token(Token = "0x20001FD")]
public class Logo_Layout : LayoutDefinition
{
	// Token: 0x06000B85 RID: 2949 RVA: 0x00023DD4 File Offset: 0x00021FD4
	[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF0BC", Offset = "0x9CF0BC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00023DD7 File Offset: 0x00021FD7
	[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF108", Offset = "0x9CF108", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Logo_Layout()
	{
		throw null;
	}

	// Token: 0x04000E53 RID: 3667
	[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
	public static Logo_Layout Instance;

	// Token: 0x04000E54 RID: 3668
	[global::Cpp2ILInjected.Token(Token = "0x40012A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000E55 RID: 3669
	[global::Cpp2ILInjected.Token(Token = "0x40012A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000E56 RID: 3670
	[global::Cpp2ILInjected.Token(Token = "0x40012A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 Location;

	// Token: 0x04000E57 RID: 3671
	[global::Cpp2ILInjected.Token(Token = "0x40012A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float Scale;
}
