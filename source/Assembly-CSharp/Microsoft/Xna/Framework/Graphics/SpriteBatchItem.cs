using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002C3 RID: 707
	[global::Cpp2ILInjected.Token(Token = "0x200038F")]
	public class SpriteBatchItem
	{
		// Token: 0x060016DD RID: 5853 RVA: 0x00025F01 File Offset: 0x00024101
		[global::Cpp2ILInjected.Token(Token = "0x600184D")]
		[global::Cpp2ILInjected.Address(RVA = "0xABF920", Offset = "0xABF920", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "PushExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void PushExpandedClippingRegion()
		{
			throw null;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00025F04 File Offset: 0x00024104
		[global::Cpp2ILInjected.Token(Token = "0x600184E")]
		[global::Cpp2ILInjected.Address(RVA = "0xABF9A4", Offset = "0xABF9A4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "PopExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void PopExpandedClippingRegion()
		{
			throw null;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00025F07 File Offset: 0x00024107
		[global::Cpp2ILInjected.Token(Token = "0x600184F")]
		[global::Cpp2ILInjected.Address(RVA = "0xABFA28", Offset = "0xABFA28", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "ClippedDrawItemHandler", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPanel), Member = "DrawHorizontalFill", MemberParameters = new object[]
		{
			typeof(Panel_Layout),
			typeof(Rectangle),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawDedicated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TransactionButton_Layout),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TransactionButton_Layout),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = ".ctor", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionInner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionOuter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void EnableClipping(Rectangle inner, Rectangle outer, SpriteBatch batcher, bool vertical)
		{
			throw null;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00025F0A File Offset: 0x0002410A
		[global::Cpp2ILInjected.Token(Token = "0x6001850")]
		[global::Cpp2ILInjected.Address(RVA = "0xABFBF0", Offset = "0xABFBF0", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawSelectedPlayerImage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RubbleItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerHead", MemberParameters = new object[]
		{
			typeof(global::Terraria.Graphics.Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = ".ctor", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(ref Rectangle),
			typeof(ref Rectangle),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionInner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetGeometryScale", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionOuter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionOuter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void PushClippedImageRegion(Rectangle region, SpriteBatch batcher, bool enableGeometryScale, Vector2 geometryScaleCentre, float geometryScale)
		{
			throw null;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00025F0D File Offset: 0x0002410D
		[global::Cpp2ILInjected.Token(Token = "0x6001851")]
		[global::Cpp2ILInjected.Address(RVA = "0xABFF48", Offset = "0xABFF48", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawSelectedPlayerImage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "RubbleItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerHead", MemberParameters = new object[]
		{
			typeof(global::Terraria.Graphics.Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetGeometryScale", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipState", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionInner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetClipRegionOuter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void PopClippedImageRegion()
		{
			throw null;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00025F10 File Offset: 0x00024110
		[global::Cpp2ILInjected.Token(Token = "0x6001852")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC0100", Offset = "0xAC0100", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "ClippedDrawItemHandler", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPanel), Member = "DrawHorizontalFill", MemberParameters = new object[]
		{
			typeof(Panel_Layout),
			typeof(Rectangle),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawDedicated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TransactionButton_Layout),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "DrawMenuButton", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TransactionButton_Layout),
			typeof(ref float),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DisabledClipping()
		{
			throw null;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00025F13 File Offset: 0x00024113
		[global::Cpp2ILInjected.Token(Token = "0x6001853")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC0158", Offset = "0xAC0158", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = ".ctor", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "SetGeometryOffset", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void SetGeometryOffset(SpriteBatch batcher, bool enabled, Vector2 offset)
		{
			throw null;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00025F16 File Offset: 0x00024116
		[global::Cpp2ILInjected.Token(Token = "0x6001854")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDC84", Offset = "0xABDC84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpriteBatchItem()
		{
			throw null;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00025F19 File Offset: 0x00024119
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001855")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC024C", Offset = "0xAC024C", Length = "0xA98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Offset", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
			throw null;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00025F1C File Offset: 0x0002411C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001856")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC0CE4", Offset = "0xAC0CE4", Length = "0xA38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Offset", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Set(float x, float y, float dx, float dy, float w, float h, float sin, float cos, ref VertexColors colors, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
			throw null;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00025F1F File Offset: 0x0002411F
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001857")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC171C", Offset = "0xAC171C", Length = "0x9E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Offset", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Set(float x, float y, float w, float h, ref Color color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
			throw null;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00025F22 File Offset: 0x00024122
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001858")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2104", Offset = "0xAC2104", Length = "0x98C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref VertexColors),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Offset", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Set(float x, float y, float w, float h, ref VertexColors color, ref Vector2 texCoordTL, ref Vector2 texCoordBR)
		{
			throw null;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00025F25 File Offset: 0x00024125
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001859")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC2A90", Offset = "0xAC2A90", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SpriteBatchItem()
		{
			throw null;
		}

		// Token: 0x04002044 RID: 8260
		[global::Cpp2ILInjected.Token(Token = "0x400268D")]
		private const float uvFixupOffset = 0.031f;

		// Token: 0x04002045 RID: 8261
		[global::Cpp2ILInjected.Token(Token = "0x400268E")]
		private static bool clippingPushedEnabledBackup;

		// Token: 0x04002046 RID: 8262
		[global::Cpp2ILInjected.Token(Token = "0x400268F")]
		private static bool clippingVerticalBackup;

		// Token: 0x04002047 RID: 8263
		[global::Cpp2ILInjected.Token(Token = "0x4002690")]
		private static bool clippingHorzontalBackup;

		// Token: 0x04002048 RID: 8264
		[global::Cpp2ILInjected.Token(Token = "0x4002691")]
		private static Rectangle clippingPushedInnerBackup;

		// Token: 0x04002049 RID: 8265
		[global::Cpp2ILInjected.Token(Token = "0x4002692")]
		private static Rectangle clippingPushedOuterBackup;

		// Token: 0x0400204A RID: 8266
		[global::Cpp2ILInjected.Token(Token = "0x4002693")]
		public static bool clippingEnabled;

		// Token: 0x0400204B RID: 8267
		[global::Cpp2ILInjected.Token(Token = "0x4002694")]
		public static bool geometryOffsetEnabled;

		// Token: 0x0400204C RID: 8268
		[global::Cpp2ILInjected.Token(Token = "0x4002695")]
		private static bool clippingVertical;

		// Token: 0x0400204D RID: 8269
		[global::Cpp2ILInjected.Token(Token = "0x4002696")]
		private static bool clippingHorzontal;

		// Token: 0x0400204E RID: 8270
		[global::Cpp2ILInjected.Token(Token = "0x4002697")]
		private static Rectangle clippingInner;

		// Token: 0x0400204F RID: 8271
		[global::Cpp2ILInjected.Token(Token = "0x4002698")]
		public static Rectangle clippingOuter;

		// Token: 0x04002050 RID: 8272
		[global::Cpp2ILInjected.Token(Token = "0x4002699")]
		private static SpriteBatch clippingBatch;

		// Token: 0x04002051 RID: 8273
		[global::Cpp2ILInjected.Token(Token = "0x400269A")]
		private static Clipper clipperObject;

		// Token: 0x04002052 RID: 8274
		[global::Cpp2ILInjected.Token(Token = "0x400269B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int BatchKey;

		// Token: 0x04002053 RID: 8275
		[global::Cpp2ILInjected.Token(Token = "0x400269C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Texture2D Texture;

		// Token: 0x04002054 RID: 8276
		[global::Cpp2ILInjected.Token(Token = "0x400269D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002055 RID: 8277
		[global::Cpp2ILInjected.Token(Token = "0x400269E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public SpriteBatchItem NextBatchItem;

		// Token: 0x04002056 RID: 8278
		[global::Cpp2ILInjected.Token(Token = "0x400269F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public SpriteBatcher.VertexData vertexTL;

		// Token: 0x04002057 RID: 8279
		[global::Cpp2ILInjected.Token(Token = "0x40026A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public SpriteBatcher.VertexData vertexTR;

		// Token: 0x04002058 RID: 8280
		[global::Cpp2ILInjected.Token(Token = "0x40026A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public SpriteBatcher.VertexData vertexBL;

		// Token: 0x04002059 RID: 8281
		[global::Cpp2ILInjected.Token(Token = "0x40026A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public SpriteBatcher.VertexData vertexBR;

		// Token: 0x0400205A RID: 8282
		[global::Cpp2ILInjected.Token(Token = "0x40026A3")]
		public static float ColourScale;

		// Token: 0x0400205B RID: 8283
		[global::Cpp2ILInjected.Token(Token = "0x40026A4")]
		public static bool EnableMaterialTrimming;

		// Token: 0x0400205C RID: 8284
		[global::Cpp2ILInjected.Token(Token = "0x40026A5")]
		public static Vector2 MaterialTrimmingMin;

		// Token: 0x0400205D RID: 8285
		[global::Cpp2ILInjected.Token(Token = "0x40026A6")]
		public static Vector2 MaterialTrimmingMax;
	}
}
