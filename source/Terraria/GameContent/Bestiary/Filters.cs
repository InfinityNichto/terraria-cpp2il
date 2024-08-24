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
	// Token: 0x02000616 RID: 1558
	[global::Cpp2ILInjected.Token(Token = "0x2000926")]
	public static class Filters
	{
		// Token: 0x02000A14 RID: 2580
		[global::Cpp2ILInjected.Token(Token = "0x2000927")]
		public class BySearch : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>, ISearchFilter<BestiaryEntry>
		{
			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06004F8A RID: 20362 RVA: 0x000300B6 File Offset: 0x0002E2B6
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

			// Token: 0x06004F8B RID: 20363 RVA: 0x000300B9 File Offset: 0x0002E2B9
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

			// Token: 0x06004F8C RID: 20364 RVA: 0x000300BC File Offset: 0x0002E2BC
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

			// Token: 0x06004F8D RID: 20365 RVA: 0x000300BF File Offset: 0x0002E2BF
			[global::Cpp2ILInjected.Token(Token = "0x6004712")]
			[global::Cpp2ILInjected.Address(RVA = "0x814430", Offset = "0x814430", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004F8E RID: 20366 RVA: 0x000300C2 File Offset: 0x0002E2C2
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

			// Token: 0x06004F8F RID: 20367 RVA: 0x000300C5 File Offset: 0x0002E2C5
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

			// Token: 0x06004F90 RID: 20368 RVA: 0x000300C8 File Offset: 0x0002E2C8
			[global::Cpp2ILInjected.Token(Token = "0x6004715")]
			[global::Cpp2ILInjected.Address(RVA = "0x814790", Offset = "0x814790", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetSearch(string searchText)
			{
				throw null;
			}

			// Token: 0x04008D7C RID: 36220
			[global::Cpp2ILInjected.Token(Token = "0x400834A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _search;
		}

		// Token: 0x02000A15 RID: 2581
		[global::Cpp2ILInjected.Token(Token = "0x2000928")]
		public class ByUnlockState : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06004F91 RID: 20369 RVA: 0x000300CB File Offset: 0x0002E2CB
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

			// Token: 0x06004F92 RID: 20370 RVA: 0x000300CE File Offset: 0x0002E2CE
			[global::Cpp2ILInjected.Token(Token = "0x6004717")]
			[global::Cpp2ILInjected.Address(RVA = "0x8147EC", Offset = "0x8147EC", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			// Token: 0x06004F93 RID: 20371 RVA: 0x000300D1 File Offset: 0x0002E2D1
			[global::Cpp2ILInjected.Token(Token = "0x6004718")]
			[global::Cpp2ILInjected.Address(RVA = "0x81490C", Offset = "0x81490C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004F94 RID: 20372 RVA: 0x000300D4 File Offset: 0x0002E2D4
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

			// Token: 0x06004F95 RID: 20373 RVA: 0x000300D7 File Offset: 0x0002E2D7
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

			// Token: 0x06004F96 RID: 20374 RVA: 0x000300DA File Offset: 0x0002E2DA
			[global::Cpp2ILInjected.Token(Token = "0x600471B")]
			[global::Cpp2ILInjected.Address(RVA = "0x814C6C", Offset = "0x814C6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByUnlockState()
			{
				throw null;
			}

			// Token: 0x04008D7D RID: 36221
			[global::Cpp2ILInjected.Token(Token = "0x400834B")]
			private const int framesPerRow = 16;

			// Token: 0x04008D7E RID: 36222
			[global::Cpp2ILInjected.Token(Token = "0x400834C")]
			private const int framesPerColumn = 5;
		}

		// Token: 0x02000A16 RID: 2582
		[global::Cpp2ILInjected.Token(Token = "0x2000929")]
		public class ByRareCreature : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06004F97 RID: 20375 RVA: 0x000300DD File Offset: 0x0002E2DD
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

			// Token: 0x06004F98 RID: 20376 RVA: 0x000300E0 File Offset: 0x0002E2E0
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

			// Token: 0x06004F99 RID: 20377 RVA: 0x000300E3 File Offset: 0x0002E2E3
			[global::Cpp2ILInjected.Token(Token = "0x600471E")]
			[global::Cpp2ILInjected.Address(RVA = "0x814D54", Offset = "0x814D54", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004F9A RID: 20378 RVA: 0x000300E6 File Offset: 0x0002E2E6
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

			// Token: 0x06004F9B RID: 20379 RVA: 0x000300E9 File Offset: 0x0002E2E9
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

			// Token: 0x06004F9C RID: 20380 RVA: 0x000300EC File Offset: 0x0002E2EC
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

		// Token: 0x02000A17 RID: 2583
		[global::Cpp2ILInjected.Token(Token = "0x200092A")]
		public class ByBoss : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06004F9D RID: 20381 RVA: 0x000300EF File Offset: 0x0002E2EF
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

			// Token: 0x06004F9E RID: 20382 RVA: 0x000300F2 File Offset: 0x0002E2F2
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

			// Token: 0x06004F9F RID: 20383 RVA: 0x000300F5 File Offset: 0x0002E2F5
			[global::Cpp2ILInjected.Token(Token = "0x6004724")]
			[global::Cpp2ILInjected.Address(RVA = "0x81519C", Offset = "0x81519C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FA0 RID: 20384 RVA: 0x000300F8 File Offset: 0x0002E2F8
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

			// Token: 0x06004FA1 RID: 20385 RVA: 0x000300FB File Offset: 0x0002E2FB
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

			// Token: 0x06004FA2 RID: 20386 RVA: 0x000300FE File Offset: 0x0002E2FE
			[global::Cpp2ILInjected.Token(Token = "0x6004727")]
			[global::Cpp2ILInjected.Address(RVA = "0x8154FC", Offset = "0x8154FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByBoss()
			{
				throw null;
			}

			// Token: 0x04008D7F RID: 36223
			[global::Cpp2ILInjected.Token(Token = "0x400834D")]
			private const int framesPerRow = 16;

			// Token: 0x04008D80 RID: 36224
			[global::Cpp2ILInjected.Token(Token = "0x400834E")]
			private const int framesPerColumn = 5;
		}

		// Token: 0x02000A18 RID: 2584
		[global::Cpp2ILInjected.Token(Token = "0x200092B")]
		public class ByInfoElement : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
		{
			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x00030101 File Offset: 0x0002E301
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

			// Token: 0x06004FA4 RID: 20388 RVA: 0x00030104 File Offset: 0x0002E304
			[global::Cpp2ILInjected.Token(Token = "0x6004729")]
			[global::Cpp2ILInjected.Address(RVA = "0x81550C", Offset = "0x81550C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "RegisterFilters", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByInfoElement(IBestiaryInfoElement element)
			{
				throw null;
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x00030107 File Offset: 0x0002E307
			[global::Cpp2ILInjected.Token(Token = "0x600472A")]
			[global::Cpp2ILInjected.Address(RVA = "0x815534", Offset = "0x815534", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool FitsFilter(BestiaryEntry entry)
			{
				throw null;
			}

			// Token: 0x06004FA6 RID: 20390 RVA: 0x0003010A File Offset: 0x0002E30A
			[global::Cpp2ILInjected.Token(Token = "0x600472B")]
			[global::Cpp2ILInjected.Address(RVA = "0x81558C", Offset = "0x81558C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06004FA7 RID: 20391 RVA: 0x0003010D File Offset: 0x0002E30D
			[global::Cpp2ILInjected.Token(Token = "0x600472C")]
			[global::Cpp2ILInjected.Address(RVA = "0x815644", Offset = "0x815644", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public UIElement GetImage()
			{
				throw null;
			}

			// Token: 0x06004FA8 RID: 20392 RVA: 0x00030110 File Offset: 0x0002E310
			[global::Cpp2ILInjected.Token(Token = "0x600472D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8156F8", Offset = "0x8156F8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void GetDisplay(out Texture2D texture, out Rectangle frame)
			{
				throw null;
			}

			// Token: 0x04008D81 RID: 36225
			[global::Cpp2ILInjected.Token(Token = "0x400834F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IBestiaryInfoElement _element;
		}
	}
}
