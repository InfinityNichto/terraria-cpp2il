using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200015B RID: 347
[global::Cpp2ILInjected.Token(Token = "0x20001E0")]
[Serializable]
public class Inventory_Layout : PageControllerLayoutDefinition<Inventory_Layout>
{
	// Token: 0x06000B33 RID: 2867 RVA: 0x00023CDE File Offset: 0x00021EDE
	[global::Cpp2ILInjected.Token(Token = "0x6000C46")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAD04", Offset = "0x9CAD04", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Inventory_Layout()
	{
		throw null;
	}

	// Token: 0x04000D2A RID: 3370
	[global::Cpp2ILInjected.Token(Token = "0x400112D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000D2B RID: 3371
	[global::Cpp2ILInjected.Token(Token = "0x400112E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x04000D2C RID: 3372
	[global::Cpp2ILInjected.Token(Token = "0x400112F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	// Token: 0x04000D2D RID: 3373
	[global::Cpp2ILInjected.Token(Token = "0x4001130")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float ScaleSpeed;

	// Token: 0x04000D2E RID: 3374
	[global::Cpp2ILInjected.Token(Token = "0x4001131")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x04000D2F RID: 3375
	[global::Cpp2ILInjected.Token(Token = "0x4001132")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HorizontalHotbarGrid;

	// Token: 0x04000D30 RID: 3376
	[global::Cpp2ILInjected.Token(Token = "0x4001133")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout ItemGrid;

	// Token: 0x04000D31 RID: 3377
	[global::Cpp2ILInjected.Token(Token = "0x4001134")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout HorizontalItemGrid;

	// Token: 0x04000D32 RID: 3378
	[global::Cpp2ILInjected.Token(Token = "0x4001135")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04000D33 RID: 3379
	[global::Cpp2ILInjected.Token(Token = "0x4001136")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public FavoriteIcons FavoriteIcons;

	// Token: 0x04000D34 RID: 3380
	[global::Cpp2ILInjected.Token(Token = "0x4001137")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 BindingOffset;

	// Token: 0x04000D35 RID: 3381
	[global::Cpp2ILInjected.Token(Token = "0x4001138")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float BindingScale;
}
