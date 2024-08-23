using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Linq
{
	// Token: 0x02000008 RID: 8
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public static class Enumerable
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000436A File Offset: 0x0000256A
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1586EB4", Offset = "0x1586EB4", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Ambience.AmbienceServer", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000436D File Offset: 0x0000256D
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580FCC", Offset = "0x1580FCC", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Ambience.AmbienceServer", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004370 File Offset: 0x00002570
		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x158160C", Offset = "0x158160C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulator", Member = "FillItemExclusions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004373 File Offset: 0x00002573
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15829E0", Offset = "0x15829E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004376 File Offset: 0x00002576
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x157AE70", Offset = "0x157AE70", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004379 File Offset: 0x00002579
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x157B2B4", Offset = "0x157B2B4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000437C File Offset: 0x0000257C
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1582B18", Offset = "0x1582B18", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetExtensionDataMemberForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions", Member = "Properties", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<JObject>" }, ReturnType = "Newtonsoft.Json.Linq.IJEnumerable`1<JProperty>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000437F File Offset: 0x0000257F
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1582BD0", Offset = "0x1582BD0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004382 File Offset: 0x00002582
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585504", Offset = "0x1585504", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "WordwrapStringSmart", MemberParameters = new object[]
		{
			typeof(string),
			"Microsoft.Xna.Framework.Graphics.Color",
			"Microsoft.Xna.Framework.Graphics.SpriteFont",
			typeof(int),
			typeof(int)
		}, ReturnType = "System.Collections.Generic.List`1<List`1<TextSnippet>>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004385 File Offset: 0x00002585
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585550", Offset = "0x1585550", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004388 File Offset: 0x00002588
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580CD8", Offset = "0x1580CD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.ContentSamples.BestiaryHelper", Member = "GetSortedBestiaryEntriesList", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryDatabase" }, ReturnType = "System.Collections.Generic.List`1<KeyValuePair`2<Int32, NPC>>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000438B File Offset: 0x0000258B
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580EF4", Offset = "0x1580EF4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000438E File Offset: 0x0000258E
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x15855B8", Offset = "0x15855B8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.ContentSamples.BestiaryHelper", Member = "GetSortedBestiaryEntriesList", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryDatabase" }, ReturnType = "System.Collections.Generic.List`1<KeyValuePair`2<Int32, NPC>>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004391 File Offset: 0x00002591
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x157FD60", Offset = "0x157FD60", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage", Member = "AddInfoToList", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry", "Terraria.GameContent.UI.Elements.ExtraBestiaryInfoPageInformation" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004394 File Offset: 0x00002594
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x157D22C", Offset = "0x157D22C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "GetTrueIndexes", MemberParameters = new object[] { "System.Boolean[][]" }, ReturnType = "System.Collections.Generic.List`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004397 File Offset: 0x00002597
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x157D2CC", Offset = "0x157D2CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000439A File Offset: 0x0000259A
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1586D04", Offset = "0x1586D04", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000439D File Offset: 0x0000259D
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1586DC4", Offset = "0x1586DC4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000043A0 File Offset: 0x000025A0
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x157E018", Offset = "0x157E018", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.CoinLossRevengeSystem", Member = "CheckRespawns", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000043A3 File Offset: 0x000025A3
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x157E0D8", Offset = "0x157E0D8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000043A6 File Offset: 0x000025A6
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1582CA0", Offset = "0x1582CA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.JoystickState", Member = "op_Equality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Input.JoystickState", "Microsoft.Xna.Framework.Input.JoystickState" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000043A9 File Offset: 0x000025A9
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1582CF0", Offset = "0x1582CF0", Length = "0x6A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000043AC File Offset: 0x000025AC
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585918", Offset = "0x1585918", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulator", Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.CollectionUtils", Member = "ToMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer<int>), Member = "ToArray", ReturnType = "TElement[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000043AF File Offset: 0x000025AF
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1586A70", Offset = "0x1586A70", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.ContentSamples.BestiaryHelper", Member = "GetSortedBestiaryEntriesList", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryDatabase" }, ReturnType = "System.Collections.Generic.List`1<KeyValuePair`2<Int32, NPC>>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000043B2 File Offset: 0x000025B2
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585B18", Offset = "0x1585B18", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Reflection.IdDictionary", Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = "ReLogic.Reflection.IdDictionary")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000043B5 File Offset: 0x000025B5
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585B68", Offset = "0x1585B68", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000043B8 File Offset: 0x000025B8
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580C2C", Offset = "0x1580C2C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator", Member = "AddDropOverrides", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryDatabase" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.NPCPortraitInfoElement", Member = "ProvideUIElement", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryUICollectionInfo" }, ReturnType = "Terraria.UI.UIElement")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryButton", Member = "TryGettingBackgroundImageProvider", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry" }, ReturnType = "ReLogic.Content.Asset`1<Texture2D>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000043BB File Offset: 0x000025BB
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580C78", Offset = "0x1580C78", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000043BE File Offset: 0x000025BE
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x157AC88", Offset = "0x157AC88", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DictionaryWrapper`2", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000043C1 File Offset: 0x000025C1
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x157ADB0", Offset = "0x157ADB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000043C4 File Offset: 0x000025C4
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x157E1C8", Offset = "0x157E1C8", Length = "0x44C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer", Member = "LoadMinimapFrames", MemberParameters = new object[] { "ReLogic.Content.AssetRequestMode" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer", Member = "LoadPlayerResourceSets", MemberParameters = new object[] { "ReLogic.Content.AssetRequestMode" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.ResourceSets.PlayerResourceSetsManager", Member = "SetActive", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = "System.Collections.Generic.List`1<MemberInfo>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "GetFirstActiveToggle", ReturnType = "UnityEngine.UI.Toggle")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000043C7 File Offset: 0x000025C7
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x157EECC", Offset = "0x157EECC", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000043CA File Offset: 0x000025CA
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x157F310", Offset = "0x157F310", Length = "0x378")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.ChatCommandProcessor", Member = "CreateOutgoingMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.Chat.ChatMessage")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000043CD File Offset: 0x000025CD
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x157FF04", Offset = "0x157FF04", Length = "0x4AC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.ResourceSets.PlayerResourceSetsManager", Member = "CycleResourceSet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000043D0 File Offset: 0x000025D0
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580874", Offset = "0x1580874", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetExtensionDataMemberForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000043D3 File Offset: 0x000025D3
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15847A8", Offset = "0x15847A8", Length = "0x4DC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			"System.String[]"
		}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "MoreThanOneElement", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000043D6 File Offset: 0x000025D6
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1584C84", Offset = "0x1584C84", Length = "0x4C4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.AttributeUtilities", Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MethodBase) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "InitializeEnumType", MemberParameters = new object[] { typeof(Type) }, ReturnType = "Newtonsoft.Json.Utilities.BidirectionalDictionary`2<String, String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetMemberInfoFromType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberInfo)
		}, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "MoreThanOneElement", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000043D9 File Offset: 0x000025D9
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1585148", Offset = "0x1585148", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.GameCulture", Member = "FromName", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.Localization.GameCulture")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Items.ItemVariants", Member = "GetEntry", MemberParameters = new object[]
		{
			typeof(int),
			"Terraria.GameContent.Items.ItemVariant"
		}, ReturnType = "Terraria.GameContent.Items.ItemVariants.VariantEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "AddAndCreate", MemberParameters = new object[] { typeof(Guid) }, ReturnType = "UnityEngine.Events.UnityEvent`1<MessageEventArgs>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "UnregisterManagedCallback", MemberParameters = new object[]
		{
			typeof(Guid),
			"UnityEngine.Events.UnityAction`1<MessageEventArgs>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "MoreThanOneMatch", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000043DC File Offset: 0x000025DC
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x157D39C", Offset = "0x157D39C", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Ambience.AmbienceServer", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000043DF File Offset: 0x000025DF
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x157DFCC", Offset = "0x157DFCC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static IEnumerable<TResult> Empty<TResult>()
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000043E2 File Offset: 0x000025E2
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x157A344", Offset = "0x157A344", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils.<>c", Member = "<GetDefaultConstructor>b__10_0", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents", Member = "InvokeMessageIdSubscribers", MemberParameters = new object[]
		{
			typeof(Guid),
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000043E5 File Offset: 0x000025E5
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x157A5DC", Offset = "0x157A5DC", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Items.ItemVariants.VariantEntry", Member = "AnyConditionMet", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator", Member = "TryGivingEntryFlavorTextIfItIsMissing", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.NPCPortraitInfoElement.<>c__DisplayClass2_0", Member = "<ProvideUIElement>b__0", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.IBestiaryBackgroundImagePathAndColorProvider" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryButton.<>c__DisplayClass9_0", Member = "<TryGettingBackgroundImageProvider>b__2", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.IBestiaryBackgroundImagePathAndColorProvider" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsMethodOverridden", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.QuaternionConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "Register", MemberParameters = new object[]
		{
			typeof(Guid),
			"UnityEngine.Events.UnityAction`1<MessageEventArgs>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "Unregister", MemberParameters = new object[]
		{
			typeof(Guid),
			"UnityEngine.Events.UnityAction`1<MessageEventArgs>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000043E8 File Offset: 0x000025E8
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579CC4", Offset = "0x1579CC4", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Internal.CodeWriter", Member = "Append", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000043EB File Offset: 0x000025EB
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x157C778", Offset = "0x157C778", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryInfoPage", Member = "AddInfoToList", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry", "Terraria.GameContent.UI.Elements.ExtraBestiaryInfoPageInformation" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = "System.Collections.Generic.List`1<MemberInfo>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ToggleGroup", Member = "GetFirstActiveToggle", ReturnType = "UnityEngine.UI.Toggle")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static int Count<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000043EE File Offset: 0x000025EE
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x157CB54", Offset = "0x157CB54", Length = "0x36C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Ambience.AmbienceServer", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000043F1 File Offset: 0x000025F1
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x157B968", Offset = "0x157B968", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "GetPlayerPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "GetWorldPathFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			throw null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000043F4 File Offset: 0x000025F4
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x157BC08", Offset = "0x157BC08", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			throw null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000043F7 File Offset: 0x000025F7
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F538", Offset = "0x1D3F538", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Min", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static int Min(this IEnumerable<int> source)
		{
			throw null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000043FA File Offset: 0x000025FA
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580BEC", Offset = "0x1580BEC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Min", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(int))]
		public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			throw null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000043FD File Offset: 0x000025FD
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3F848", Offset = "0x1D3F848", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static int Max(this IEnumerable<int> source)
		{
			throw null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004400 File Offset: 0x00002600
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1580BAC", Offset = "0x1580BAC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(int))]
		public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			throw null;
		}

		// Token: 0x02000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x2000009")]
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x000044E1 File Offset: 0x000026E1
			[global::Cpp2ILInjected.Token(Token = "0x600006A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1712414", Offset = "0x1712414", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public Iterator()
			{
				throw null;
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000BA RID: 186 RVA: 0x000044E4 File Offset: 0x000026E4
			[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
			public TSource Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600006B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1712440", Offset = "0x1712440", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000BB RID: 187
			[global::Cpp2ILInjected.Token(Token = "0x600006C")]
			public abstract Enumerable.Iterator<TSource> Clone();

			// Token: 0x060000BC RID: 188 RVA: 0x000044E7 File Offset: 0x000026E7
			[global::Cpp2ILInjected.Token(Token = "0x600006D")]
			[global::Cpp2ILInjected.Address(RVA = "0x171244C", Offset = "0x171244C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Dispose()
			{
				throw null;
			}

			// Token: 0x060000BD RID: 189 RVA: 0x000044EA File Offset: 0x000026EA
			[global::Cpp2ILInjected.Token(Token = "0x600006E")]
			[global::Cpp2ILInjected.Address(RVA = "0x171245C", Offset = "0x171245C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public IEnumerator<TSource> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060000BE RID: 190
			[global::Cpp2ILInjected.Token(Token = "0x600006F")]
			public abstract bool MoveNext();

			// Token: 0x060000BF RID: 191
			[global::Cpp2ILInjected.Token(Token = "0x6000070")]
			public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);

			// Token: 0x060000C0 RID: 192
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x000044ED File Offset: 0x000026ED
			[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000072")]
				[global::Cpp2ILInjected.Address(RVA = "0x17124B8", Offset = "0x17124B8", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x000044F0 File Offset: 0x000026F0
			[global::Cpp2ILInjected.Token(Token = "0x6000073")]
			[global::Cpp2ILInjected.Address(RVA = "0x1712508", Offset = "0x1712508", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x000044F3 File Offset: 0x000026F3
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			[global::Cpp2ILInjected.Address(RVA = "0x171251C", Offset = "0x171251C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x04000056 RID: 86
			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int threadId;

			// Token: 0x04000057 RID: 87
			[global::Cpp2ILInjected.Token(Token = "0x4000011")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int state;

			// Token: 0x04000058 RID: 88
			[global::Cpp2ILInjected.Token(Token = "0x4000012")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal TSource current;
		}

		// Token: 0x02000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x200000A")]
		private class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060000C4 RID: 196 RVA: 0x000044F6 File Offset: 0x000026F6
			[global::Cpp2ILInjected.Token(Token = "0x6000075")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DC27C", Offset = "0x18DC27C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x000044F9 File Offset: 0x000026F9
			[global::Cpp2ILInjected.Token(Token = "0x6000076")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DC2B4", Offset = "0x18DC2B4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TSource> Clone()
			{
				throw null;
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x000044FC File Offset: 0x000026FC
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DC314", Offset = "0x18DC314", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override void Dispose()
			{
				throw null;
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x000044FF File Offset: 0x000026FF
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DC3D0", Offset = "0x18DC3D0", Length = "0x208")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x00004502 File Offset: 0x00002702
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C64E8", Offset = "0x14C64E8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x00004505 File Offset: 0x00002705
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DC5D8", Offset = "0x18DC5D8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x04000059 RID: 89
			[global::Cpp2ILInjected.Token(Token = "0x4000013")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x0400005A RID: 90
			[global::Cpp2ILInjected.Token(Token = "0x4000014")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x0400005B RID: 91
			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x02000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x200000B")]
		private class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060000CA RID: 202 RVA: 0x00004508 File Offset: 0x00002708
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DBA30", Offset = "0x18DBA30", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x0000450B File Offset: 0x0000270B
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DBA68", Offset = "0x18DBA68", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TSource> Clone()
			{
				throw null;
			}

			// Token: 0x060000CC RID: 204 RVA: 0x0000450E File Offset: 0x0000270E
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DBAC8", Offset = "0x18DBAC8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00004511 File Offset: 0x00002711
			[global::Cpp2ILInjected.Token(Token = "0x600007E")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C62E0", Offset = "0x14C62E0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00004514 File Offset: 0x00002714
			[global::Cpp2ILInjected.Token(Token = "0x600007F")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DBB60", Offset = "0x18DBB60", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x0400005C RID: 92
			[global::Cpp2ILInjected.Token(Token = "0x4000016")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource[] source;

			// Token: 0x0400005D RID: 93
			[global::Cpp2ILInjected.Token(Token = "0x4000017")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x0400005E RID: 94
			[global::Cpp2ILInjected.Token(Token = "0x4000018")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int index;
		}

		// Token: 0x02000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x200000C")]
		private class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060000CF RID: 207 RVA: 0x00004517 File Offset: 0x00002717
			[global::Cpp2ILInjected.Token(Token = "0x6000080")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DDD84", Offset = "0x18DDD84", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x0000451A File Offset: 0x0000271A
			[global::Cpp2ILInjected.Token(Token = "0x6000081")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DDDBC", Offset = "0x18DDDBC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TSource> Clone()
			{
				throw null;
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x0000451D File Offset: 0x0000271D
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DDE1C", Offset = "0x18DDE1C", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00004520 File Offset: 0x00002720
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C66F0", Offset = "0x14C66F0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00004523 File Offset: 0x00002723
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DDEF4", Offset = "0x18DDEF4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				throw null;
			}

			// Token: 0x0400005F RID: 95
			[global::Cpp2ILInjected.Token(Token = "0x4000019")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			// Token: 0x04000060 RID: 96
			[global::Cpp2ILInjected.Token(Token = "0x400001A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000061 RID: 97
			[global::Cpp2ILInjected.Token(Token = "0x400001B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;
		}

		// Token: 0x02000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x200000D")]
		private class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x00004526 File Offset: 0x00002726
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DFF4C", Offset = "0x18DFF4C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00004529 File Offset: 0x00002729
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DFF94", Offset = "0x18DFF94", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TResult> Clone()
			{
				throw null;
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x0000452C File Offset: 0x0000272C
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E0004", Offset = "0x18E0004", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override void Dispose()
			{
				throw null;
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x0000452F File Offset: 0x0000272F
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E00C0", Offset = "0x18E00C0", Length = "0x22C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00004532 File Offset: 0x00002732
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C6EA4", Offset = "0x14C6EA4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				throw null;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00004535 File Offset: 0x00002735
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E02EC", Offset = "0x18E02EC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw null;
			}

			// Token: 0x04000062 RID: 98
			[global::Cpp2ILInjected.Token(Token = "0x400001C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x04000063 RID: 99
			[global::Cpp2ILInjected.Token(Token = "0x400001D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000064 RID: 100
			[global::Cpp2ILInjected.Token(Token = "0x400001E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x04000065 RID: 101
			[global::Cpp2ILInjected.Token(Token = "0x400001F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> enumerator;
		}

		// Token: 0x02000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x200000E")]
		private class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060000DA RID: 218 RVA: 0x00004538 File Offset: 0x00002738
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DE740", Offset = "0x18DE740", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x0000453B File Offset: 0x0000273B
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DE788", Offset = "0x18DE788", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TResult> Clone()
			{
				throw null;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x0000453E File Offset: 0x0000273E
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DE7F8", Offset = "0x18DE7F8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00004541 File Offset: 0x00002741
			[global::Cpp2ILInjected.Token(Token = "0x600008E")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C68F8", Offset = "0x14C68F8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				throw null;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00004544 File Offset: 0x00002744
			[global::Cpp2ILInjected.Token(Token = "0x600008F")]
			[global::Cpp2ILInjected.Address(RVA = "0x18DE8B4", Offset = "0x18DE8B4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw null;
			}

			// Token: 0x04000066 RID: 102
			[global::Cpp2ILInjected.Token(Token = "0x4000020")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource[] source;

			// Token: 0x04000067 RID: 103
			[global::Cpp2ILInjected.Token(Token = "0x4000021")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x04000068 RID: 104
			[global::Cpp2ILInjected.Token(Token = "0x4000022")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x04000069 RID: 105
			[global::Cpp2ILInjected.Token(Token = "0x4000023")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int index;
		}

		// Token: 0x0200002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x200000F")]
		private class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060000DF RID: 223 RVA: 0x00004547 File Offset: 0x00002747
			[global::Cpp2ILInjected.Token(Token = "0x6000090")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E33C4", Offset = "0x18E33C4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
			{
				throw null;
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x0000454A File Offset: 0x0000274A
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E340C", Offset = "0x18E340C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Enumerable.Iterator<TResult> Clone()
			{
				throw null;
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x0000454D File Offset: 0x0000274D
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E347C", Offset = "0x18E347C", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			public override bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00004550 File Offset: 0x00002750
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			[global::Cpp2ILInjected.Address(RVA = "0x14C7450", Offset = "0x14C7450", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				throw null;
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00004553 File Offset: 0x00002753
			[global::Cpp2ILInjected.Token(Token = "0x6000094")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E3578", Offset = "0x18E3578", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				throw null;
			}

			// Token: 0x0400006A RID: 106
			[global::Cpp2ILInjected.Token(Token = "0x4000024")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<TSource> source;

			// Token: 0x0400006B RID: 107
			[global::Cpp2ILInjected.Token(Token = "0x4000025")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, bool> predicate;

			// Token: 0x0400006C RID: 108
			[global::Cpp2ILInjected.Token(Token = "0x4000026")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, TResult> selector;

			// Token: 0x0400006D RID: 109
			[global::Cpp2ILInjected.Token(Token = "0x4000027")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<TSource>.Enumerator enumerator;
		}

		// Token: 0x0200002B RID: 43
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000010")]
		private sealed class <SelectIterator>d__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x060000E4 RID: 228 RVA: 0x00004556 File Offset: 0x00002756
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BC668", Offset = "0x15BC668", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <SelectIterator>d__5(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00004559 File Offset: 0x00002759
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BC69C", Offset = "0x15BC69C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x0000455C File Offset: 0x0000275C
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BC6C8", Offset = "0x15BC6C8", Length = "0x308")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x0000455F File Offset: 0x0000275F
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BC9D0", Offset = "0x15BC9D0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004562 File Offset: 0x00002762
			[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000099")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BCA80", Offset = "0x15BCA80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00004565 File Offset: 0x00002765
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600009A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BCA88", Offset = "0x15BCA88", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00004568 File Offset: 0x00002768
			[global::Cpp2ILInjected.Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600009B")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BCAC0", Offset = "0x15BCAC0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000EB RID: 235 RVA: 0x0000456B File Offset: 0x0000276B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600009C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BCAC8", Offset = "0x15BCAC8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x0000456E File Offset: 0x0000276E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600009D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BCB5C", Offset = "0x15BCB5C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0400006E RID: 110
			[global::Cpp2ILInjected.Token(Token = "0x4000028")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400006F RID: 111
			[global::Cpp2ILInjected.Token(Token = "0x4000029")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			// Token: 0x04000070 RID: 112
			[global::Cpp2ILInjected.Token(Token = "0x400002A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x04000071 RID: 113
			[global::Cpp2ILInjected.Token(Token = "0x400002B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x04000072 RID: 114
			[global::Cpp2ILInjected.Token(Token = "0x400002C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			// Token: 0x04000073 RID: 115
			[global::Cpp2ILInjected.Token(Token = "0x400002D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, int, TResult> selector;

			// Token: 0x04000074 RID: 116
			[global::Cpp2ILInjected.Token(Token = "0x400002E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, int, TResult> <>3__selector;

			// Token: 0x04000075 RID: 117
			[global::Cpp2ILInjected.Token(Token = "0x400002F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <index>5__2;

			// Token: 0x04000076 RID: 118
			[global::Cpp2ILInjected.Token(Token = "0x4000030")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000011")]
		private sealed class <>c__DisplayClass6_0<TSource>
		{
			// Token: 0x060000ED RID: 237 RVA: 0x00004571 File Offset: 0x00002771
			[global::Cpp2ILInjected.Token(Token = "0x600009E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3E7C", Offset = "0x15B3E7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass6_0()
			{
				throw null;
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00004574 File Offset: 0x00002774
			[global::Cpp2ILInjected.Token(Token = "0x600009F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3E84", Offset = "0x15B3E84", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <CombinePredicates>b__0(TSource x)
			{
				throw null;
			}

			// Token: 0x04000077 RID: 119
			[global::Cpp2ILInjected.Token(Token = "0x4000031")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, bool> predicate1;

			// Token: 0x04000078 RID: 120
			[global::Cpp2ILInjected.Token(Token = "0x4000032")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, bool> predicate2;
		}

		// Token: 0x0200002D RID: 45
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000012")]
		private sealed class <>c__DisplayClass7_0<TSource, TMiddle, TResult>
		{
			// Token: 0x060000EF RID: 239 RVA: 0x00004577 File Offset: 0x00002777
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4200", Offset = "0x15B4200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass7_0()
			{
				throw null;
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x0000457A File Offset: 0x0000277A
			[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4208", Offset = "0x15B4208", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal TResult <CombineSelectors>b__0(TSource x)
			{
				throw null;
			}

			// Token: 0x04000079 RID: 121
			[global::Cpp2ILInjected.Token(Token = "0x4000033")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TMiddle, TResult> selector2;

			// Token: 0x0400007A RID: 122
			[global::Cpp2ILInjected.Token(Token = "0x4000034")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, TMiddle> selector1;
		}

		// Token: 0x0200002E RID: 46
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		private sealed class <SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x0000457D File Offset: 0x0000277D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BD578", Offset = "0x15BD578", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <SelectManyIterator>d__17(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00004580 File Offset: 0x00002780
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BD5AC", Offset = "0x15BD5AC", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00004583 File Offset: 0x00002783
			[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BD698", Offset = "0x15BD698", Length = "0x460")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00004586 File Offset: 0x00002786
			[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BDAF8", Offset = "0x15BDAF8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00004589 File Offset: 0x00002789
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BDBA8", Offset = "0x15BDBA8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000458C File Offset: 0x0000278C
			[global::Cpp2ILInjected.Token(Token = "0x17000011")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BDC58", Offset = "0x15BDC58", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x0000458F File Offset: 0x0000278F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BDC60", Offset = "0x15BDC60", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004592 File Offset: 0x00002792
			[global::Cpp2ILInjected.Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BDC98", Offset = "0x15BDC98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00004595 File Offset: 0x00002795
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BDCA0", Offset = "0x15BDCA0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00004598 File Offset: 0x00002798
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BDD34", Offset = "0x15BDD34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0400007B RID: 123
			[global::Cpp2ILInjected.Token(Token = "0x4000035")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400007C RID: 124
			[global::Cpp2ILInjected.Token(Token = "0x4000036")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			// Token: 0x0400007D RID: 125
			[global::Cpp2ILInjected.Token(Token = "0x4000037")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x0400007E RID: 126
			[global::Cpp2ILInjected.Token(Token = "0x4000038")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x0400007F RID: 127
			[global::Cpp2ILInjected.Token(Token = "0x4000039")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			// Token: 0x04000080 RID: 128
			[global::Cpp2ILInjected.Token(Token = "0x400003A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Func<TSource, IEnumerable<TResult>> selector;

			// Token: 0x04000081 RID: 129
			[global::Cpp2ILInjected.Token(Token = "0x400003B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<TSource, IEnumerable<TResult>> <>3__selector;

			// Token: 0x04000082 RID: 130
			[global::Cpp2ILInjected.Token(Token = "0x400003C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap1;

			// Token: 0x04000083 RID: 131
			[global::Cpp2ILInjected.Token(Token = "0x400003D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TResult> <>7__wrap2;
		}

		// Token: 0x0200002F RID: 47
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000014")]
		private sealed class <TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x060000FB RID: 251 RVA: 0x0000459B File Offset: 0x0000279B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE840", Offset = "0x15BE840", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <TakeIterator>d__25(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060000FC RID: 252 RVA: 0x0000459E File Offset: 0x0000279E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE874", Offset = "0x15BE874", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000045A1 File Offset: 0x000027A1
			[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE8A0", Offset = "0x15BE8A0", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060000FE RID: 254 RVA: 0x000045A4 File Offset: 0x000027A4
			[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BEB5C", Offset = "0x15BEB5C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000FF RID: 255 RVA: 0x000045A7 File Offset: 0x000027A7
			[global::Cpp2ILInjected.Token(Token = "0x17000013")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BEC0C", Offset = "0x15BEC0C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000100 RID: 256 RVA: 0x000045AA File Offset: 0x000027AA
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BEC14", Offset = "0x15BEC14", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000101 RID: 257 RVA: 0x000045AD File Offset: 0x000027AD
			[global::Cpp2ILInjected.Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BEC4C", Offset = "0x15BEC4C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000102 RID: 258 RVA: 0x000045B0 File Offset: 0x000027B0
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BEC54", Offset = "0x15BEC54", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x000045B3 File Offset: 0x000027B3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BECE8", Offset = "0x15BECE8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000084 RID: 132
			[global::Cpp2ILInjected.Token(Token = "0x400003E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x04000085 RID: 133
			[global::Cpp2ILInjected.Token(Token = "0x400003F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			// Token: 0x04000086 RID: 134
			[global::Cpp2ILInjected.Token(Token = "0x4000040")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x04000087 RID: 135
			[global::Cpp2ILInjected.Token(Token = "0x4000041")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int count;

			// Token: 0x04000088 RID: 136
			[global::Cpp2ILInjected.Token(Token = "0x4000042")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>3__count;

			// Token: 0x04000089 RID: 137
			[global::Cpp2ILInjected.Token(Token = "0x4000043")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x0400008A RID: 138
			[global::Cpp2ILInjected.Token(Token = "0x4000044")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			// Token: 0x0400008B RID: 139
			[global::Cpp2ILInjected.Token(Token = "0x4000045")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap1;
		}

		// Token: 0x02000030 RID: 48
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		private sealed class <DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x06000104 RID: 260 RVA: 0x000045B6 File Offset: 0x000027B6
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7CD0", Offset = "0x15B7CD0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <DistinctIterator>d__68(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000105 RID: 261 RVA: 0x000045B9 File Offset: 0x000027B9
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7D04", Offset = "0x15B7D04", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000045BC File Offset: 0x000027BC
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7D30", Offset = "0x15B7D30", Length = "0x2FC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x000045BF File Offset: 0x000027BF
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B802C", Offset = "0x15B802C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000108 RID: 264 RVA: 0x000045C2 File Offset: 0x000027C2
			[global::Cpp2ILInjected.Token(Token = "0x17000015")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B80DC", Offset = "0x15B80DC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000109 RID: 265 RVA: 0x000045C5 File Offset: 0x000027C5
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B80E4", Offset = "0x15B80E4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600010A RID: 266 RVA: 0x000045C8 File Offset: 0x000027C8
			[global::Cpp2ILInjected.Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B811C", Offset = "0x15B811C", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600010B RID: 267 RVA: 0x000045CB File Offset: 0x000027CB
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B8150", Offset = "0x15B8150", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0600010C RID: 268 RVA: 0x000045CE File Offset: 0x000027CE
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B81E4", Offset = "0x15B81E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0400008C RID: 140
			[global::Cpp2ILInjected.Token(Token = "0x4000046")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x0400008D RID: 141
			[global::Cpp2ILInjected.Token(Token = "0x4000047")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			// Token: 0x0400008E RID: 142
			[global::Cpp2ILInjected.Token(Token = "0x4000048")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x0400008F RID: 143
			[global::Cpp2ILInjected.Token(Token = "0x4000049")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			// Token: 0x04000090 RID: 144
			[global::Cpp2ILInjected.Token(Token = "0x400004A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x04000091 RID: 145
			[global::Cpp2ILInjected.Token(Token = "0x400004B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			// Token: 0x04000092 RID: 146
			[global::Cpp2ILInjected.Token(Token = "0x400004C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			// Token: 0x04000093 RID: 147
			[global::Cpp2ILInjected.Token(Token = "0x400004D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			// Token: 0x04000094 RID: 148
			[global::Cpp2ILInjected.Token(Token = "0x400004E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000016")]
		private sealed class <UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x0600010D RID: 269 RVA: 0x000045D1 File Offset: 0x000027D1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BECFC", Offset = "0x15BECFC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <UnionIterator>d__71(int <>1__state)
			{
				throw null;
			}

			// Token: 0x0600010E RID: 270 RVA: 0x000045D4 File Offset: 0x000027D4
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BED30", Offset = "0x15BED30", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600010F RID: 271 RVA: 0x000045D7 File Offset: 0x000027D7
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BED80", Offset = "0x15BED80", Length = "0x4E0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000110 RID: 272 RVA: 0x000045DA File Offset: 0x000027DA
			[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BF260", Offset = "0x15BF260", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000111 RID: 273 RVA: 0x000045DD File Offset: 0x000027DD
			[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BF310", Offset = "0x15BF310", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000112 RID: 274 RVA: 0x000045E0 File Offset: 0x000027E0
			[global::Cpp2ILInjected.Token(Token = "0x17000017")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BF3C0", Offset = "0x15BF3C0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x000045E3 File Offset: 0x000027E3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BF3C8", Offset = "0x15BF3C8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000114 RID: 276 RVA: 0x000045E6 File Offset: 0x000027E6
			[global::Cpp2ILInjected.Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BF400", Offset = "0x15BF400", Length = "0x34")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000115 RID: 277 RVA: 0x000045E9 File Offset: 0x000027E9
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BF434", Offset = "0x15BF434", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000116 RID: 278 RVA: 0x000045EC File Offset: 0x000027EC
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BF4D0", Offset = "0x15BF4D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000095 RID: 149
			[global::Cpp2ILInjected.Token(Token = "0x400004F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x04000096 RID: 150
			[global::Cpp2ILInjected.Token(Token = "0x4000050")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			// Token: 0x04000097 RID: 151
			[global::Cpp2ILInjected.Token(Token = "0x4000051")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x04000098 RID: 152
			[global::Cpp2ILInjected.Token(Token = "0x4000052")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			// Token: 0x04000099 RID: 153
			[global::Cpp2ILInjected.Token(Token = "0x4000053")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x0400009A RID: 154
			[global::Cpp2ILInjected.Token(Token = "0x4000054")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> first;

			// Token: 0x0400009B RID: 155
			[global::Cpp2ILInjected.Token(Token = "0x4000055")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__first;

			// Token: 0x0400009C RID: 156
			[global::Cpp2ILInjected.Token(Token = "0x4000056")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> second;

			// Token: 0x0400009D RID: 157
			[global::Cpp2ILInjected.Token(Token = "0x4000057")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__second;

			// Token: 0x0400009E RID: 158
			[global::Cpp2ILInjected.Token(Token = "0x4000058")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			// Token: 0x0400009F RID: 159
			[global::Cpp2ILInjected.Token(Token = "0x4000059")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000032 RID: 50
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		private sealed class <ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
		{
			// Token: 0x06000117 RID: 279 RVA: 0x000045EF File Offset: 0x000027EF
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B9134", Offset = "0x15B9134", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <ExceptIterator>d__77(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000118 RID: 280 RVA: 0x000045F2 File Offset: 0x000027F2
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B9168", Offset = "0x15B9168", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000119 RID: 281 RVA: 0x000045F5 File Offset: 0x000027F5
			[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B9194", Offset = "0x15B9194", Length = "0x600")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x0600011A RID: 282 RVA: 0x000045F8 File Offset: 0x000027F8
			[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B9794", Offset = "0x15B9794", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000045FB File Offset: 0x000027FB
			[global::Cpp2ILInjected.Token(Token = "0x17000019")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B9844", Offset = "0x15B9844", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600011C RID: 284 RVA: 0x000045FE File Offset: 0x000027FE
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B984C", Offset = "0x15B984C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00004601 File Offset: 0x00002801
			[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B9884", Offset = "0x15B9884", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00004604 File Offset: 0x00002804
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B988C", Offset = "0x15B988C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00004607 File Offset: 0x00002807
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B9928", Offset = "0x15B9928", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040000A0 RID: 160
			[global::Cpp2ILInjected.Token(Token = "0x400005A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040000A1 RID: 161
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			// Token: 0x040000A2 RID: 162
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x040000A3 RID: 163
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEqualityComparer<TSource> comparer;

			// Token: 0x040000A4 RID: 164
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TSource> <>3__comparer;

			// Token: 0x040000A5 RID: 165
			[global::Cpp2ILInjected.Token(Token = "0x400005F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> second;

			// Token: 0x040000A6 RID: 166
			[global::Cpp2ILInjected.Token(Token = "0x4000060")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__second;

			// Token: 0x040000A7 RID: 167
			[global::Cpp2ILInjected.Token(Token = "0x4000061")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> first;

			// Token: 0x040000A8 RID: 168
			[global::Cpp2ILInjected.Token(Token = "0x4000062")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__first;

			// Token: 0x040000A9 RID: 169
			[global::Cpp2ILInjected.Token(Token = "0x4000063")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Set<TSource> <set>5__2;

			// Token: 0x040000AA RID: 170
			[global::Cpp2ILInjected.Token(Token = "0x4000064")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;
		}

		// Token: 0x02000033 RID: 51
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		private sealed class <OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x06000120 RID: 288 RVA: 0x0000460A File Offset: 0x0000280A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB1F0", Offset = "0x15BB1F0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <OfTypeIterator>d__97(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000121 RID: 289 RVA: 0x0000460D File Offset: 0x0000280D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB224", Offset = "0x15BB224", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00004610 File Offset: 0x00002810
			[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB250", Offset = "0x15BB250", Length = "0x334")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00004613 File Offset: 0x00002813
			[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB584", Offset = "0x15BB584", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00004616 File Offset: 0x00002816
			[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BB640", Offset = "0x15BB640", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00004619 File Offset: 0x00002819
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB648", Offset = "0x15BB648", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000126 RID: 294 RVA: 0x0000461C File Offset: 0x0000281C
			[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BB680", Offset = "0x15BB680", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000127 RID: 295 RVA: 0x0000461F File Offset: 0x0000281F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB688", Offset = "0x15BB688", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00004622 File Offset: 0x00002822
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB714", Offset = "0x15BB714", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040000AB RID: 171
			[global::Cpp2ILInjected.Token(Token = "0x4000065")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040000AC RID: 172
			[global::Cpp2ILInjected.Token(Token = "0x4000066")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			// Token: 0x040000AD RID: 173
			[global::Cpp2ILInjected.Token(Token = "0x4000067")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x040000AE RID: 174
			[global::Cpp2ILInjected.Token(Token = "0x4000068")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable source;

			// Token: 0x040000AF RID: 175
			[global::Cpp2ILInjected.Token(Token = "0x4000069")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable <>3__source;

			// Token: 0x040000B0 RID: 176
			[global::Cpp2ILInjected.Token(Token = "0x400006A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;
		}

		// Token: 0x02000034 RID: 52
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000019")]
		private sealed class <CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
		{
			// Token: 0x06000129 RID: 297 RVA: 0x00004625 File Offset: 0x00002825
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6DC0", Offset = "0x15B6DC0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <CastIterator>d__99(int <>1__state)
			{
				throw null;
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004628 File Offset: 0x00002828
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6DF4", Offset = "0x15B6DF4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x0600012B RID: 299 RVA: 0x0000462B File Offset: 0x0000282B
			[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B6E20", Offset = "0x15B6E20", Length = "0x2CC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x0000462E File Offset: 0x0000282E
			[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B70EC", Offset = "0x15B70EC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00004631 File Offset: 0x00002831
			[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
			private TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B71A8", Offset = "0x15B71A8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00004634 File Offset: 0x00002834
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B71B4", Offset = "0x15B71B4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00004637 File Offset: 0x00002837
			[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B71EC", Offset = "0x15B71EC", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000130 RID: 304 RVA: 0x0000463A File Offset: 0x0000283A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7228", Offset = "0x15B7228", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000131 RID: 305 RVA: 0x0000463D File Offset: 0x0000283D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B72B4", Offset = "0x15B72B4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040000B1 RID: 177
			[global::Cpp2ILInjected.Token(Token = "0x400006B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040000B2 RID: 178
			[global::Cpp2ILInjected.Token(Token = "0x400006C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private TResult <>2__current;

			// Token: 0x040000B3 RID: 179
			[global::Cpp2ILInjected.Token(Token = "0x400006D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x040000B4 RID: 180
			[global::Cpp2ILInjected.Token(Token = "0x400006E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable source;

			// Token: 0x040000B5 RID: 181
			[global::Cpp2ILInjected.Token(Token = "0x400006F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable <>3__source;

			// Token: 0x040000B6 RID: 182
			[global::Cpp2ILInjected.Token(Token = "0x4000070")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;
		}
	}
}
