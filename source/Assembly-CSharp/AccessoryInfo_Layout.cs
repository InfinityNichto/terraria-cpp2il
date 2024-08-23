using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000114 RID: 276
[global::Cpp2ILInjected.Token(Token = "0x200018C")]
public class AccessoryInfo_Layout : LayoutDefinition
{
	// Token: 0x06000A38 RID: 2616 RVA: 0x000239ED File Offset: 0x00021BED
	[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB69C", Offset = "0x9AB69C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x000239F0 File Offset: 0x00021BF0
	[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB6E8", Offset = "0x9AB6E8", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public AccessoryInfo_Layout()
	{
		throw null;
	}

	// Token: 0x040008C8 RID: 2248
	[global::Cpp2ILInjected.Token(Token = "0x4000BEA")]
	public static AccessoryInfo_Layout Instance;

	// Token: 0x040008C9 RID: 2249
	[global::Cpp2ILInjected.Token(Token = "0x4000BEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout IconGrid;

	// Token: 0x040008CA RID: 2250
	[global::Cpp2ILInjected.Token(Token = "0x4000BEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout IconGridSecondary;

	// Token: 0x040008CB RID: 2251
	[global::Cpp2ILInjected.Token(Token = "0x4000BED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout ItemText;

	// Token: 0x040008CC RID: 2252
	[global::Cpp2ILInjected.Token(Token = "0x4000BEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout DisabledItemText;

	// Token: 0x040008CD RID: 2253
	[global::Cpp2ILInjected.Token(Token = "0x4000BEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout CritterItemText;

	// Token: 0x040008CE RID: 2254
	[global::Cpp2ILInjected.Token(Token = "0x4000BF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float ItemScale;

	// Token: 0x040008CF RID: 2255
	[global::Cpp2ILInjected.Token(Token = "0x4000BF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color IconColour;

	// Token: 0x040008D0 RID: 2256
	[global::Cpp2ILInjected.Token(Token = "0x4000BF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color DisabledIconColour;

	// Token: 0x040008D1 RID: 2257
	[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout Backing;

	// Token: 0x040008D2 RID: 2258
	[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 BackingTLOffset;

	// Token: 0x040008D3 RID: 2259
	[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 BackingBROffset;
}
