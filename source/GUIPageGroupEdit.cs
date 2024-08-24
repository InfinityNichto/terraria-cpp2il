using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;

// Token: 0x020001D9 RID: 473
[global::Cpp2ILInjected.Token(Token = "0x2000274")]
public class GUIPageGroupEdit
{
	// Token: 0x06000CF1 RID: 3313 RVA: 0x00024218 File Offset: 0x00022418
	[global::Cpp2ILInjected.Token(Token = "0x6000E10")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1D50", Offset = "0x9F1D50", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private int SortSettings(GUIPageIconGrouping.SettingCategory x, GUIPageIconGrouping.SettingCategory y)
	{
		throw null;
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x0002421B File Offset: 0x0002241B
	[global::Cpp2ILInjected.Token(Token = "0x6000E11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1E10", Offset = "0x9F1E10", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private int SortCategories(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		throw null;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0002421E File Offset: 0x0002241E
	[global::Cpp2ILInjected.Token(Token = "0x6000E12")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1E9C", Offset = "0x9F1E9C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public Rectangle GetRegion()
	{
		throw null;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00024221 File Offset: 0x00022421
	[global::Cpp2ILInjected.Token(Token = "0x6000E13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2024", Offset = "0x9F2024", Length = "0xA60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Vector2),
		typeof(Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00024224 File Offset: 0x00022424
	[global::Cpp2ILInjected.Token(Token = "0x6000E14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2AF0", Offset = "0x9F2AF0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	private float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00024227 File Offset: 0x00022427
	[global::Cpp2ILInjected.Token(Token = "0x6000E15")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2B08", Offset = "0x9F2B08", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0002422A File Offset: 0x0002242A
	[global::Cpp2ILInjected.Token(Token = "0x6000E16")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2B10", Offset = "0x9F2B10", Length = "0x260")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Remove", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DisableCategory(GUIPageIcons.Category cat)
	{
		throw null;
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0002422D File Offset: 0x0002242D
	[global::Cpp2ILInjected.Token(Token = "0x6000E17")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2D70", Offset = "0x9F2D70", Length = "0x260")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Remove", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DisableSetting(GUIPageIconGrouping.SettingCategory cat)
	{
		throw null;
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00024230 File Offset: 0x00022430
	[global::Cpp2ILInjected.Token(Token = "0x6000E18")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2FD0", Offset = "0x9F2FD0", Length = "0x9AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Contains", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Settings_Layout), Member = "get_Instance", ReturnType = typeof(Settings_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetItemNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "DisableCategory", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Remove", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "DisableSetting", MemberParameters = new object[] { typeof(GUIPageIconGrouping.SettingCategory) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<Int32Enum>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<Int32Enum>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00024233 File Offset: 0x00022433
	[global::Cpp2ILInjected.Token(Token = "0x6000E19")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F2A84", Offset = "0x9F2A84", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "IsOverGroupOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00024236 File Offset: 0x00022436
	[global::Cpp2ILInjected.Token(Token = "0x6000E1A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F397C", Offset = "0x9F397C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private bool IsOverGroupOptions(Vector2 position)
	{
		throw null;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00024239 File Offset: 0x00022439
	[global::Cpp2ILInjected.Token(Token = "0x6000E1B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F3A40", Offset = "0x9F3A40", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public GUIPageGroupEdit()
	{
		throw null;
	}

	// Token: 0x040014B2 RID: 5298
	[global::Cpp2ILInjected.Token(Token = "0x40019BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool LastHorizontal;

	// Token: 0x040014B3 RID: 5299
	[global::Cpp2ILInjected.Token(Token = "0x40019BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool Enabled;

	// Token: 0x040014B4 RID: 5300
	[global::Cpp2ILInjected.Token(Token = "0x40019BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private List<GUIPageIcons.Category> PageOptions;

	// Token: 0x040014B5 RID: 5301
	[global::Cpp2ILInjected.Token(Token = "0x40019BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private List<GUIPageIconGrouping.SettingCategory> SettingOptions;

	// Token: 0x040014B6 RID: 5302
	[global::Cpp2ILInjected.Token(Token = "0x40019C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 toggleSize;

	// Token: 0x040014B7 RID: 5303
	[global::Cpp2ILInjected.Token(Token = "0x40019C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int hoverItem;

	// Token: 0x040014B8 RID: 5304
	[global::Cpp2ILInjected.Token(Token = "0x40019C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private bool CanOptionBeAdded;

	// Token: 0x040014B9 RID: 5305
	[global::Cpp2ILInjected.Token(Token = "0x40019C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040014BA RID: 5306
	[global::Cpp2ILInjected.Token(Token = "0x40019C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Rectangle popupRegion;
}
