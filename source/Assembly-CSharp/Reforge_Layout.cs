using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A5 RID: 421
[global::Cpp2ILInjected.Token(Token = "0x2000234")]
public class Reforge_Layout : PageControllerLayoutDefinition<Reforge_Layout>
{
	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00023F00 File Offset: 0x00022100
	[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1A70", Offset = "0x9D1A70", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerReforge4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReforge), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReforge), Member = "get_Collapsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageIconsExtended_Layout), Member = "GetDisplayGrid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00023F03 File Offset: 0x00022103
	[global::Cpp2ILInjected.Token(Token = "0x6000D04")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1B0C", Offset = "0x9D1B0C", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public Reforge_Layout()
	{
		throw null;
	}

	// Token: 0x0400124C RID: 4684
	[global::Cpp2ILInjected.Token(Token = "0x4001701")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Guide;

	// Token: 0x0400124D RID: 4685
	[global::Cpp2ILInjected.Token(Token = "0x4001702")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Cost;

	// Token: 0x0400124E RID: 4686
	[global::Cpp2ILInjected.Token(Token = "0x4001703")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout ControllerCost;

	// Token: 0x0400124F RID: 4687
	[global::Cpp2ILInjected.Token(Token = "0x4001704")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout SavingsBacking;

	// Token: 0x04001250 RID: 4688
	[global::Cpp2ILInjected.Token(Token = "0x4001705")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout Savings;

	// Token: 0x04001251 RID: 4689
	[global::Cpp2ILInjected.Token(Token = "0x4001706")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout SavingsTitle;

	// Token: 0x04001252 RID: 4690
	[global::Cpp2ILInjected.Token(Token = "0x4001707")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 Savings1IconOffset;

	// Token: 0x04001253 RID: 4691
	[global::Cpp2ILInjected.Token(Token = "0x4001708")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 Savings2IconOffset;

	// Token: 0x04001254 RID: 4692
	[global::Cpp2ILInjected.Token(Token = "0x4001709")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 Savings3IconOffset;

	// Token: 0x04001255 RID: 4693
	[global::Cpp2ILInjected.Token(Token = "0x400170A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 Savings4IconOffset;

	// Token: 0x04001256 RID: 4694
	[global::Cpp2ILInjected.Token(Token = "0x400170B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Title;

	// Token: 0x04001257 RID: 4695
	[global::Cpp2ILInjected.Token(Token = "0x400170C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float ItemScale;

	// Token: 0x04001258 RID: 4696
	[global::Cpp2ILInjected.Token(Token = "0x400170D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float ItemHighlightScale;

	// Token: 0x04001259 RID: 4697
	[global::Cpp2ILInjected.Token(Token = "0x400170E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public bool DrawEmptySlots;

	// Token: 0x0400125A RID: 4698
	[global::Cpp2ILInjected.Token(Token = "0x400170F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout DisabledBacking;

	// Token: 0x0400125B RID: 4699
	[global::Cpp2ILInjected.Token(Token = "0x4001710")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Color DisabledBackingColor;

	// Token: 0x0400125C RID: 4700
	[global::Cpp2ILInjected.Token(Token = "0x4001711")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400125D RID: 4701
	[global::Cpp2ILInjected.Token(Token = "0x4001712")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color DisabledBackingIconColor;

	// Token: 0x0400125E RID: 4702
	[global::Cpp2ILInjected.Token(Token = "0x4001713")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGrid;

	// Token: 0x0400125F RID: 4703
	[global::Cpp2ILInjected.Token(Token = "0x4001714")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public DraggableItemGrid_Layout HorizontalReforgeItemGridCollapsed;

	// Token: 0x04001260 RID: 4704
	[global::Cpp2ILInjected.Token(Token = "0x4001715")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public DraggableItemGrid_Layout ReforgeItemGrid;

	// Token: 0x04001261 RID: 4705
	[global::Cpp2ILInjected.Token(Token = "0x4001716")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public DraggableItemGrid_Layout ReforgeItemGridCollapsed;

	// Token: 0x04001262 RID: 4706
	[global::Cpp2ILInjected.Token(Token = "0x4001717")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout ReforgeButton;
}
