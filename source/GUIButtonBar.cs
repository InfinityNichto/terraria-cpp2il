using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;

// Token: 0x020000CD RID: 205
[global::Cpp2ILInjected.Token(Token = "0x2000127")]
public class GUIButtonBar
{
	// Token: 0x060006AF RID: 1711 RVA: 0x00022F52 File Offset: 0x00021152
	[global::Cpp2ILInjected.Token(Token = "0x60007A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323484", Offset = "0x1323484", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public GUIButtonBar()
	{
		throw null;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00022F55 File Offset: 0x00021155
	[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323620", Offset = "0x1323620", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButtonBar), Member = "RefreshItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void AddAction(GUIButtonBar.Action action, ControllerActionButton bannerAction)
	{
		throw null;
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00022F58 File Offset: 0x00021158
	[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x13236A4", Offset = "0x13236A4", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButtonBar), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButtonBar), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIButtonBar.Action),
		typeof(ControllerActionButton)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void RefreshItems()
	{
		throw null;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00022F5B File Offset: 0x0002115B
	[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x13238C4", Offset = "0x13238C4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00022F5E File Offset: 0x0002115E
	[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323910", Offset = "0x1323910", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00022F61 File Offset: 0x00021161
	[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323914", Offset = "0x1323914", Length = "0x330")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButtonBar), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapReady", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private Texture2D GetButtonSetup(GUIButtonBar.Action action, int entry, out bool disabled, out string actionString, out TransactionButton_Layout buttonLayout)
	{
		throw null;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00022F64 File Offset: 0x00021164
	[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323C44", Offset = "0x1323C44", Length = "0x214")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButtonBar), Member = "GetButtonSetup", MemberParameters = new object[]
	{
		typeof(GUIButtonBar.Action),
		typeof(int),
		typeof(ref bool),
		typeof(ref string),
		typeof(ref TransactionButton_Layout)
	}, ReturnType = typeof(Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButtonBar), Member = "PerformAction", MemberParameters = new object[] { typeof(GUIButtonBar.Action) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00022F67 File Offset: 0x00021167
	[global::Cpp2ILInjected.Token(Token = "0x60007A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x1323E58", Offset = "0x1323E58", Length = "0x290")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButtonBar), Member = "ItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_playerInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatCornerItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreen", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_resetMapFull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(GUIPageIcons.Category)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void PerformAction(GUIButtonBar.Action action)
	{
		throw null;
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00022F6A File Offset: 0x0002116A
	[global::Cpp2ILInjected.Token(Token = "0x60007AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x13240E8", Offset = "0x13240E8", Length = "0x230")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButtonBar), Member = "RefreshItems", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStretched), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Stretched_Layout),
		typeof(Rectangle?),
		typeof(Color?)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x04000427 RID: 1063
	[global::Cpp2ILInjected.Token(Token = "0x400061F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int ItemCount;

	// Token: 0x04000428 RID: 1064
	[global::Cpp2ILInjected.Token(Token = "0x4000620")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIButtonBar.Action[] Items;

	// Token: 0x04000429 RID: 1065
	[global::Cpp2ILInjected.Token(Token = "0x4000621")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ControllerActionButton[] ItemsActions;

	// Token: 0x0400042A RID: 1066
	[global::Cpp2ILInjected.Token(Token = "0x4000622")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float[] Scale;

	// Token: 0x0400042B RID: 1067
	[global::Cpp2ILInjected.Token(Token = "0x4000623")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool Expanded;

	// Token: 0x0400042C RID: 1068
	[global::Cpp2ILInjected.Token(Token = "0x4000624")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	// Token: 0x0400042D RID: 1069
	[global::Cpp2ILInjected.Token(Token = "0x4000625")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GUIItemGrid.CursorOver itemOver;

	// Token: 0x0400042E RID: 1070
	[global::Cpp2ILInjected.Token(Token = "0x4000626")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	// Token: 0x020007BC RID: 1980
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	public enum Action
	{
		// Token: 0x040079DE RID: 31198
		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		ButtonBarToggle,
		// Token: 0x040079DF RID: 31199
		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		Chat,
		// Token: 0x040079E0 RID: 31200
		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		Tutorial,
		// Token: 0x040079E1 RID: 31201
		[global::Cpp2ILInjected.Token(Token = "0x400062B")]
		JourneyModeSettings,
		// Token: 0x040079E2 RID: 31202
		[global::Cpp2ILInjected.Token(Token = "0x400062C")]
		Housing,
		// Token: 0x040079E3 RID: 31203
		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		PVP,
		// Token: 0x040079E4 RID: 31204
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		Bestiary,
		// Token: 0x040079E5 RID: 31205
		[global::Cpp2ILInjected.Token(Token = "0x400062F")]
		MiniMapToggle,
		// Token: 0x040079E6 RID: 31206
		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		Map,
		// Token: 0x040079E7 RID: 31207
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		Duplication,
		// Token: 0x040079E8 RID: 31208
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		Count
	}
}
