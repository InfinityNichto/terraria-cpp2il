using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B4 RID: 436
[global::Cpp2ILInjected.Token(Token = "0x2000243")]
public class TrashCan_Layout : PageControllerLayoutDefinition<TrashCan_Layout>
{
	// Token: 0x06000C13 RID: 3091 RVA: 0x00023F7E File Offset: 0x0002217E
	[global::Cpp2ILInjected.Token(Token = "0x6000D2D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5880", Offset = "0x9D5880", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public TrashCan_Layout()
	{
		throw null;
	}

	// Token: 0x04001355 RID: 4949
	[global::Cpp2ILInjected.Token(Token = "0x400180A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float ItemScale;

	// Token: 0x04001356 RID: 4950
	[global::Cpp2ILInjected.Token(Token = "0x400180B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout TrashGrid;

	// Token: 0x04001357 RID: 4951
	[global::Cpp2ILInjected.Token(Token = "0x400180C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemHighlightScale;

	// Token: 0x04001358 RID: 4952
	[global::Cpp2ILInjected.Token(Token = "0x400180D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color BackingColour;
}
