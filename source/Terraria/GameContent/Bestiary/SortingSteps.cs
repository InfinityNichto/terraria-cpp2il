using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000618 RID: 1560
	[global::Cpp2ILInjected.Token(Token = "0x200092D")]
	public static class SortingSteps
	{
		// Token: 0x02000A19 RID: 2585
		[global::Cpp2ILInjected.Token(Token = "0x200092E")]
		public class ByNetId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x00030113 File Offset: 0x0002E313
			[global::Cpp2ILInjected.Token(Token = "0x1700081B")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600472F")]
				[global::Cpp2ILInjected.Address(RVA = "0x8157D4", Offset = "0x8157D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FAA RID: 20394 RVA: 0x00030116 File Offset: 0x0002E316
			[global::Cpp2ILInjected.Token(Token = "0x6004730")]
			[global::Cpp2ILInjected.Address(RVA = "0x8157DC", Offset = "0x8157DC", Length = "0x250")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, bool>)
			}, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FAB RID: 20395 RVA: 0x00030119 File Offset: 0x0002E319
			[global::Cpp2ILInjected.Token(Token = "0x6004731")]
			[global::Cpp2ILInjected.Address(RVA = "0x815A2C", Offset = "0x815A2C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FAC RID: 20396 RVA: 0x0003011C File Offset: 0x0002E31C
			[global::Cpp2ILInjected.Token(Token = "0x6004732")]
			[global::Cpp2ILInjected.Address(RVA = "0x815A6C", Offset = "0x815A6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByNetId()
			{
				throw null;
			}

			// Token: 0x02000BAC RID: 2988
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200092F")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600541F RID: 21535 RVA: 0x00030D43 File Offset: 0x0002EF43
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6004733")]
				[global::Cpp2ILInjected.Address(RVA = "0x815A74", Offset = "0x815A74", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x06005420 RID: 21536 RVA: 0x00030D46 File Offset: 0x0002EF46
				[global::Cpp2ILInjected.Token(Token = "0x6004734")]
				[global::Cpp2ILInjected.Address(RVA = "0x815AD0", Offset = "0x815AD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06005421 RID: 21537 RVA: 0x00030D49 File Offset: 0x0002EF49
				[global::Cpp2ILInjected.Token(Token = "0x6004735")]
				[global::Cpp2ILInjected.Address(RVA = "0x815AD8", Offset = "0x815AD8", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x06005422 RID: 21538 RVA: 0x00030D4C File Offset: 0x0002EF4C
				[global::Cpp2ILInjected.Token(Token = "0x6004736")]
				[global::Cpp2ILInjected.Address(RVA = "0x815B50", Offset = "0x815B50", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x04009103 RID: 37123
				[global::Cpp2ILInjected.Token(Token = "0x4008350")]
				public static readonly SortingSteps.ByNetId.<>c <>9;

				// Token: 0x04009104 RID: 37124
				[global::Cpp2ILInjected.Token(Token = "0x4008351")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009105 RID: 37125
				[global::Cpp2ILInjected.Token(Token = "0x4008352")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000A1A RID: 2586
		[global::Cpp2ILInjected.Token(Token = "0x2000930")]
		public class ByUnlockState : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06004FAD RID: 20397 RVA: 0x0003011F File Offset: 0x0002E31F
			[global::Cpp2ILInjected.Token(Token = "0x1700081C")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004737")]
				[global::Cpp2ILInjected.Address(RVA = "0x815BC8", Offset = "0x815BC8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FAE RID: 20398 RVA: 0x00030122 File Offset: 0x0002E322
			[global::Cpp2ILInjected.Token(Token = "0x6004738")]
			[global::Cpp2ILInjected.Address(RVA = "0x815BD0", Offset = "0x815BD0", Length = "0x22C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FAF RID: 20399 RVA: 0x00030125 File Offset: 0x0002E325
			[global::Cpp2ILInjected.Token(Token = "0x6004739")]
			[global::Cpp2ILInjected.Address(RVA = "0x815DFC", Offset = "0x815DFC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FB0 RID: 20400 RVA: 0x00030128 File Offset: 0x0002E328
			[global::Cpp2ILInjected.Token(Token = "0x600473A")]
			[global::Cpp2ILInjected.Address(RVA = "0x815E3C", Offset = "0x815E3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByUnlockState()
			{
				throw null;
			}
		}

		// Token: 0x02000A1B RID: 2587
		[global::Cpp2ILInjected.Token(Token = "0x2000931")]
		public class ByBestiarySortingId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0003012B File Offset: 0x0002E32B
			[global::Cpp2ILInjected.Token(Token = "0x1700081D")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600473B")]
				[global::Cpp2ILInjected.Address(RVA = "0x815E44", Offset = "0x815E44", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FB2 RID: 20402 RVA: 0x0003012E File Offset: 0x0002E32E
			[global::Cpp2ILInjected.Token(Token = "0x600473C")]
			[global::Cpp2ILInjected.Address(RVA = "0x815E4C", Offset = "0x815E4C", Length = "0x2B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, bool>)
			}, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FB3 RID: 20403 RVA: 0x00030131 File Offset: 0x0002E331
			[global::Cpp2ILInjected.Token(Token = "0x600473D")]
			[global::Cpp2ILInjected.Address(RVA = "0x816100", Offset = "0x816100", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FB4 RID: 20404 RVA: 0x00030134 File Offset: 0x0002E334
			[global::Cpp2ILInjected.Token(Token = "0x600473E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816140", Offset = "0x816140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBestiarySortingId()
			{
				throw null;
			}

			// Token: 0x02000BAD RID: 2989
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000932")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005423 RID: 21539 RVA: 0x00030D4F File Offset: 0x0002EF4F
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x600473F")]
				[global::Cpp2ILInjected.Address(RVA = "0x816148", Offset = "0x816148", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x06005424 RID: 21540 RVA: 0x00030D52 File Offset: 0x0002EF52
				[global::Cpp2ILInjected.Token(Token = "0x6004740")]
				[global::Cpp2ILInjected.Address(RVA = "0x8161A4", Offset = "0x8161A4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06005425 RID: 21541 RVA: 0x00030D55 File Offset: 0x0002EF55
				[global::Cpp2ILInjected.Token(Token = "0x6004741")]
				[global::Cpp2ILInjected.Address(RVA = "0x8161AC", Offset = "0x8161AC", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x06005426 RID: 21542 RVA: 0x00030D58 File Offset: 0x0002EF58
				[global::Cpp2ILInjected.Token(Token = "0x6004742")]
				[global::Cpp2ILInjected.Address(RVA = "0x816224", Offset = "0x816224", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x04009106 RID: 37126
				[global::Cpp2ILInjected.Token(Token = "0x4008353")]
				public static readonly SortingSteps.ByBestiarySortingId.<>c <>9;

				// Token: 0x04009107 RID: 37127
				[global::Cpp2ILInjected.Token(Token = "0x4008354")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x04009108 RID: 37128
				[global::Cpp2ILInjected.Token(Token = "0x4008355")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000A1C RID: 2588
		[global::Cpp2ILInjected.Token(Token = "0x2000933")]
		public class ByBestiaryRarity : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x00030137 File Offset: 0x0002E337
			[global::Cpp2ILInjected.Token(Token = "0x1700081E")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004743")]
				[global::Cpp2ILInjected.Address(RVA = "0x81629C", Offset = "0x81629C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FB6 RID: 20406 RVA: 0x0003013A File Offset: 0x0002E33A
			[global::Cpp2ILInjected.Token(Token = "0x6004744")]
			[global::Cpp2ILInjected.Address(RVA = "0x8162A4", Offset = "0x8162A4", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, bool>)
			}, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FB7 RID: 20407 RVA: 0x0003013D File Offset: 0x0002E33D
			[global::Cpp2ILInjected.Token(Token = "0x6004745")]
			[global::Cpp2ILInjected.Address(RVA = "0x816560", Offset = "0x816560", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FB8 RID: 20408 RVA: 0x00030140 File Offset: 0x0002E340
			[global::Cpp2ILInjected.Token(Token = "0x6004746")]
			[global::Cpp2ILInjected.Address(RVA = "0x8165A0", Offset = "0x8165A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBestiaryRarity()
			{
				throw null;
			}

			// Token: 0x02000BAE RID: 2990
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000934")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06005427 RID: 21543 RVA: 0x00030D5B File Offset: 0x0002EF5B
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6004747")]
				[global::Cpp2ILInjected.Address(RVA = "0x8165A8", Offset = "0x8165A8", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x06005428 RID: 21544 RVA: 0x00030D5E File Offset: 0x0002EF5E
				[global::Cpp2ILInjected.Token(Token = "0x6004748")]
				[global::Cpp2ILInjected.Address(RVA = "0x816604", Offset = "0x816604", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06005429 RID: 21545 RVA: 0x00030D61 File Offset: 0x0002EF61
				[global::Cpp2ILInjected.Token(Token = "0x6004749")]
				[global::Cpp2ILInjected.Address(RVA = "0x81660C", Offset = "0x81660C", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x0600542A RID: 21546 RVA: 0x00030D64 File Offset: 0x0002EF64
				[global::Cpp2ILInjected.Token(Token = "0x600474A")]
				[global::Cpp2ILInjected.Address(RVA = "0x816684", Offset = "0x816684", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x04009109 RID: 37129
				[global::Cpp2ILInjected.Token(Token = "0x4008356")]
				public static readonly SortingSteps.ByBestiaryRarity.<>c <>9;

				// Token: 0x0400910A RID: 37130
				[global::Cpp2ILInjected.Token(Token = "0x4008357")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x0400910B RID: 37131
				[global::Cpp2ILInjected.Token(Token = "0x4008358")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000A1D RID: 2589
		[global::Cpp2ILInjected.Token(Token = "0x2000935")]
		public class Alphabetical : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x00030143 File Offset: 0x0002E343
			[global::Cpp2ILInjected.Token(Token = "0x1700081F")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600474B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8166FC", Offset = "0x8166FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FBA RID: 20410 RVA: 0x00030146 File Offset: 0x0002E346
			[global::Cpp2ILInjected.Token(Token = "0x600474C")]
			[global::Cpp2ILInjected.Address(RVA = "0x816704", Offset = "0x816704", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, bool>)
			}, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_TypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FBB RID: 20411 RVA: 0x00030149 File Offset: 0x0002E349
			[global::Cpp2ILInjected.Token(Token = "0x600474D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8169E8", Offset = "0x8169E8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FBC RID: 20412 RVA: 0x0003014C File Offset: 0x0002E34C
			[global::Cpp2ILInjected.Token(Token = "0x600474E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816A28", Offset = "0x816A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Alphabetical()
			{
				throw null;
			}

			// Token: 0x02000BAF RID: 2991
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000936")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x0600542B RID: 21547 RVA: 0x00030D67 File Offset: 0x0002EF67
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x600474F")]
				[global::Cpp2ILInjected.Address(RVA = "0x816A30", Offset = "0x816A30", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x0600542C RID: 21548 RVA: 0x00030D6A File Offset: 0x0002EF6A
				[global::Cpp2ILInjected.Token(Token = "0x6004750")]
				[global::Cpp2ILInjected.Address(RVA = "0x816A8C", Offset = "0x816A8C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x0600542D RID: 21549 RVA: 0x00030D6D File Offset: 0x0002EF6D
				[global::Cpp2ILInjected.Token(Token = "0x6004751")]
				[global::Cpp2ILInjected.Address(RVA = "0x816A94", Offset = "0x816A94", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x0600542E RID: 21550 RVA: 0x00030D70 File Offset: 0x0002EF70
				[global::Cpp2ILInjected.Token(Token = "0x6004752")]
				[global::Cpp2ILInjected.Address(RVA = "0x816B0C", Offset = "0x816B0C", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				// Token: 0x0400910C RID: 37132
				[global::Cpp2ILInjected.Token(Token = "0x4008359")]
				public static readonly SortingSteps.Alphabetical.<>c <>9;

				// Token: 0x0400910D RID: 37133
				[global::Cpp2ILInjected.Token(Token = "0x400835A")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				// Token: 0x0400910E RID: 37134
				[global::Cpp2ILInjected.Token(Token = "0x400835B")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		// Token: 0x02000A1E RID: 2590
		[global::Cpp2ILInjected.Token(Token = "0x2000937")]
		public abstract class ByStat : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06004FBD RID: 20413 RVA: 0x0003014F File Offset: 0x0002E34F
			[global::Cpp2ILInjected.Token(Token = "0x17000820")]
			public bool HiddenFromSortOptions
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004753")]
				[global::Cpp2ILInjected.Address(RVA = "0x816B84", Offset = "0x816B84", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FBE RID: 20414 RVA: 0x00030152 File Offset: 0x0002E352
			[global::Cpp2ILInjected.Token(Token = "0x6004754")]
			[global::Cpp2ILInjected.Address(RVA = "0x816B8C", Offset = "0x816B8C", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, bool>)
			}, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public int Compare(BestiaryEntry x, BestiaryEntry y)
			{
				throw null;
			}

			// Token: 0x06004FBF RID: 20415
			[global::Cpp2ILInjected.Token(Token = "0x6004755")]
			public abstract int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY);

			// Token: 0x06004FC0 RID: 20416
			[global::Cpp2ILInjected.Token(Token = "0x6004756")]
			public abstract string GetDisplayNameKey();

			// Token: 0x06004FC1 RID: 20417 RVA: 0x00030155 File Offset: 0x0002E355
			[global::Cpp2ILInjected.Token(Token = "0x6004757")]
			[global::Cpp2ILInjected.Address(RVA = "0x816D4C", Offset = "0x816D4C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortingSteps.ByStat), Member = "<Compare>b__2_0", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortingSteps.ByStat), Member = "<Compare>b__2_1", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool IsAStatsCardINeed(IBestiaryInfoElement element)
			{
				throw null;
			}

			// Token: 0x06004FC2 RID: 20418 RVA: 0x00030158 File Offset: 0x0002E358
			[global::Cpp2ILInjected.Token(Token = "0x6004758")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DC4", Offset = "0x816DC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ByStat()
			{
				throw null;
			}

			// Token: 0x06004FC3 RID: 20419 RVA: 0x0003015B File Offset: 0x0002E35B
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004759")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DCC", Offset = "0x816DCC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByStat), Member = "IsAStatsCardINeed", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(bool))]
			private bool <Compare>b__2_0(IBestiaryInfoElement element)
			{
				throw null;
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x0003015E File Offset: 0x0002E35E
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600475A")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DD0", Offset = "0x816DD0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByStat), Member = "IsAStatsCardINeed", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(bool))]
			private bool <Compare>b__2_1(IBestiaryInfoElement element)
			{
				throw null;
			}
		}

		// Token: 0x02000A1F RID: 2591
		[global::Cpp2ILInjected.Token(Token = "0x2000938")]
		public class ByAttack : SortingSteps.ByStat
		{
			// Token: 0x06004FC5 RID: 20421 RVA: 0x00030161 File Offset: 0x0002E361
			[global::Cpp2ILInjected.Token(Token = "0x600475B")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DD4", Offset = "0x816DD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x00030164 File Offset: 0x0002E364
			[global::Cpp2ILInjected.Token(Token = "0x600475C")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DE4", Offset = "0x816DE4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x00030167 File Offset: 0x0002E367
			[global::Cpp2ILInjected.Token(Token = "0x600475D")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E24", Offset = "0x816E24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByAttack()
			{
				throw null;
			}
		}

		// Token: 0x02000A20 RID: 2592
		[global::Cpp2ILInjected.Token(Token = "0x2000939")]
		public class ByDefense : SortingSteps.ByStat
		{
			// Token: 0x06004FC8 RID: 20424 RVA: 0x0003016A File Offset: 0x0002E36A
			[global::Cpp2ILInjected.Token(Token = "0x600475E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E2C", Offset = "0x816E2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			// Token: 0x06004FC9 RID: 20425 RVA: 0x0003016D File Offset: 0x0002E36D
			[global::Cpp2ILInjected.Token(Token = "0x600475F")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E3C", Offset = "0x816E3C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FCA RID: 20426 RVA: 0x00030170 File Offset: 0x0002E370
			[global::Cpp2ILInjected.Token(Token = "0x6004760")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E7C", Offset = "0x816E7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByDefense()
			{
				throw null;
			}
		}

		// Token: 0x02000A21 RID: 2593
		[global::Cpp2ILInjected.Token(Token = "0x200093A")]
		public class ByCoins : SortingSteps.ByStat
		{
			// Token: 0x06004FCB RID: 20427 RVA: 0x00030173 File Offset: 0x0002E373
			[global::Cpp2ILInjected.Token(Token = "0x6004761")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E84", Offset = "0x816E84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			// Token: 0x06004FCC RID: 20428 RVA: 0x00030176 File Offset: 0x0002E376
			[global::Cpp2ILInjected.Token(Token = "0x6004762")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E94", Offset = "0x816E94", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x00030179 File Offset: 0x0002E379
			[global::Cpp2ILInjected.Token(Token = "0x6004763")]
			[global::Cpp2ILInjected.Address(RVA = "0x816ED4", Offset = "0x816ED4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByCoins()
			{
				throw null;
			}
		}

		// Token: 0x02000A22 RID: 2594
		[global::Cpp2ILInjected.Token(Token = "0x200093B")]
		public class ByHP : SortingSteps.ByStat
		{
			// Token: 0x06004FCE RID: 20430 RVA: 0x0003017C File Offset: 0x0002E37C
			[global::Cpp2ILInjected.Token(Token = "0x6004764")]
			[global::Cpp2ILInjected.Address(RVA = "0x816EDC", Offset = "0x816EDC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			// Token: 0x06004FCF RID: 20431 RVA: 0x0003017F File Offset: 0x0002E37F
			[global::Cpp2ILInjected.Token(Token = "0x6004765")]
			[global::Cpp2ILInjected.Address(RVA = "0x816EEC", Offset = "0x816EEC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FD0 RID: 20432 RVA: 0x00030182 File Offset: 0x0002E382
			[global::Cpp2ILInjected.Token(Token = "0x6004766")]
			[global::Cpp2ILInjected.Address(RVA = "0x816F2C", Offset = "0x816F2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByHP()
			{
				throw null;
			}
		}
	}
}
