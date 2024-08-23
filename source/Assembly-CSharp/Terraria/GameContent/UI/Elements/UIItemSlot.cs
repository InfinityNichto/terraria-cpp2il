using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006CD RID: 1741
	[global::Cpp2ILInjected.Token(Token = "0x2000AB1")]
	public class UIItemSlot : UIElement
	{
		// Token: 0x0600446C RID: 17516 RVA: 0x0002E3E5 File Offset: 0x0002C5E5
		[global::Cpp2ILInjected.Token(Token = "0x60050BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x926378", Offset = "0x926378", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ProvideItemSlotElement", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIItemSlot(Item[] itemArray, int itemIndex, int itemSlotContext)
		{
			throw null;
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x0002E3E8 File Offset: 0x0002C5E8
		[global::Cpp2ILInjected.Token(Token = "0x60050BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x926454", Offset = "0x926454", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIItemSlot), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "RightClick", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
		{
			typeof(ref Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void HandleItemSlotLogic()
		{
			throw null;
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x0002E3EB File Offset: 0x0002C5EB
		[global::Cpp2ILInjected.Token(Token = "0x60050C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x92657C", Offset = "0x92657C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIItemSlot), Member = "HandleItemSlotLogic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref Item),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007031 RID: 28721
		[global::Cpp2ILInjected.Token(Token = "0x4008978")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Item[] _itemArray;

		// Token: 0x04007032 RID: 28722
		[global::Cpp2ILInjected.Token(Token = "0x4008979")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private int _itemIndex;

		// Token: 0x04007033 RID: 28723
		[global::Cpp2ILInjected.Token(Token = "0x400897A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private int _itemSlotContext;
	}
}
