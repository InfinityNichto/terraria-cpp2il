using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI
{
	// Token: 0x0200069A RID: 1690
	[global::Cpp2ILInjected.Token(Token = "0x2000A5C")]
	public class CustomCurrencyManager
	{
		// Token: 0x06004270 RID: 17008 RVA: 0x0002DE06 File Offset: 0x0002C006
		[global::Cpp2ILInjected.Token(Token = "0x6004E68")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DFEFC", Offset = "0x8DFEFC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencySingleCoin), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencyManager), Member = "RegisterCurrency", MemberParameters = new object[] { typeof(CustomCurrencySystem) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0002DE09 File Offset: 0x0002C009
		[global::Cpp2ILInjected.Token(Token = "0x6004E69")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DFFC0", Offset = "0x8DFFC0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencyManager), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int RegisterCurrency(CustomCurrencySystem collection)
		{
			throw null;
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x0002DE0C File Offset: 0x0002C00C
		[global::Cpp2ILInjected.Token(Token = "0x6004E6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E0050", Offset = "0x8E0050", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static long GetCurrencyCount(int currencyIndex)
		{
			throw null;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x0002DE0F File Offset: 0x0002C00F
		[global::Cpp2ILInjected.Token(Token = "0x6004E6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E033C", Offset = "0x8E033C", Length = "0x670")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderStringFourWay", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(Color),
			typeof(Color),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public static void DrawSavings(SpriteBatch sb, int currencyIndex, float shopx, float shopy, bool horizontal = false)
		{
			throw null;
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x0002DE12 File Offset: 0x0002C012
		[global::Cpp2ILInjected.Token(Token = "0x6004E6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E09AC", Offset = "0x8E09AC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
		{
			typeof(Main.MouseTextCache),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void GetPriceText(int currencyIndex, string[] lines, ref int currentLine, long price)
		{
			throw null;
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x0002DE15 File Offset: 0x0002C015
		[global::Cpp2ILInjected.Token(Token = "0x6004E6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E0A58", Offset = "0x8E0A58", Length = "0x360")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CanAffordItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static bool CanAffordItem(Player player, long price, int currencyIndex)
		{
			throw null;
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x0002DE18 File Offset: 0x0002C018
		[global::Cpp2ILInjected.Token(Token = "0x6004E6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E0DB8", Offset = "0x8E0DB8", Length = "0xAE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BuyItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomCurrencyManager), Member = "FindEmptySlots", MemberParameters = new object[]
		{
			typeof(List<Item[]>),
			typeof(Dictionary<int, List<int>>),
			typeof(List<Point>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public static bool BuyItem(Player player, long price, int currencyIndex)
		{
			throw null;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x0002DE1B File Offset: 0x0002C01B
		[global::Cpp2ILInjected.Token(Token = "0x6004E6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E189C", Offset = "0x8E189C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencyManager), Member = "BuyItem", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void FindEmptySlots(List<Item[]> inventories, Dictionary<int, List<int>> slotsToIgnore, List<Point> emptySlots, int currentInventoryIndex)
		{
			throw null;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x0002DE1E File Offset: 0x0002C01E
		[global::Cpp2ILInjected.Token(Token = "0x6004E70")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1A3C", Offset = "0x8E1A3C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "get_IsCurrency", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static bool IsCustomCurrency(Item item)
		{
			throw null;
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x0002DE21 File Offset: 0x0002C021
		[global::Cpp2ILInjected.Token(Token = "0x6004E71")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1BD0", Offset = "0x8E1BD0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemExpectedPrice", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void GetPrices(Item item, out long calcForSelling, out long calcForBuying)
		{
			throw null;
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x0002DE24 File Offset: 0x0002C024
		[global::Cpp2ILInjected.Token(Token = "0x6004E72")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1C70", Offset = "0x8E1C70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CustomCurrencyManager()
		{
			throw null;
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0002DE27 File Offset: 0x0002C027
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004E73")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1C78", Offset = "0x8E1C78", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static CustomCurrencyManager()
		{
			throw null;
		}

		// Token: 0x04006E27 RID: 28199
		[global::Cpp2ILInjected.Token(Token = "0x40086F9")]
		private static int _nextCurrencyIndex;

		// Token: 0x04006E28 RID: 28200
		[global::Cpp2ILInjected.Token(Token = "0x40086FA")]
		private static Dictionary<int, CustomCurrencySystem> _currencies;
	}
}
