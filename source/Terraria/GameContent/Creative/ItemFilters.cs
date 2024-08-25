using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A17")]
	public static class ItemFilters
	{
		[global::Cpp2ILInjected.Token(Token = "0x4008652")]
		private const int framesPerRow = 11;

		[global::Cpp2ILInjected.Token(Token = "0x4008653")]
		private const int framesPerColumn = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4008654")]
		private const int frameSizeOffsetX = -2;

		[global::Cpp2ILInjected.Token(Token = "0x4008655")]
		private const int frameSizeOffsetY = 0;

		[global::Cpp2ILInjected.Token(Token = "0x2000A18")]
		public class BySearch : IItemEntryFilter, IEntryFilter<Item>, ISearchFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B84A0", Offset = "0x8B84A0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public BySearch()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C40")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8534", Offset = "0x8B8534", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(float),
				typeof(ref int),
				typeof(string[]),
				typeof(bool[]),
				typeof(bool[]),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C41")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B865C", Offset = "0x8B865C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C42")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B869C", Offset = "0x8B869C", Length = "0x1A4")]
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C43")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8840", Offset = "0x8B8840", Length = "0x17C")]
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C44")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B89BC", Offset = "0x8B89BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetSearch(string searchText)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008656")]
			private const int _tooltipMaxLines = 30;

			[global::Cpp2ILInjected.Token(Token = "0x4008657")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string[] _toolTipLines;

			[global::Cpp2ILInjected.Token(Token = "0x4008658")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool[] _unusedPrefixLine;

			[global::Cpp2ILInjected.Token(Token = "0x4008659")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool[] _unusedBadPrefixLines;

			[global::Cpp2ILInjected.Token(Token = "0x400865A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _unusedYoyoLogo;

			[global::Cpp2ILInjected.Token(Token = "0x400865B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _unusedResearchLine;

			[global::Cpp2ILInjected.Token(Token = "0x400865C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int _unusedSetBonusLine;

			[global::Cpp2ILInjected.Token(Token = "0x400865D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private int _unusedMaterialsLine;

			[global::Cpp2ILInjected.Token(Token = "0x400865E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string _search;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A19")]
		public class BuildingBlock : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C45")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B89C4", Offset = "0x8B89C4", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C46")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8A68", Offset = "0x8B8A68", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C47")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8AA8", Offset = "0x8B8AA8", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C48")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8C5C", Offset = "0x8B8C5C", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C49")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8DE8", Offset = "0x8B8DE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BuildingBlock()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1A")]
		public class Furniture : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8DF0", Offset = "0x8B8DF0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8E70", Offset = "0x8B8E70", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8EB0", Offset = "0x8B8EB0", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9064", Offset = "0x8B9064", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B91F0", Offset = "0x8B91F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Furniture()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1B")]
		public class Tools : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B91F8", Offset = "0x8B91F8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C50")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9294", Offset = "0x8B9294", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C51")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B92D4", Offset = "0x8B92D4", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C52")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9488", Offset = "0x8B9488", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C53")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9614", Offset = "0x8B9614", Length = "0x3F0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Add", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public Tools()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400865F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private HashSet<int> _itemIdsThatAreAccepted;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1C")]
		public class Weapon : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C54")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9A04", Offset = "0x8B9A04", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C55")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9A14", Offset = "0x8B9A14", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C56")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9A54", Offset = "0x8B9A54", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C57")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9C08", Offset = "0x8B9C08", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C58")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9D94", Offset = "0x8B9D94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Weapon()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1D")]
		public abstract class AArmor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C59")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9D9C", Offset = "0x8B9D9C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsAnArmorThatMatchesSocialState(Item entry, bool shouldBeSocial)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9DDC", Offset = "0x8B9DDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AArmor()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1E")]
		public class Armor : ItemFilters.AArmor, IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9DE4", Offset = "0x8B9DE4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9E20", Offset = "0x8B9E20", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9E60", Offset = "0x8B9E60", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA014", Offset = "0x8BA014", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA1A0", Offset = "0x8BA1A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Armor()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A1F")]
		public class Vanity : ItemFilters.AArmor, IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C60")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA1A8", Offset = "0x8BA1A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C61")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA1E4", Offset = "0x8BA1E4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C62")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA224", Offset = "0x8BA224", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C63")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA3D8", Offset = "0x8BA3D8", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C64")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA564", Offset = "0x8BA564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Vanity()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A20")]
		public abstract class AAccessories
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C65")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA56C", Offset = "0x8BA56C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFilters.Accessories), Member = "FitsFilter", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFilters.MiscAccessories), Member = "FitsFilter", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsMiscEquipment", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool IsAnAccessoryOfType(Item entry, ItemFilters.AAccessories.AccessoriesCategory categoryType)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C66")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA5FC", Offset = "0x8BA5FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AAccessories()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000A21")]
			public enum AccessoriesCategory
			{
				[global::Cpp2ILInjected.Token(Token = "0x4008661")]
				Misc,
				[global::Cpp2ILInjected.Token(Token = "0x4008662")]
				NonMisc
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A22")]
		public class Accessories : ItemFilters.AAccessories, IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C67")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA604", Offset = "0x8BA604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.AAccessories), Member = "IsAnAccessoryOfType", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ItemFilters.AAccessories.AccessoriesCategory)
			}, ReturnType = typeof(bool))]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C68")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA60C", Offset = "0x8BA60C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C69")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA64C", Offset = "0x8BA64C", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA800", Offset = "0x8BA800", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA98C", Offset = "0x8BA98C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Accessories()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A23")]
		public class MiscAccessories : ItemFilters.AAccessories, IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA994", Offset = "0x8BA994", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemFilters.AAccessories), Member = "IsAnAccessoryOfType", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ItemFilters.AAccessories.AccessoriesCategory)
			}, ReturnType = typeof(bool))]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA99C", Offset = "0x8BA99C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA9DC", Offset = "0x8BA9DC", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAB90", Offset = "0x8BAB90", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C70")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAD1C", Offset = "0x8BAD1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MiscAccessories()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A24")]
		public class Consumables : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C71")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAD24", Offset = "0x8BAD24", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C72")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAD84", Offset = "0x8BAD84", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C73")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BADC4", Offset = "0x8BADC4", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C74")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAF78", Offset = "0x8BAF78", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C75")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB104", Offset = "0x8BB104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Consumables()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A25")]
		public class GameplayItems : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C76")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB10C", Offset = "0x8BB10C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB17C", Offset = "0x8BB17C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C78")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB1BC", Offset = "0x8BB1BC", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C79")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB370", Offset = "0x8BB370", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB4FC", Offset = "0x8BB4FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public GameplayItems()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A26")]
		public class MiscFallback : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB504", Offset = "0x8BB504", Length = "0x224")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = "Matches", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeItemSacrificesCatalog), Member = "TryGetSacrificeCountCapToUnlockInfiniteItems", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public MiscFallback(List<IItemEntryFilter> otherFiltersToCheckAgainst)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB728", Offset = "0x8BB728", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "IndexInRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T[]",
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB7D4", Offset = "0x8BB7D4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB814", Offset = "0x8BB814", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB9C8", Offset = "0x8BB9C8", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008663")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool[] _fitsFilterByItemType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A27")]
		public class Materials : IItemEntryFilter, IEntryFilter<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBB54", Offset = "0x8BBB54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBB5C", Offset = "0x8BBB5C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C82")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBB9C", Offset = "0x8BBB9C", Length = "0x1B4")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
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

			[global::Cpp2ILInjected.Token(Token = "0x6004C83")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBD50", Offset = "0x8BBD50", Length = "0x18C")]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C84")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBEDC", Offset = "0x8BBEDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemFilter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Materials()
			{
				throw null;
			}
		}
	}
}
