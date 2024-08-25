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
	[global::Cpp2ILInjected.Token(Token = "0x200092D")]
	public static class SortingSteps
	{
		[global::Cpp2ILInjected.Token(Token = "0x200092E")]
		public class ByNetId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004731")]
			[global::Cpp2ILInjected.Address(RVA = "0x815A2C", Offset = "0x815A2C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004732")]
			[global::Cpp2ILInjected.Address(RVA = "0x815A6C", Offset = "0x815A6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByNetId()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200092F")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004734")]
				[global::Cpp2ILInjected.Address(RVA = "0x815AD0", Offset = "0x815AD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004735")]
				[global::Cpp2ILInjected.Address(RVA = "0x815AD8", Offset = "0x815AD8", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004736")]
				[global::Cpp2ILInjected.Address(RVA = "0x815B50", Offset = "0x815B50", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4008350")]
				public static readonly SortingSteps.ByNetId.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x4008351")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				[global::Cpp2ILInjected.Token(Token = "0x4008352")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000930")]
		public class ByUnlockState : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004739")]
			[global::Cpp2ILInjected.Address(RVA = "0x815DFC", Offset = "0x815DFC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x2000931")]
		public class ByBestiarySortingId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600473D")]
			[global::Cpp2ILInjected.Address(RVA = "0x816100", Offset = "0x816100", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600473E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816140", Offset = "0x816140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBestiarySortingId()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000932")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004740")]
				[global::Cpp2ILInjected.Address(RVA = "0x8161A4", Offset = "0x8161A4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004741")]
				[global::Cpp2ILInjected.Address(RVA = "0x8161AC", Offset = "0x8161AC", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004742")]
				[global::Cpp2ILInjected.Address(RVA = "0x816224", Offset = "0x816224", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4008353")]
				public static readonly SortingSteps.ByBestiarySortingId.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x4008354")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				[global::Cpp2ILInjected.Token(Token = "0x4008355")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000933")]
		public class ByBestiaryRarity : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004745")]
			[global::Cpp2ILInjected.Address(RVA = "0x816560", Offset = "0x816560", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004746")]
			[global::Cpp2ILInjected.Address(RVA = "0x8165A0", Offset = "0x8165A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBestiaryRarity()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000934")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004748")]
				[global::Cpp2ILInjected.Address(RVA = "0x816604", Offset = "0x816604", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004749")]
				[global::Cpp2ILInjected.Address(RVA = "0x81660C", Offset = "0x81660C", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600474A")]
				[global::Cpp2ILInjected.Address(RVA = "0x816684", Offset = "0x816684", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4008356")]
				public static readonly SortingSteps.ByBestiaryRarity.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x4008357")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				[global::Cpp2ILInjected.Token(Token = "0x4008358")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000935")]
		public class Alphabetical : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600474D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8169E8", Offset = "0x8169E8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600474E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816A28", Offset = "0x816A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterSortSteps", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Alphabetical()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000936")]
			[Serializable]
			private sealed class <>c
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004750")]
				[global::Cpp2ILInjected.Address(RVA = "0x816A8C", Offset = "0x816A8C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004751")]
				[global::Cpp2ILInjected.Address(RVA = "0x816A94", Offset = "0x816A94", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_0(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004752")]
				[global::Cpp2ILInjected.Address(RVA = "0x816B0C", Offset = "0x816B0C", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				internal bool <Compare>b__2_1(IBestiaryInfoElement element)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4008359")]
				public static readonly SortingSteps.Alphabetical.<>c <>9;

				[global::Cpp2ILInjected.Token(Token = "0x400835A")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_0;

				[global::Cpp2ILInjected.Token(Token = "0x400835B")]
				public static Func<IBestiaryInfoElement, bool> <>9__2_1;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000937")]
		public abstract class ByStat : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004755")]
			public abstract int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY);

			[global::Cpp2ILInjected.Token(Token = "0x6004756")]
			public abstract string GetDisplayNameKey();

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

			[global::Cpp2ILInjected.Token(Token = "0x6004758")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DC4", Offset = "0x816DC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ByStat()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004759")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DCC", Offset = "0x816DCC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortingSteps.ByStat), Member = "IsAStatsCardINeed", MemberParameters = new object[] { typeof(IBestiaryInfoElement) }, ReturnType = typeof(bool))]
			private bool <Compare>b__2_0(IBestiaryInfoElement element)
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x2000938")]
		public class ByAttack : SortingSteps.ByStat
		{
			[global::Cpp2ILInjected.Token(Token = "0x600475B")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DD4", Offset = "0x816DD4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600475C")]
			[global::Cpp2ILInjected.Address(RVA = "0x816DE4", Offset = "0x816DE4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x2000939")]
		public class ByDefense : SortingSteps.ByStat
		{
			[global::Cpp2ILInjected.Token(Token = "0x600475E")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E2C", Offset = "0x816E2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600475F")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E3C", Offset = "0x816E3C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x200093A")]
		public class ByCoins : SortingSteps.ByStat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004761")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E84", Offset = "0x816E84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004762")]
			[global::Cpp2ILInjected.Address(RVA = "0x816E94", Offset = "0x816E94", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

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

		[global::Cpp2ILInjected.Token(Token = "0x200093B")]
		public class ByHP : SortingSteps.ByStat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004764")]
			[global::Cpp2ILInjected.Address(RVA = "0x816EDC", Offset = "0x816EDC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004765")]
			[global::Cpp2ILInjected.Address(RVA = "0x816EEC", Offset = "0x816EEC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

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
