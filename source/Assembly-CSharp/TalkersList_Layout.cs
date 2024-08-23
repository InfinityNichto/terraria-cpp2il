using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B3 RID: 435
[global::Cpp2ILInjected.Token(Token = "0x2000242")]
public class TalkersList_Layout : LayoutDefinition
{
	// Token: 0x06000C11 RID: 3089 RVA: 0x00023F78 File Offset: 0x00022178
	[global::Cpp2ILInjected.Token(Token = "0x6000D2B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D57A0", Offset = "0x9D57A0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00023F7B File Offset: 0x0002217B
	[global::Cpp2ILInjected.Token(Token = "0x6000D2C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D57EC", Offset = "0x9D57EC", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public TalkersList_Layout()
	{
		throw null;
	}

	// Token: 0x0400134C RID: 4940
	[global::Cpp2ILInjected.Token(Token = "0x4001801")]
	public static TalkersList_Layout Instance;

	// Token: 0x0400134D RID: 4941
	[global::Cpp2ILInjected.Token(Token = "0x4001802")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout IconGrid;

	// Token: 0x0400134E RID: 4942
	[global::Cpp2ILInjected.Token(Token = "0x4001803")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout ItemText;

	// Token: 0x0400134F RID: 4943
	[global::Cpp2ILInjected.Token(Token = "0x4001804")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x04001350 RID: 4944
	[global::Cpp2ILInjected.Token(Token = "0x4001805")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color IconColour;

	// Token: 0x04001351 RID: 4945
	[global::Cpp2ILInjected.Token(Token = "0x4001806")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout Icon;

	// Token: 0x04001352 RID: 4946
	[global::Cpp2ILInjected.Token(Token = "0x4001807")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Backing;

	// Token: 0x04001353 RID: 4947
	[global::Cpp2ILInjected.Token(Token = "0x4001808")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 BackingTLOffset;

	// Token: 0x04001354 RID: 4948
	[global::Cpp2ILInjected.Token(Token = "0x4001809")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 BackingBROffset;
}
