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
	// Token: 0x02000684 RID: 1668
	[global::Cpp2ILInjected.Token(Token = "0x2000A17")]
	public static class ItemFilters
	{
		// Token: 0x04006DCD RID: 28109
		[global::Cpp2ILInjected.Token(Token = "0x4008652")]
		private const int framesPerRow = 11;

		// Token: 0x04006DCE RID: 28110
		[global::Cpp2ILInjected.Token(Token = "0x4008653")]
		private const int framesPerColumn = 1;

		// Token: 0x04006DCF RID: 28111
		[global::Cpp2ILInjected.Token(Token = "0x4008654")]
		private const int frameSizeOffsetX = -2;

		// Token: 0x04006DD0 RID: 28112
		[global::Cpp2ILInjected.Token(Token = "0x4008655")]
		private const int frameSizeOffsetY = 0;

		// Token: 0x02000A72 RID: 2674
		[global::Cpp2ILInjected.Token(Token = "0x2000A18")]
		public class BySearch : IItemEntryFilter, IEntryFilter<Item>, ISearchFilter<Item>
		{
			// Token: 0x060050C1 RID: 20673 RVA: 0x000303E0 File Offset: 0x0002E5E0
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

			// Token: 0x060050C2 RID: 20674 RVA: 0x000303E3 File Offset: 0x0002E5E3
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

			// Token: 0x060050C3 RID: 20675 RVA: 0x000303E6 File Offset: 0x0002E5E6
			[global::Cpp2ILInjected.Token(Token = "0x6004C41")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B865C", Offset = "0x8B865C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050C4 RID: 20676 RVA: 0x000303E9 File Offset: 0x0002E5E9
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

			// Token: 0x060050C5 RID: 20677 RVA: 0x000303EC File Offset: 0x0002E5EC
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

			// Token: 0x060050C6 RID: 20678 RVA: 0x000303EF File Offset: 0x0002E5EF
			[global::Cpp2ILInjected.Token(Token = "0x6004C44")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B89BC", Offset = "0x8B89BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetSearch(string searchText)
			{
				throw null;
			}

			// Token: 0x04008E9E RID: 36510
			[global::Cpp2ILInjected.Token(Token = "0x4008656")]
			private const int _tooltipMaxLines = 30;

			// Token: 0x04008E9F RID: 36511
			[global::Cpp2ILInjected.Token(Token = "0x4008657")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string[] _toolTipLines;

			// Token: 0x04008EA0 RID: 36512
			[global::Cpp2ILInjected.Token(Token = "0x4008658")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool[] _unusedPrefixLine;

			// Token: 0x04008EA1 RID: 36513
			[global::Cpp2ILInjected.Token(Token = "0x4008659")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool[] _unusedBadPrefixLines;

			// Token: 0x04008EA2 RID: 36514
			[global::Cpp2ILInjected.Token(Token = "0x400865A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private int _unusedYoyoLogo;

			// Token: 0x04008EA3 RID: 36515
			[global::Cpp2ILInjected.Token(Token = "0x400865B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _unusedResearchLine;

			// Token: 0x04008EA4 RID: 36516
			[global::Cpp2ILInjected.Token(Token = "0x400865C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private int _unusedSetBonusLine;

			// Token: 0x04008EA5 RID: 36517
			[global::Cpp2ILInjected.Token(Token = "0x400865D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			private int _unusedMaterialsLine;

			// Token: 0x04008EA6 RID: 36518
			[global::Cpp2ILInjected.Token(Token = "0x400865E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string _search;
		}

		// Token: 0x02000A73 RID: 2675
		[global::Cpp2ILInjected.Token(Token = "0x2000A19")]
		public class BuildingBlock : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050C7 RID: 20679 RVA: 0x000303F2 File Offset: 0x0002E5F2
			[global::Cpp2ILInjected.Token(Token = "0x6004C45")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B89C4", Offset = "0x8B89C4", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050C8 RID: 20680 RVA: 0x000303F5 File Offset: 0x0002E5F5
			[global::Cpp2ILInjected.Token(Token = "0x6004C46")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8A68", Offset = "0x8B8A68", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050C9 RID: 20681 RVA: 0x000303F8 File Offset: 0x0002E5F8
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

			// Token: 0x060050CA RID: 20682 RVA: 0x000303FB File Offset: 0x0002E5FB
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

			// Token: 0x060050CB RID: 20683 RVA: 0x000303FE File Offset: 0x0002E5FE
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

		// Token: 0x02000A74 RID: 2676
		[global::Cpp2ILInjected.Token(Token = "0x2000A1A")]
		public class Furniture : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050CC RID: 20684 RVA: 0x00030401 File Offset: 0x0002E601
			[global::Cpp2ILInjected.Token(Token = "0x6004C4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8DF0", Offset = "0x8B8DF0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050CD RID: 20685 RVA: 0x00030404 File Offset: 0x0002E604
			[global::Cpp2ILInjected.Token(Token = "0x6004C4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B8E70", Offset = "0x8B8E70", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050CE RID: 20686 RVA: 0x00030407 File Offset: 0x0002E607
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

			// Token: 0x060050CF RID: 20687 RVA: 0x0003040A File Offset: 0x0002E60A
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

			// Token: 0x060050D0 RID: 20688 RVA: 0x0003040D File Offset: 0x0002E60D
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

		// Token: 0x02000A75 RID: 2677
		[global::Cpp2ILInjected.Token(Token = "0x2000A1B")]
		public class Tools : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050D1 RID: 20689 RVA: 0x00030410 File Offset: 0x0002E610
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

			// Token: 0x060050D2 RID: 20690 RVA: 0x00030413 File Offset: 0x0002E613
			[global::Cpp2ILInjected.Token(Token = "0x6004C50")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9294", Offset = "0x8B9294", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050D3 RID: 20691 RVA: 0x00030416 File Offset: 0x0002E616
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

			// Token: 0x060050D4 RID: 20692 RVA: 0x00030419 File Offset: 0x0002E619
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

			// Token: 0x060050D5 RID: 20693 RVA: 0x0003041C File Offset: 0x0002E61C
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

			// Token: 0x04008EA7 RID: 36519
			[global::Cpp2ILInjected.Token(Token = "0x400865F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private HashSet<int> _itemIdsThatAreAccepted;
		}

		// Token: 0x02000A76 RID: 2678
		[global::Cpp2ILInjected.Token(Token = "0x2000A1C")]
		public class Weapon : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050D6 RID: 20694 RVA: 0x0003041F File Offset: 0x0002E61F
			[global::Cpp2ILInjected.Token(Token = "0x6004C54")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9A04", Offset = "0x8B9A04", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050D7 RID: 20695 RVA: 0x00030422 File Offset: 0x0002E622
			[global::Cpp2ILInjected.Token(Token = "0x6004C55")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9A14", Offset = "0x8B9A14", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050D8 RID: 20696 RVA: 0x00030425 File Offset: 0x0002E625
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

			// Token: 0x060050D9 RID: 20697 RVA: 0x00030428 File Offset: 0x0002E628
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

			// Token: 0x060050DA RID: 20698 RVA: 0x0003042B File Offset: 0x0002E62B
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

		// Token: 0x02000A77 RID: 2679
		[global::Cpp2ILInjected.Token(Token = "0x2000A1D")]
		public abstract class AArmor
		{
			// Token: 0x060050DB RID: 20699 RVA: 0x0003042E File Offset: 0x0002E62E
			[global::Cpp2ILInjected.Token(Token = "0x6004C59")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9D9C", Offset = "0x8B9D9C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsAnArmorThatMatchesSocialState(Item entry, bool shouldBeSocial)
			{
				throw null;
			}

			// Token: 0x060050DC RID: 20700 RVA: 0x00030431 File Offset: 0x0002E631
			[global::Cpp2ILInjected.Token(Token = "0x6004C5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9DDC", Offset = "0x8B9DDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AArmor()
			{
				throw null;
			}
		}

		// Token: 0x02000A78 RID: 2680
		[global::Cpp2ILInjected.Token(Token = "0x2000A1E")]
		public class Armor : ItemFilters.AArmor, IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050DD RID: 20701 RVA: 0x00030434 File Offset: 0x0002E634
			[global::Cpp2ILInjected.Token(Token = "0x6004C5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9DE4", Offset = "0x8B9DE4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050DE RID: 20702 RVA: 0x00030437 File Offset: 0x0002E637
			[global::Cpp2ILInjected.Token(Token = "0x6004C5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B9E20", Offset = "0x8B9E20", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050DF RID: 20703 RVA: 0x0003043A File Offset: 0x0002E63A
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

			// Token: 0x060050E0 RID: 20704 RVA: 0x0003043D File Offset: 0x0002E63D
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

			// Token: 0x060050E1 RID: 20705 RVA: 0x00030440 File Offset: 0x0002E640
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

		// Token: 0x02000A79 RID: 2681
		[global::Cpp2ILInjected.Token(Token = "0x2000A1F")]
		public class Vanity : ItemFilters.AArmor, IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050E2 RID: 20706 RVA: 0x00030443 File Offset: 0x0002E643
			[global::Cpp2ILInjected.Token(Token = "0x6004C60")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA1A8", Offset = "0x8BA1A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050E3 RID: 20707 RVA: 0x00030446 File Offset: 0x0002E646
			[global::Cpp2ILInjected.Token(Token = "0x6004C61")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA1E4", Offset = "0x8BA1E4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050E4 RID: 20708 RVA: 0x00030449 File Offset: 0x0002E649
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

			// Token: 0x060050E5 RID: 20709 RVA: 0x0003044C File Offset: 0x0002E64C
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

			// Token: 0x060050E6 RID: 20710 RVA: 0x0003044F File Offset: 0x0002E64F
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

		// Token: 0x02000A7A RID: 2682
		[global::Cpp2ILInjected.Token(Token = "0x2000A20")]
		public abstract class AAccessories
		{
			// Token: 0x060050E7 RID: 20711 RVA: 0x00030452 File Offset: 0x0002E652
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

			// Token: 0x060050E8 RID: 20712 RVA: 0x00030455 File Offset: 0x0002E655
			[global::Cpp2ILInjected.Token(Token = "0x6004C66")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA5FC", Offset = "0x8BA5FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AAccessories()
			{
				throw null;
			}

			// Token: 0x02000BD0 RID: 3024
			[global::Cpp2ILInjected.Token(Token = "0x2000A21")]
			public enum AccessoriesCategory
			{
				// Token: 0x0400915A RID: 37210
				[global::Cpp2ILInjected.Token(Token = "0x4008661")]
				Misc,
				// Token: 0x0400915B RID: 37211
				[global::Cpp2ILInjected.Token(Token = "0x4008662")]
				NonMisc
			}
		}

		// Token: 0x02000A7B RID: 2683
		[global::Cpp2ILInjected.Token(Token = "0x2000A22")]
		public class Accessories : ItemFilters.AAccessories, IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050E9 RID: 20713 RVA: 0x00030458 File Offset: 0x0002E658
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

			// Token: 0x060050EA RID: 20714 RVA: 0x0003045B File Offset: 0x0002E65B
			[global::Cpp2ILInjected.Token(Token = "0x6004C68")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA60C", Offset = "0x8BA60C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050EB RID: 20715 RVA: 0x0003045E File Offset: 0x0002E65E
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

			// Token: 0x060050EC RID: 20716 RVA: 0x00030461 File Offset: 0x0002E661
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

			// Token: 0x060050ED RID: 20717 RVA: 0x00030464 File Offset: 0x0002E664
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

		// Token: 0x02000A7C RID: 2684
		[global::Cpp2ILInjected.Token(Token = "0x2000A23")]
		public class MiscAccessories : ItemFilters.AAccessories, IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050EE RID: 20718 RVA: 0x00030467 File Offset: 0x0002E667
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

			// Token: 0x060050EF RID: 20719 RVA: 0x0003046A File Offset: 0x0002E66A
			[global::Cpp2ILInjected.Token(Token = "0x6004C6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BA99C", Offset = "0x8BA99C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050F0 RID: 20720 RVA: 0x0003046D File Offset: 0x0002E66D
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

			// Token: 0x060050F1 RID: 20721 RVA: 0x00030470 File Offset: 0x0002E670
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

			// Token: 0x060050F2 RID: 20722 RVA: 0x00030473 File Offset: 0x0002E673
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

		// Token: 0x02000A7D RID: 2685
		[global::Cpp2ILInjected.Token(Token = "0x2000A24")]
		public class Consumables : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050F3 RID: 20723 RVA: 0x00030476 File Offset: 0x0002E676
			[global::Cpp2ILInjected.Token(Token = "0x6004C71")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAD24", Offset = "0x8BAD24", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050F4 RID: 20724 RVA: 0x00030479 File Offset: 0x0002E679
			[global::Cpp2ILInjected.Token(Token = "0x6004C72")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BAD84", Offset = "0x8BAD84", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050F5 RID: 20725 RVA: 0x0003047C File Offset: 0x0002E67C
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

			// Token: 0x060050F6 RID: 20726 RVA: 0x0003047F File Offset: 0x0002E67F
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

			// Token: 0x060050F7 RID: 20727 RVA: 0x00030482 File Offset: 0x0002E682
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

		// Token: 0x02000A7E RID: 2686
		[global::Cpp2ILInjected.Token(Token = "0x2000A25")]
		public class GameplayItems : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050F8 RID: 20728 RVA: 0x00030485 File Offset: 0x0002E685
			[global::Cpp2ILInjected.Token(Token = "0x6004C76")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB10C", Offset = "0x8BB10C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x060050F9 RID: 20729 RVA: 0x00030488 File Offset: 0x0002E688
			[global::Cpp2ILInjected.Token(Token = "0x6004C77")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB17C", Offset = "0x8BB17C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x060050FA RID: 20730 RVA: 0x0003048B File Offset: 0x0002E68B
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

			// Token: 0x060050FB RID: 20731 RVA: 0x0003048E File Offset: 0x0002E68E
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

			// Token: 0x060050FC RID: 20732 RVA: 0x00030491 File Offset: 0x0002E691
			[global::Cpp2ILInjected.Token(Token = "0x6004C7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB4FC", Offset = "0x8BB4FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public GameplayItems()
			{
				throw null;
			}
		}

		// Token: 0x02000A7F RID: 2687
		[global::Cpp2ILInjected.Token(Token = "0x2000A26")]
		public class MiscFallback : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x060050FD RID: 20733 RVA: 0x00030494 File Offset: 0x0002E694
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

			// Token: 0x060050FE RID: 20734 RVA: 0x00030497 File Offset: 0x0002E697
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

			// Token: 0x060050FF RID: 20735 RVA: 0x0003049A File Offset: 0x0002E69A
			[global::Cpp2ILInjected.Token(Token = "0x6004C7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BB7D4", Offset = "0x8BB7D4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005100 RID: 20736 RVA: 0x0003049D File Offset: 0x0002E69D
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

			// Token: 0x06005101 RID: 20737 RVA: 0x000304A0 File Offset: 0x0002E6A0
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

			// Token: 0x04008EA8 RID: 36520
			[global::Cpp2ILInjected.Token(Token = "0x4008663")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private bool[] _fitsFilterByItemType;
		}

		// Token: 0x02000A80 RID: 2688
		[global::Cpp2ILInjected.Token(Token = "0x2000A27")]
		public class Materials : IItemEntryFilter, IEntryFilter<Item>
		{
			// Token: 0x06005102 RID: 20738 RVA: 0x000304A3 File Offset: 0x0002E6A3
			[global::Cpp2ILInjected.Token(Token = "0x6004C80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBB54", Offset = "0x8BBB54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool FitsFilter(Item entry)
			{
				throw null;
			}

			// Token: 0x06005103 RID: 20739 RVA: 0x000304A6 File Offset: 0x0002E6A6
			[global::Cpp2ILInjected.Token(Token = "0x6004C81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBB5C", Offset = "0x8BBB5C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005104 RID: 20740 RVA: 0x000304A9 File Offset: 0x0002E6A9
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

			// Token: 0x06005105 RID: 20741 RVA: 0x000304AC File Offset: 0x0002E6AC
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

			// Token: 0x06005106 RID: 20742 RVA: 0x000304AF File Offset: 0x0002E6AF
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
