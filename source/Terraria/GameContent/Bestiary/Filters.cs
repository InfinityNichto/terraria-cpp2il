using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000926")]
	public static class Filters
	{
		[global::Cpp2ILInjected.Token(Token = "0x2000927")]
		public class BySearch : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>, ISearchFilter<BestiaryEntry>
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000815")]
			public bool? ForcedDisplay
			{
				[global::Cpp2ILInjected.Token(Token = "0x600470F")]
				[global::Cpp2ILInjected.Address(RVA = "0x814218", Offset = "0x814218", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004710")]
			[global::Cpp2ILInjected.Address(RVA = "0x81426C", Offset = "0x81426C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "SetSearchTerm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = ".ctor", MemberParameters = new object[] { typeof(BestiaryDatabase) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BySearch()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004711")]
			[global::Cpp2ILInjected.Address(RVA = "0x814274", Offset = "0x814274", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004712")]
			[global::Cpp2ILInjected.Address(RVA = "0x814430", Offset = "0x814430", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004713")]
			[global::Cpp2ILInjected.Address(RVA = "0x814470", Offset = "0x814470", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public UIElement GetImage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004714")]
			[global::Cpp2ILInjected.Address(RVA = "0x814614", Offset = "0x814614", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004715")]
			[global::Cpp2ILInjected.Address(RVA = "0x814790", Offset = "0x814790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetSearch(string searchText)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400834A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _search;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000928")]
		public class ByUnlockState : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000816")]
			public bool? ForcedDisplay
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004716")]
				[global::Cpp2ILInjected.Address(RVA = "0x814798", Offset = "0x814798", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004717")]
			[global::Cpp2ILInjected.Address(RVA = "0x8147EC", Offset = "0x8147EC", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004718")]
			[global::Cpp2ILInjected.Address(RVA = "0x81490C", Offset = "0x81490C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004719")]
			[global::Cpp2ILInjected.Address(RVA = "0x81494C", Offset = "0x81494C", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public UIElement GetImage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600471A")]
			[global::Cpp2ILInjected.Address(RVA = "0x814AF0", Offset = "0x814AF0", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600471B")]
			[global::Cpp2ILInjected.Address(RVA = "0x814C6C", Offset = "0x814C6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByUnlockState()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400834B")]
			private const int framesPerRow = 16;

			[global::Cpp2ILInjected.Token(Token = "0x400834C")]
			private const int framesPerColumn = 5;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000929")]
		public class ByRareCreature : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000817")]
			public bool? ForcedDisplay
			{
				[global::Cpp2ILInjected.Token(Token = "0x600471C")]
				[global::Cpp2ILInjected.Address(RVA = "0x814C74", Offset = "0x814C74", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600471D")]
			[global::Cpp2ILInjected.Address(RVA = "0x814C7C", Offset = "0x814C7C", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600471E")]
			[global::Cpp2ILInjected.Address(RVA = "0x814D54", Offset = "0x814D54", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600471F")]
			[global::Cpp2ILInjected.Address(RVA = "0x814D94", Offset = "0x814D94", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public UIElement GetImage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004720")]
			[global::Cpp2ILInjected.Address(RVA = "0x814F38", Offset = "0x814F38", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004721")]
			[global::Cpp2ILInjected.Address(RVA = "0x8150B4", Offset = "0x8150B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByRareCreature()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x200092A")]
		public class ByBoss : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000818")]
			public bool? ForcedDisplay
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004722")]
				[global::Cpp2ILInjected.Address(RVA = "0x8150BC", Offset = "0x8150BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004723")]
			[global::Cpp2ILInjected.Address(RVA = "0x8150C4", Offset = "0x8150C4", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004724")]
			[global::Cpp2ILInjected.Address(RVA = "0x81519C", Offset = "0x81519C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004725")]
			[global::Cpp2ILInjected.Address(RVA = "0x8151DC", Offset = "0x8151DC", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public UIElement GetImage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004726")]
			[global::Cpp2ILInjected.Address(RVA = "0x815380", Offset = "0x815380", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004727")]
			[global::Cpp2ILInjected.Address(RVA = "0x8154FC", Offset = "0x8154FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBoss()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400834D")]
			private const int framesPerRow = 16;

			[global::Cpp2ILInjected.Token(Token = "0x400834E")]
			private const int framesPerColumn = 5;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200092B")]
		public class ByInfoElement : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000819")]
			public bool? ForcedDisplay
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004728")]
				[global::Cpp2ILInjected.Address(RVA = "0x815504", Offset = "0x815504", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004729")]
			[global::Cpp2ILInjected.Address(RVA = "0x81550C", Offset = "0x81550C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByInfoElement(IBestiaryInfoElement element)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600472A")]
			[global::Cpp2ILInjected.Address(RVA = "0x815534", Offset = "0x815534", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600472B")]
			[global::Cpp2ILInjected.Address(RVA = "0x81558C", Offset = "0x81558C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600472C")]
			[global::Cpp2ILInjected.Address(RVA = "0x815644", Offset = "0x815644", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public UIElement GetImage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600472D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8156F8", Offset = "0x8156F8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400834F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IBestiaryInfoElement _element;
		}
	}
}
