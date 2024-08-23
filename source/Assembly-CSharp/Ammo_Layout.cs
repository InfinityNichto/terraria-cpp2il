using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000118 RID: 280
[global::Cpp2ILInjected.Token(Token = "0x2000190")]
public class Ammo_Layout : PageControllerLayoutDefinition<Ammo_Layout>
{
	// Token: 0x06000A40 RID: 2624 RVA: 0x00023A05 File Offset: 0x00021C05
	[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB9F8", Offset = "0x9AB9F8", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Ammo_Layout()
	{
		throw null;
	}

	// Token: 0x04000905 RID: 2309
	[global::Cpp2ILInjected.Token(Token = "0x4000C27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000906 RID: 2310
	[global::Cpp2ILInjected.Token(Token = "0x4000C28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x04000907 RID: 2311
	[global::Cpp2ILInjected.Token(Token = "0x4000C29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	// Token: 0x04000908 RID: 2312
	[global::Cpp2ILInjected.Token(Token = "0x4000C2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout AmmoGrid;

	// Token: 0x04000909 RID: 2313
	[global::Cpp2ILInjected.Token(Token = "0x4000C2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale_Collapsed;

	// Token: 0x0400090A RID: 2314
	[global::Cpp2ILInjected.Token(Token = "0x4000C2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale_Collapsed;

	// Token: 0x0400090B RID: 2315
	[global::Cpp2ILInjected.Token(Token = "0x4000C2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout AmmoGrid_Collapsed;

	// Token: 0x0400090C RID: 2316
	[global::Cpp2ILInjected.Token(Token = "0x4000C2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public AnimationCurve ItemDragPulseScale;
}
