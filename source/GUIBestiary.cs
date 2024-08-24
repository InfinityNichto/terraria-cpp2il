using System;
using System.Collections.Generic;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI.Elements;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000C9 RID: 201
[global::Cpp2ILInjected.Token(Token = "0x2000123")]
public class GUIBestiary
{
	// Token: 0x0600065A RID: 1626 RVA: 0x00022E53 File Offset: 0x00021053
	[global::Cpp2ILInjected.Token(Token = "0x600074D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1316798", Offset = "0x1316798", Length = "0x7D4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<object, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 81)]
	public GUIBestiary()
	{
		throw null;
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00022E56 File Offset: 0x00021056
	[global::Cpp2ILInjected.Token(Token = "0x600074E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1316F6C", Offset = "0x1316F6C", Length = "0x364")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public static void LoadContent()
	{
		throw null;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00022E59 File Offset: 0x00021059
	[global::Cpp2ILInjected.Token(Token = "0x600074F")]
	[global::Cpp2ILInjected.Address(RVA = "0x13172D0", Offset = "0x13172D0", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void DrawButton()
	{
		throw null;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00022E5C File Offset: 0x0002105C
	[global::Cpp2ILInjected.Token(Token = "0x6000750")]
	[global::Cpp2ILInjected.Address(RVA = "0x13173D4", Offset = "0x13173D4", Length = "0x830")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Center", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetDisplayIndex", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(IBestiaryEntryDisplayIndex))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private void NPCDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00022E5F File Offset: 0x0002105F
	[global::Cpp2ILInjected.Token(Token = "0x6000751")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317CB0", Offset = "0x1317CB0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float NPCScale(int index)
	{
		throw null;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00022E62 File Offset: 0x00021062
	[global::Cpp2ILInjected.Token(Token = "0x6000752")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317CFC", Offset = "0x1317CFC", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSearchInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshSelectedStats", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "SelectNPCEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void NPCOver(int index)
	{
		throw null;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00022E65 File Offset: 0x00021065
	[global::Cpp2ILInjected.Token(Token = "0x6000753")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317EB8", Offset = "0x1317EB8", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inFancyUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00022E68 File Offset: 0x00021068
	[global::Cpp2ILInjected.Token(Token = "0x6000754")]
	[global::Cpp2ILInjected.Address(RVA = "0x13181F8", Offset = "0x13181F8", Length = "0xA34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilterSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "FilterOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "OrderDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshSelectedStats", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
	private void RefreshEntries()
	{
		throw null;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00022E6B File Offset: 0x0002106B
	[global::Cpp2ILInjected.Token(Token = "0x6000755")]
	[global::Cpp2ILInjected.Address(RVA = "0x1318C2C", Offset = "0x1318C2C", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private int SortCompare(BestiaryEntry x, BestiaryEntry y)
	{
		throw null;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00022E6E File Offset: 0x0002106E
	[global::Cpp2ILInjected.Token(Token = "0x6000756")]
	[global::Cpp2ILInjected.Address(RVA = "0x1318DE0", Offset = "0x1318DE0", Length = "0x4F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "clrInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSearchInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DrawFilterSearch()
	{
		throw null;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00022E71 File Offset: 0x00021071
	[global::Cpp2ILInjected.Token(Token = "0x6000757")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317E20", Offset = "0x1317E20", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilterSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "FilterOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void CloseSearchInput()
	{
		throw null;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00022E74 File Offset: 0x00021074
	[global::Cpp2ILInjected.Token(Token = "0x6000758")]
	[global::Cpp2ILInjected.Address(RVA = "0x13192D4", Offset = "0x13192D4", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilterSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.BySearch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void SetSearchTerm(string term)
	{
		throw null;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00022E77 File Offset: 0x00021077
	[global::Cpp2ILInjected.Token(Token = "0x6000759")]
	[global::Cpp2ILInjected.Address(RVA = "0x13193D0", Offset = "0x13193D0", Length = "0x11C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Open()
	{
		throw null;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00022E7A File Offset: 0x0002107A
	[global::Cpp2ILInjected.Token(Token = "0x600075A")]
	[global::Cpp2ILInjected.Address(RVA = "0x13196CC", Offset = "0x13196CC", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private bool IsOverLoot(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00022E7D File Offset: 0x0002107D
	[global::Cpp2ILInjected.Token(Token = "0x600075B")]
	[global::Cpp2ILInjected.Address(RVA = "0x13197D4", Offset = "0x13197D4", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private bool IsOverOrders(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00022E80 File Offset: 0x00021080
	[global::Cpp2ILInjected.Token(Token = "0x600075C")]
	[global::Cpp2ILInjected.Address(RVA = "0x13198DC", Offset = "0x13198DC", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private bool IsOverFilters(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00022E83 File Offset: 0x00021083
	[global::Cpp2ILInjected.Token(Token = "0x600075D")]
	[global::Cpp2ILInjected.Address(RVA = "0x13199E4", Offset = "0x13199E4", Length = "0x688")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetDropProviders", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(List<ItemDropBestiaryInfoElement>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCStatsInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NPCStatsReportInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType0<>), Member = ".ctor", MemberParameters = new object[] { "<Count>j__TPar" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object),
		typeof(StringBuilder)
	}, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "ActivateDrops", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawCoins", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	private void DrawLootDrops()
	{
		throw null;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00022E86 File Offset: 0x00021086
	[global::Cpp2ILInjected.Token(Token = "0x600075E")]
	[global::Cpp2ILInjected.Address(RVA = "0x131A638", Offset = "0x131A638", Length = "0x334")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawHorizontalFill", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Rectangle),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	private void DrawProgressBar()
	{
		throw null;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00022E89 File Offset: 0x00021089
	[global::Cpp2ILInjected.Token(Token = "0x600075F")]
	[global::Cpp2ILInjected.Address(RVA = "0x13194EC", Offset = "0x13194EC", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void RefreshPercentUnlocked()
	{
		throw null;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00022E8C File Offset: 0x0002108C
	[global::Cpp2ILInjected.Token(Token = "0x6000760")]
	[global::Cpp2ILInjected.Address(RVA = "0x131A96C", Offset = "0x131A96C", Length = "0x628")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetMainMenuPageRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawProgressBar", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00022E8F File Offset: 0x0002108F
	[global::Cpp2ILInjected.Token(Token = "0x6000761")]
	[global::Cpp2ILInjected.Address(RVA = "0x131C694", Offset = "0x131C694", Length = "0x2A0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void FilterDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00022E92 File Offset: 0x00021092
	[global::Cpp2ILInjected.Token(Token = "0x6000762")]
	[global::Cpp2ILInjected.Address(RVA = "0x131C934", Offset = "0x131C934", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSearchInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "SelectFilterEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void FilterOver(int index)
	{
		throw null;
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00022E95 File Offset: 0x00021095
	[global::Cpp2ILInjected.Token(Token = "0x6000763")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CAAC", Offset = "0x131CAAC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float FilterScale(int index)
	{
		throw null;
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00022E98 File Offset: 0x00021098
	[global::Cpp2ILInjected.Token(Token = "0x6000764")]
	[global::Cpp2ILInjected.Address(RVA = "0x131BA8C", Offset = "0x131BA8C", Length = "0x584")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType0<>), Member = ".ctor", MemberParameters = new object[] { "<Count>j__TPar" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object),
		typeof(StringBuilder)
	}, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "ActivateFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawFilterSearch", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	private void DrawFilters()
	{
		throw null;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00022E9B File Offset: 0x0002109B
	[global::Cpp2ILInjected.Token(Token = "0x6000765")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CAB4", Offset = "0x131CAB4", Length = "0x214")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void OrderDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00022E9E File Offset: 0x0002109E
	[global::Cpp2ILInjected.Token(Token = "0x6000766")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CCC8", Offset = "0x131CCC8", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void OrderOver(int index)
	{
		throw null;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00022EA1 File Offset: 0x000210A1
	[global::Cpp2ILInjected.Token(Token = "0x6000767")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CD70", Offset = "0x131CD70", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float OrderScale(int index)
	{
		throw null;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00022EA4 File Offset: 0x000210A4
	[global::Cpp2ILInjected.Token(Token = "0x6000768")]
	[global::Cpp2ILInjected.Address(RVA = "0x131C010", Offset = "0x131C010", Length = "0x684")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseSortOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "CloseLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "ActivateOrders", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private void DrawOrders()
	{
		throw null;
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00022EA7 File Offset: 0x000210A7
	[global::Cpp2ILInjected.Token(Token = "0x6000769")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CD78", Offset = "0x131CD78", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private NamePlateInfoElement GetName(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00022EAA File Offset: 0x000210AA
	[global::Cpp2ILInjected.Token(Token = "0x600076A")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317C04", Offset = "0x1317C04", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private IBestiaryEntryDisplayIndex GetDisplayIndex(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00022EAD File Offset: 0x000210AD
	[global::Cpp2ILInjected.Token(Token = "0x600076B")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CE48", Offset = "0x131CE48", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private NPCPortraitInfoElement GetNPCPortraitInfo(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00022EB0 File Offset: 0x000210B0
	[global::Cpp2ILInjected.Token(Token = "0x600076C")]
	[global::Cpp2ILInjected.Address(RVA = "0x131A1F8", Offset = "0x131A1F8", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "RefreshSelectedStats", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawCoins", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private NPCStatsReportInfoElement GetNPCStatsInfo(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00022EB3 File Offset: 0x000210B3
	[global::Cpp2ILInjected.Token(Token = "0x600076D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1317E90", Offset = "0x1317E90", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "RefreshEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCStatsInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NPCStatsReportInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "Refresh", ReturnType = typeof(void))]
	private void RefreshSelectedStats()
	{
		throw null;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00022EB6 File Offset: 0x000210B6
	[global::Cpp2ILInjected.Token(Token = "0x600076E")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CF18", Offset = "0x131CF18", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private FlavorTextBestiaryInfoElement GetNPCFlavourInfo(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00022EB9 File Offset: 0x000210B9
	[global::Cpp2ILInjected.Token(Token = "0x600076F")]
	[global::Cpp2ILInjected.Address(RVA = "0x131CFE8", Offset = "0x131CFE8", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "UpdateBackgroundImages", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private IPreferenceProviderElement GetPreferenceProvider(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00022EBC File Offset: 0x000210BC
	[global::Cpp2ILInjected.Token(Token = "0x6000770")]
	[global::Cpp2ILInjected.Address(RVA = "0x131D094", Offset = "0x131D094", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "UpdateBackgroundImages", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private List<IBestiaryBackgroundImagePathAndColorProvider> GetBackgroundImageProviders(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00022EBF File Offset: 0x000210BF
	[global::Cpp2ILInjected.Token(Token = "0x6000771")]
	[global::Cpp2ILInjected.Address(RVA = "0x131D248", Offset = "0x131D248", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "UpdateBackgroundImages", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private List<IBestiaryBackgroundOverlayAndColorProvider> GetBackgroundOverlayProviders(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00022EC2 File Offset: 0x000210C2
	[global::Cpp2ILInjected.Token(Token = "0x6000772")]
	[global::Cpp2ILInjected.Address(RVA = "0x131D478", Offset = "0x131D478", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private int SortBackgroundOverlayElements(IBestiaryBackgroundOverlayAndColorProvider x, IBestiaryBackgroundOverlayAndColorProvider y)
	{
		throw null;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00022EC5 File Offset: 0x000210C5
	[global::Cpp2ILInjected.Token(Token = "0x6000773")]
	[global::Cpp2ILInjected.Address(RVA = "0x131D590", Offset = "0x131D590", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private List<FilterProviderInfoElement> GetFilterProviders(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00022EC8 File Offset: 0x000210C8
	[global::Cpp2ILInjected.Token(Token = "0x6000774")]
	[global::Cpp2ILInjected.Address(RVA = "0x131A06C", Offset = "0x131A06C", Length = "0x18C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemDropBestiaryInfoElement), Member = "ShouldShowItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private List<ItemDropBestiaryInfoElement> GetDropProviders(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00022ECB File Offset: 0x000210CB
	[global::Cpp2ILInjected.Token(Token = "0x6000775")]
	[global::Cpp2ILInjected.Address(RVA = "0x131D708", Offset = "0x131D708", Length = "0x910")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawImageBackgrounds", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(BestiaryEntry)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetPreferenceProvider", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(IPreferenceProviderElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetBackgroundImageProviders", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(List<IBestiaryBackgroundImagePathAndColorProvider>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = "get_Value", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetBackgroundOverlayProviders", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(List<IBestiaryBackgroundOverlayAndColorProvider>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "Lerp", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
	private void UpdateBackgroundImages(BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00022ECE File Offset: 0x000210CE
	[global::Cpp2ILInjected.Token(Token = "0x6000776")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E018", Offset = "0x131E018", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "UpdateBackgroundImages", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void DrawImageBackgrounds(Rectangle region, BestiaryEntry entry)
	{
		throw null;
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00022ED1 File Offset: 0x000210D1
	[global::Cpp2ILInjected.Token(Token = "0x6000777")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E100", Offset = "0x131E100", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private float StarScale(int index)
	{
		throw null;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00022ED4 File Offset: 0x000210D4
	[global::Cpp2ILInjected.Token(Token = "0x6000778")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E14C", Offset = "0x131E14C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void StarOver(int index)
	{
		throw null;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00022ED7 File Offset: 0x000210D7
	[global::Cpp2ILInjected.Token(Token = "0x6000779")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E150", Offset = "0x131E150", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00022EDA File Offset: 0x000210DA
	[global::Cpp2ILInjected.Token(Token = "0x600077A")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E388", Offset = "0x131E388", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float DropScale(int index)
	{
		throw null;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00022EDD File Offset: 0x000210DD
	[global::Cpp2ILInjected.Token(Token = "0x600077B")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E390", Offset = "0x131E390", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void DropOver(int index)
	{
		throw null;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00022EE0 File Offset: 0x000210E0
	[global::Cpp2ILInjected.Token(Token = "0x600077C")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E46C", Offset = "0x131E46C", Length = "0x2A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DropDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
	{
		typeof(string),
		typeof(IEnumerable<string>)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private void SetBestiaryNotesOnItemCache(DropRateInfo info)
	{
		throw null;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00022EE3 File Offset: 0x000210E3
	[global::Cpp2ILInjected.Token(Token = "0x600077D")]
	[global::Cpp2ILInjected.Address(RVA = "0x131E714", Offset = "0x131E714", Length = "0x4D0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryInfoItemLine), Member = "GetDropInfo", MemberParameters = new object[]
	{
		typeof(DropRateInfo),
		typeof(BestiaryUICollectionInfo),
		typeof(ref string),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "GetUICursorPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "SetBestiaryNotesOnItemCache", MemberParameters = new object[] { typeof(DropRateInfo) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_overloadedMousePositionX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_overloadedMousePositionX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_overloadedMousePositionY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "UpdateTooltipContext", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(byte),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DropDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00022EE6 File Offset: 0x000210E6
	[global::Cpp2ILInjected.Token(Token = "0x600077E")]
	[global::Cpp2ILInjected.Address(RVA = "0x131EBE4", Offset = "0x131EBE4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float SpawnScale(int index)
	{
		throw null;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00022EE9 File Offset: 0x000210E9
	[global::Cpp2ILInjected.Token(Token = "0x600077F")]
	[global::Cpp2ILInjected.Address(RVA = "0x131EBEC", Offset = "0x131EBEC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void SpawnOver(int index)
	{
		throw null;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00022EEC File Offset: 0x000210EC
	[global::Cpp2ILInjected.Token(Token = "0x6000780")]
	[global::Cpp2ILInjected.Address(RVA = "0x131EBF0", Offset = "0x131EBF0", Length = "0x2E8")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void SpawnDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00022EEF File Offset: 0x000210EF
	[global::Cpp2ILInjected.Token(Token = "0x6000781")]
	[global::Cpp2ILInjected.Address(RVA = "0x131A2C8", Offset = "0x131A2C8", Length = "0x370")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCStatsInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NPCStatsReportInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CoinsSplit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void DrawCoins()
	{
		throw null;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00022EF2 File Offset: 0x000210F2
	[global::Cpp2ILInjected.Token(Token = "0x6000782")]
	[global::Cpp2ILInjected.Address(RVA = "0x131AF94", Offset = "0x131AF94", Length = "0xAF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetName", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NamePlateInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamePlateInfoElement), Member = "GetName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "DrawImageBackgrounds", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(BestiaryEntry)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Center", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCPortraitInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NPCPortraitInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCPortraitInfoElement), Member = "GetStarCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCStatsInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(NPCStatsReportInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKillsTracker), Member = "GetKillCount", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetFilterProviders", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(List<FilterProviderInfoElement>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "GetNPCFlavourInfo", MemberParameters = new object[] { typeof(BestiaryEntry) }, ReturnType = typeof(FlavorTextBestiaryInfoElement))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
	private void DrawSelectedEntry()
	{
		throw null;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00022EF5 File Offset: 0x000210F5
	[global::Cpp2ILInjected.Token(Token = "0x6000783")]
	[global::Cpp2ILInjected.Address(RVA = "0x1318174", Offset = "0x1318174", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "DeactivateDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void CloseLootDrops()
	{
		throw null;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00022EF8 File Offset: 0x000210F8
	[global::Cpp2ILInjected.Token(Token = "0x6000784")]
	[global::Cpp2ILInjected.Address(RVA = "0x131806C", Offset = "0x131806C", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "DeactivateFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void CloseFilters()
	{
		throw null;
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00022EFB File Offset: 0x000210FB
	[global::Cpp2ILInjected.Token(Token = "0x6000785")]
	[global::Cpp2ILInjected.Address(RVA = "0x13180F0", Offset = "0x13180F0", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawLootDrops", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "OrderDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerBestiary), Member = "DeactivateOrders", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void CloseSortOrder()
	{
		throw null;
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00022EFE File Offset: 0x000210FE
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000786")]
	[global::Cpp2ILInjected.Address(RVA = "0x131EED8", Offset = "0x131EED8", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIBestiary()
	{
		throw null;
	}

	// Token: 0x040003BE RID: 958
	[global::Cpp2ILInjected.Token(Token = "0x40005B6")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D lockedIcon;

	// Token: 0x040003BF RID: 959
	[global::Cpp2ILInjected.Token(Token = "0x40005B7")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D iconRankLight;

	// Token: 0x040003C0 RID: 960
	[global::Cpp2ILInjected.Token(Token = "0x40005B8")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D iconRankDim;

	// Token: 0x040003C1 RID: 961
	[global::Cpp2ILInjected.Token(Token = "0x40005B9")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D iconTagsShadow;

	// Token: 0x040003C2 RID: 962
	[global::Cpp2ILInjected.Token(Token = "0x40005BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GUIControllerBestiary _controllerInput;

	// Token: 0x040003C3 RID: 963
	[global::Cpp2ILInjected.Token(Token = "0x40005BB")]
	private static Texture_Layout sortIconBackup;

	// Token: 0x040003C4 RID: 964
	[global::Cpp2ILInjected.Token(Token = "0x40005BC")]
	private static Texture_Layout sortIconBackup2;

	// Token: 0x040003C5 RID: 965
	[global::Cpp2ILInjected.Token(Token = "0x40005BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float bestiaryButtonScale;

	// Token: 0x040003C6 RID: 966
	[global::Cpp2ILInjected.Token(Token = "0x40005BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float TitleScale;

	// Token: 0x040003C7 RID: 967
	[global::Cpp2ILInjected.Token(Token = "0x40005BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float BackScale;

	// Token: 0x040003C8 RID: 968
	[global::Cpp2ILInjected.Token(Token = "0x40005C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIItemGrid.CursorOver npcItemOver;

	// Token: 0x040003C9 RID: 969
	[global::Cpp2ILInjected.Token(Token = "0x40005C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIItemGrid.GetItemScaleHandler npcScale;

	// Token: 0x040003CA RID: 970
	[global::Cpp2ILInjected.Token(Token = "0x40005C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private GUIItemGrid.DrawItemHandler npcDraw;

	// Token: 0x040003CB RID: 971
	[global::Cpp2ILInjected.Token(Token = "0x40005C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int EntryOver;

	// Token: 0x040003CC RID: 972
	[global::Cpp2ILInjected.Token(Token = "0x40005C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public BestiaryEntry SelectedEntry;

	// Token: 0x040003CD RID: 973
	[global::Cpp2ILInjected.Token(Token = "0x40005C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float ScrollOffset;

	// Token: 0x040003CE RID: 974
	[global::Cpp2ILInjected.Token(Token = "0x40005C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float ScrollMomentum;

	// Token: 0x040003CF RID: 975
	[global::Cpp2ILInjected.Token(Token = "0x40005C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int ScrollDragging;

	// Token: 0x040003D0 RID: 976
	[global::Cpp2ILInjected.Token(Token = "0x40005C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x040003D1 RID: 977
	[global::Cpp2ILInjected.Token(Token = "0x40005C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public List<BestiaryEntry> SortedEntries;

	// Token: 0x040003D2 RID: 978
	[global::Cpp2ILInjected.Token(Token = "0x40005CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	// Token: 0x040003D3 RID: 979
	[global::Cpp2ILInjected.Token(Token = "0x40005CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private bool editingSearch;

	// Token: 0x040003D4 RID: 980
	[global::Cpp2ILInjected.Token(Token = "0x40005CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private string searchTerm;

	// Token: 0x040003D5 RID: 981
	[global::Cpp2ILInjected.Token(Token = "0x40005CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private string editDisplaySearch;

	// Token: 0x040003D6 RID: 982
	[global::Cpp2ILInjected.Token(Token = "0x40005CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float BeginSearchScale;

	// Token: 0x040003D7 RID: 983
	[global::Cpp2ILInjected.Token(Token = "0x40005CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private ISearchFilter<BestiaryEntry> searchFilter;

	// Token: 0x040003D8 RID: 984
	[global::Cpp2ILInjected.Token(Token = "0x40005D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private int ActiveFilterCount;

	// Token: 0x040003D9 RID: 985
	[global::Cpp2ILInjected.Token(Token = "0x40005D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	private int SelectedSort;

	// Token: 0x040003DA RID: 986
	[global::Cpp2ILInjected.Token(Token = "0x40005D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public float LootScrollOffset;

	// Token: 0x040003DB RID: 987
	[global::Cpp2ILInjected.Token(Token = "0x40005D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private float LootScrollMomentum;

	// Token: 0x040003DC RID: 988
	[global::Cpp2ILInjected.Token(Token = "0x40005D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private int LootScrollDragging;

	// Token: 0x040003DD RID: 989
	[global::Cpp2ILInjected.Token(Token = "0x40005D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private Microsoft.Xna.Framework.Vector2 LootDragOffset;

	// Token: 0x040003DE RID: 990
	[global::Cpp2ILInjected.Token(Token = "0x40005D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public List<bool> filterEnabled;

	// Token: 0x040003DF RID: 991
	[global::Cpp2ILInjected.Token(Token = "0x40005D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private List<Microsoft.Xna.Framework.Graphics.Texture2D> filterTexture;

	// Token: 0x040003E0 RID: 992
	[global::Cpp2ILInjected.Token(Token = "0x40005D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private List<string> filterName;

	// Token: 0x040003E1 RID: 993
	[global::Cpp2ILInjected.Token(Token = "0x40005D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private List<Rectangle> filterFrame;

	// Token: 0x040003E2 RID: 994
	[global::Cpp2ILInjected.Token(Token = "0x40005DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private List<bool> filterAvailable;

	// Token: 0x040003E3 RID: 995
	[global::Cpp2ILInjected.Token(Token = "0x40005DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public bool Enabled;

	// Token: 0x040003E4 RID: 996
	[global::Cpp2ILInjected.Token(Token = "0x40005DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE9")]
	public bool OpenedFromInv;

	// Token: 0x040003E5 RID: 997
	[global::Cpp2ILInjected.Token(Token = "0x40005DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private GUIInputRegionExclusive _lootBlocker;

	// Token: 0x040003E6 RID: 998
	[global::Cpp2ILInjected.Token(Token = "0x40005DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	private int unlockedEntries;

	// Token: 0x040003E7 RID: 999
	[global::Cpp2ILInjected.Token(Token = "0x40005DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	private bool displayFilters;

	// Token: 0x040003E8 RID: 1000
	[global::Cpp2ILInjected.Token(Token = "0x40005E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFD")]
	private bool displayOrders;

	// Token: 0x040003E9 RID: 1001
	[global::Cpp2ILInjected.Token(Token = "0x40005E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	private float filtersScale;

	// Token: 0x040003EA RID: 1002
	[global::Cpp2ILInjected.Token(Token = "0x40005E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	private float ordersScale;

	// Token: 0x040003EB RID: 1003
	[global::Cpp2ILInjected.Token(Token = "0x40005E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	private GUIItemGrid.CursorOver filterItemOver;

	// Token: 0x040003EC RID: 1004
	[global::Cpp2ILInjected.Token(Token = "0x40005E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	private GUIItemGrid.GetItemScaleHandler filterScale;

	// Token: 0x040003ED RID: 1005
	[global::Cpp2ILInjected.Token(Token = "0x40005E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private GUIItemGrid.DrawItemHandler filterDraw;

	// Token: 0x040003EE RID: 1006
	[global::Cpp2ILInjected.Token(Token = "0x40005E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private int filterOver;

	// Token: 0x040003EF RID: 1007
	[global::Cpp2ILInjected.Token(Token = "0x40005E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	private GUIInputRegionExclusive _filterBlocker;

	// Token: 0x040003F0 RID: 1008
	[global::Cpp2ILInjected.Token(Token = "0x40005E8")]
	private static StringBuilder sb;

	// Token: 0x040003F1 RID: 1009
	[global::Cpp2ILInjected.Token(Token = "0x40005E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private GUIItemGrid.CursorOver orderItemOver;

	// Token: 0x040003F2 RID: 1010
	[global::Cpp2ILInjected.Token(Token = "0x40005EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private GUIItemGrid.GetItemScaleHandler orderScale;

	// Token: 0x040003F3 RID: 1011
	[global::Cpp2ILInjected.Token(Token = "0x40005EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	private GUIItemGrid.DrawItemHandler orderDraw;

	// Token: 0x040003F4 RID: 1012
	[global::Cpp2ILInjected.Token(Token = "0x40005EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private int orderOver;

	// Token: 0x040003F5 RID: 1013
	[global::Cpp2ILInjected.Token(Token = "0x40005ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	private GUIInputRegionExclusive _orderBlocker;

	// Token: 0x040003F6 RID: 1014
	[global::Cpp2ILInjected.Token(Token = "0x40005EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	private List<IBestiaryBackgroundImagePathAndColorProvider> BackgroundImageProviders;

	// Token: 0x040003F7 RID: 1015
	[global::Cpp2ILInjected.Token(Token = "0x40005EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	private List<IBestiaryBackgroundOverlayAndColorProvider> BackgroundOverlayProviders;

	// Token: 0x040003F8 RID: 1016
	[global::Cpp2ILInjected.Token(Token = "0x40005F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	private List<FilterProviderInfoElement> FilterProviders;

	// Token: 0x040003F9 RID: 1017
	[global::Cpp2ILInjected.Token(Token = "0x40005F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	private List<ItemDropBestiaryInfoElement> DropProviders;

	// Token: 0x040003FA RID: 1018
	[global::Cpp2ILInjected.Token(Token = "0x40005F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	private BestiaryEntry backgroundEntry;

	// Token: 0x040003FB RID: 1019
	[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	private int backgroundImageCount;

	// Token: 0x040003FC RID: 1020
	[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	private Microsoft.Xna.Framework.Graphics.Texture2D[] backgroundImage;

	// Token: 0x040003FD RID: 1021
	[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	private Microsoft.Xna.Framework.Graphics.Color[] backgroundColour;

	// Token: 0x040003FE RID: 1022
	[global::Cpp2ILInjected.Token(Token = "0x40005F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	private GUIItemGrid.CursorOver starOver;

	// Token: 0x040003FF RID: 1023
	[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	// Token: 0x04000400 RID: 1024
	[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	private GUIItemGrid.DrawItemHandler starDraw;

	// Token: 0x04000401 RID: 1025
	[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private int starCount;

	// Token: 0x04000402 RID: 1026
	[global::Cpp2ILInjected.Token(Token = "0x40005FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	private GUIItemGrid.CursorOver dropOver;

	// Token: 0x04000403 RID: 1027
	[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	private GUIItemGrid.GetItemScaleHandler dropScale;

	// Token: 0x04000404 RID: 1028
	[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	private GUIItemGrid.DrawItemHandler dropDraw;

	// Token: 0x04000405 RID: 1029
	[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	private int DropItemOver;

	// Token: 0x04000406 RID: 1030
	[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
	private int SelectedDropItem;

	// Token: 0x04000407 RID: 1031
	[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	private Item dropItemInfo;

	// Token: 0x04000408 RID: 1032
	[global::Cpp2ILInjected.Token(Token = "0x4000600")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	private int dropCount;

	// Token: 0x04000409 RID: 1033
	[global::Cpp2ILInjected.Token(Token = "0x4000601")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	private GUIItemGrid.CursorOver spawnOver;

	// Token: 0x0400040A RID: 1034
	[global::Cpp2ILInjected.Token(Token = "0x4000602")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	private GUIItemGrid.GetItemScaleHandler spawnScale;

	// Token: 0x0400040B RID: 1035
	[global::Cpp2ILInjected.Token(Token = "0x4000603")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	private GUIItemGrid.DrawItemHandler spawnDraw;

	// Token: 0x0400040C RID: 1036
	[global::Cpp2ILInjected.Token(Token = "0x4000604")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	private int spawnCount;

	// Token: 0x0400040D RID: 1037
	[global::Cpp2ILInjected.Token(Token = "0x4000605")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
	private bool drawLootDrops;

	// Token: 0x0400040E RID: 1038
	[global::Cpp2ILInjected.Token(Token = "0x4000606")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	private NPCStatsReportInfoElement dummyStatsInfo;
}
