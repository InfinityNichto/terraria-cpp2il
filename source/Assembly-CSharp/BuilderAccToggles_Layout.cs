using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011D RID: 285
[global::Cpp2ILInjected.Token(Token = "0x2000195")]
public class BuilderAccToggles_Layout : LayoutDefinition
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00023A23 File Offset: 0x00021C23
	[global::Cpp2ILInjected.Token(Token = "0x17000121")]
	public static BuilderAccToggles_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x9ABF10", Offset = "0x9ABF10", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerAmmo4Page), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "get_MaxRowIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "get_MaxColumnIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "GetInfoGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "SetupLayout", ReturnType = typeof(TransactionButton_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "IsOverBuilderTools", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00023A26 File Offset: 0x00021C26
	[global::Cpp2ILInjected.Token(Token = "0x17000122")]
	public ItemGrid_Layout ToggleOptionsGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x9ABF8C", Offset = "0x9ABF8C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "get_MaxRowIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "get_MaxColumnIndex", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory4Page), Member = "GetInfoGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00023A29 File Offset: 0x00021C29
	[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABFF8", Offset = "0x9ABFF8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00023A2C File Offset: 0x00021C2C
	[global::Cpp2ILInjected.Token(Token = "0x6000B5A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC07C", Offset = "0x9AC07C", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public BuilderAccToggles_Layout()
	{
		throw null;
	}

	// Token: 0x0400096F RID: 2415
	[global::Cpp2ILInjected.Token(Token = "0x4000C91")]
	public static BuilderAccToggles_Layout InstanceNormal;

	// Token: 0x04000970 RID: 2416
	[global::Cpp2ILInjected.Token(Token = "0x4000C92")]
	public static BuilderAccToggles_Layout Instance4Page;

	// Token: 0x04000971 RID: 2417
	[global::Cpp2ILInjected.Token(Token = "0x4000C93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout ControllerToggleBuilderAccessories;

	// Token: 0x04000972 RID: 2418
	[global::Cpp2ILInjected.Token(Token = "0x4000C94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout ToggleBuilderAccessories;

	// Token: 0x04000973 RID: 2419
	[global::Cpp2ILInjected.Token(Token = "0x4000C95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ToggleBuilderAccessories_Horizontal;

	// Token: 0x04000974 RID: 2420
	[global::Cpp2ILInjected.Token(Token = "0x4000C96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 BackingTLOffset;

	// Token: 0x04000975 RID: 2421
	[global::Cpp2ILInjected.Token(Token = "0x4000C97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 BackingBROffset;

	// Token: 0x04000976 RID: 2422
	[global::Cpp2ILInjected.Token(Token = "0x4000C98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout Backing;

	// Token: 0x04000977 RID: 2423
	[global::Cpp2ILInjected.Token(Token = "0x4000C99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float ToggleScale;

	// Token: 0x04000978 RID: 2424
	[global::Cpp2ILInjected.Token(Token = "0x4000C9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float ToggleIconScale;

	// Token: 0x04000979 RID: 2425
	[global::Cpp2ILInjected.Token(Token = "0x4000C9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout ToggleOptions;

	// Token: 0x0400097A RID: 2426
	[global::Cpp2ILInjected.Token(Token = "0x4000C9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ItemGrid_Layout ToggleOptions_Horizontal;

	// Token: 0x0400097B RID: 2427
	[global::Cpp2ILInjected.Token(Token = "0x4000C9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ToggleEntry;

	// Token: 0x0400097C RID: 2428
	[global::Cpp2ILInjected.Token(Token = "0x4000C9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout AccBackingTexture;

	// Token: 0x0400097D RID: 2429
	[global::Cpp2ILInjected.Token(Token = "0x4000C9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Color AccBackingColour;

	// Token: 0x0400097E RID: 2430
	[global::Cpp2ILInjected.Token(Token = "0x4000CA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout AccHighlightTexture;

	// Token: 0x0400097F RID: 2431
	[global::Cpp2ILInjected.Token(Token = "0x4000CA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Color AccHighlightColour;

	// Token: 0x04000980 RID: 2432
	[global::Cpp2ILInjected.Token(Token = "0x4000CA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public FadeString_Layout TooltipDisplay;
}
