using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000698 RID: 1688
	[global::Cpp2ILInjected.Token(Token = "0x2000A5A")]
	public class CustomCurrencySystem
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
		[global::Cpp2ILInjected.Token(Token = "0x1700089F")]
		public long CurrencyCap
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004E56")]
			[global::Cpp2ILInjected.Address(RVA = "0x8DDCBC", Offset = "0x8DDCBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0002DDD3 File Offset: 0x0002BFD3
		[global::Cpp2ILInjected.Token(Token = "0x6004E57")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DDCC4", Offset = "0x8DDCC4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Include(int coin, int howMuchIsItWorth)
		{
			throw null;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0002DDD6 File Offset: 0x0002BFD6
		[global::Cpp2ILInjected.Token(Token = "0x6004E58")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DDD24", Offset = "0x8DDD24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetCurrencyCap(long cap)
		{
			throw null;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0002DDD9 File Offset: 0x0002BFD9
		[global::Cpp2ILInjected.Token(Token = "0x6004E59")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DDD2C", Offset = "0x8DDD2C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual long CountCurrency(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
		{
			throw null;
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0002DDDC File Offset: 0x0002BFDC
		[global::Cpp2ILInjected.Token(Token = "0x6004E5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DDE88", Offset = "0x8DDE88", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual long CombineStacks(out bool overFlowing, params long[] coinCounts)
		{
			throw null;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0002DDDF File Offset: 0x0002BFDF
		[global::Cpp2ILInjected.Token(Token = "0x6004E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DDEE4", Offset = "0x8DDEE4", Length = "0xF84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "get_Item", MemberParameters = new object[] { typeof(Point) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<Point>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<Point>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public virtual bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
		{
			throw null;
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0002DDE2 File Offset: 0x0002BFE2
		[global::Cpp2ILInjected.Token(Token = "0x6004E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DEE68", Offset = "0x8DEE68", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool Accepts(Item item)
		{
			throw null;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0002DDE5 File Offset: 0x0002BFE5
		[global::Cpp2ILInjected.Token(Token = "0x6004E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DEEC0", Offset = "0x8DEEC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
		{
			throw null;
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
		[global::Cpp2ILInjected.Token(Token = "0x6004E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DEEC4", Offset = "0x8DEEC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GetPriceText(string[] lines, ref int currentLine, long price)
		{
			throw null;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0002DDEB File Offset: 0x0002BFEB
		[global::Cpp2ILInjected.Token(Token = "0x6004E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DEEC8", Offset = "0x8DEEC8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected int SortByHighest(Tuple<int, int> valueA, Tuple<int, int> valueB)
		{
			throw null;
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0002DDEE File Offset: 0x0002BFEE
		[global::Cpp2ILInjected.Token(Token = "0x6004E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DEF20", Offset = "0x8DEF20", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = "TryPurchasing", MemberParameters = new object[]
		{
			typeof(long),
			typeof(List<Item[]>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DeepClone", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<Point, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected List<Tuple<Point, Item>> ItemCacheCreate(List<Item[]> inventories)
		{
			throw null;
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0002DDF1 File Offset: 0x0002BFF1
		[global::Cpp2ILInjected.Token(Token = "0x6004E61")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DF11C", Offset = "0x8DF11C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = "TryPurchasing", MemberParameters = new object[]
		{
			typeof(long),
			typeof(List<Item[]>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>),
			typeof(List<Point>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected void ItemCacheRestore(List<Tuple<Point, Item>> cache, List<Item[]> inventories)
		{
			throw null;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0002DDF4 File Offset: 0x0002BFF4
		[global::Cpp2ILInjected.Token(Token = "0x6004E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DF2CC", Offset = "0x8DF2CC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetStoreValue", ReturnType = typeof(int))]
		public virtual void GetItemExpectedPrice(Item item, out long calcForSelling, out long calcForBuying)
		{
			throw null;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0002DDF7 File Offset: 0x0002BFF7
		[global::Cpp2ILInjected.Token(Token = "0x6004E63")]
		[global::Cpp2ILInjected.Address(RVA = "0x8DF300", Offset = "0x8DF300", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CustomCurrencySystem()
		{
			throw null;
		}

		// Token: 0x04006E22 RID: 28194
		[global::Cpp2ILInjected.Token(Token = "0x40086F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected Dictionary<int, int> _valuePerUnit;

		// Token: 0x04006E23 RID: 28195
		[global::Cpp2ILInjected.Token(Token = "0x40086F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long _currencyCap;
	}
}
