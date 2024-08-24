using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse
{
	// Token: 0x02000609 RID: 1545
	[global::Cpp2ILInjected.Token(Token = "0x200090D")]
	public class HouseBuilder
	{
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x0002D0E0 File Offset: 0x0002B2E0
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x0002D0E3 File Offset: 0x0002B2E3
		[global::Cpp2ILInjected.Token(Token = "0x170007FD")]
		public double ChestChance
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004686")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4B0", Offset = "0x7DC4B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004687")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4B8", Offset = "0x7DC4B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x0002D0E6 File Offset: 0x0002B2E6
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0002D0E9 File Offset: 0x0002B2E9
		[global::Cpp2ILInjected.Token(Token = "0x170007FE")]
		public ushort TileType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004688")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4C0", Offset = "0x7DC4C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004689")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4C8", Offset = "0x7DC4C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0002D0EF File Offset: 0x0002B2EF
		[global::Cpp2ILInjected.Token(Token = "0x170007FF")]
		public ushort WallType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4D0", Offset = "0x7DC4D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4D8", Offset = "0x7DC4D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0002D0F2 File Offset: 0x0002B2F2
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0002D0F5 File Offset: 0x0002B2F5
		[global::Cpp2ILInjected.Token(Token = "0x17000800")]
		public ushort BeamType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4E0", Offset = "0x7DC4E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4E8", Offset = "0x7DC4E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x0002D0FB File Offset: 0x0002B2FB
		[global::Cpp2ILInjected.Token(Token = "0x17000801")]
		public int PlatformStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4F0", Offset = "0x7DC4F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600468F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC4F8", Offset = "0x7DC4F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0002D0FE File Offset: 0x0002B2FE
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0002D101 File Offset: 0x0002B301
		[global::Cpp2ILInjected.Token(Token = "0x17000802")]
		public int DoorStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004690")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC500", Offset = "0x7DC500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004691")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC508", Offset = "0x7DC508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0002D104 File Offset: 0x0002B304
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0002D107 File Offset: 0x0002B307
		[global::Cpp2ILInjected.Token(Token = "0x17000803")]
		public int TableStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004692")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC510", Offset = "0x7DC510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004693")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC518", Offset = "0x7DC518", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x0002D10A File Offset: 0x0002B30A
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x0002D10D File Offset: 0x0002B30D
		[global::Cpp2ILInjected.Token(Token = "0x17000804")]
		public bool UsesTables2
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004694")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC520", Offset = "0x7DC520", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004695")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC528", Offset = "0x7DC528", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x0002D110 File Offset: 0x0002B310
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x0002D113 File Offset: 0x0002B313
		[global::Cpp2ILInjected.Token(Token = "0x17000805")]
		public int WorkbenchStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004696")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC534", Offset = "0x7DC534", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004697")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC53C", Offset = "0x7DC53C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x0002D116 File Offset: 0x0002B316
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x0002D119 File Offset: 0x0002B319
		[global::Cpp2ILInjected.Token(Token = "0x17000806")]
		public int PianoStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004698")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC544", Offset = "0x7DC544", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004699")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC54C", Offset = "0x7DC54C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x0002D11C File Offset: 0x0002B31C
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x0002D11F File Offset: 0x0002B31F
		[global::Cpp2ILInjected.Token(Token = "0x17000807")]
		public int BookcaseStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC554", Offset = "0x7DC554", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469B")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC55C", Offset = "0x7DC55C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x0002D122 File Offset: 0x0002B322
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x0002D125 File Offset: 0x0002B325
		[global::Cpp2ILInjected.Token(Token = "0x17000808")]
		public int ChairStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC564", Offset = "0x7DC564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469D")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC56C", Offset = "0x7DC56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x0002D128 File Offset: 0x0002B328
		// (set) Token: 0x06003DFD RID: 15869 RVA: 0x0002D12B File Offset: 0x0002B32B
		[global::Cpp2ILInjected.Token(Token = "0x17000809")]
		public int ChestStyle
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469E")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC574", Offset = "0x7DC574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600469F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC57C", Offset = "0x7DC57C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x0002D12E File Offset: 0x0002B32E
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x0002D131 File Offset: 0x0002B331
		[global::Cpp2ILInjected.Token(Token = "0x1700080A")]
		public bool UsesContainers2
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60046A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC584", Offset = "0x7DC584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60046A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC58C", Offset = "0x7DC58C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x0002D134 File Offset: 0x0002B334
		// (set) Token: 0x06003E01 RID: 15873 RVA: 0x0002D137 File Offset: 0x0002B337
		[global::Cpp2ILInjected.Token(Token = "0x1700080B")]
		public ReadOnlyCollection<Rectangle> Rooms
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60046A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC598", Offset = "0x7DC598", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60046A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC5A0", Offset = "0x7DC5A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x0002D13A File Offset: 0x0002B33A
		[global::Cpp2ILInjected.Token(Token = "0x1700080C")]
		public Rectangle TopRoom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC5A8", Offset = "0x7DC5A8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreatePlatformsList", ReturnType = typeof(List<Point>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "First", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x0002D13D File Offset: 0x0002B33D
		[global::Cpp2ILInjected.Token(Token = "0x1700080D")]
		public Rectangle BottomRoom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC5F0", Offset = "0x7DC5F0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreatePlatformsList", ReturnType = typeof(List<Point>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Last", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = "TSource")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x0002D140 File Offset: 0x0002B340
		[global::Cpp2ILInjected.Token(Token = "0x1700080E")]
		private UnifiedRandom _random
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC638", Offset = "0x7DC638", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "FillRooms", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceChests", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceBiomeSpecificPriorityTool", MemberParameters = new object[] { typeof(HouseBuilderContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceBiomeSpecificTool", MemberParameters = new object[] { typeof(HouseBuilderContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x0002D143 File Offset: 0x0002B343
		[global::Cpp2ILInjected.Token(Token = "0x1700080F")]
		private TileData _tiles
		{
			[global::Cpp2ILInjected.Token(Token = "0x60046A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x7DC688", Offset = "0x7DC688", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x0002D146 File Offset: 0x0002B346
		[global::Cpp2ILInjected.Token(Token = "0x60046A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DC6E0", Offset = "0x7DC6E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private HouseBuilder()
		{
			throw null;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x0002D149 File Offset: 0x0002B349
		[global::Cpp2ILInjected.Token(Token = "0x60046A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DB3B4", Offset = "0x7DB3B4", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IceHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JungleHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MushroomHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[] { typeof(IEnumerable<Rectangle>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<Rectangle>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<Rectangle>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected HouseBuilder(HouseType type, IEnumerable<Rectangle> rooms)
		{
			throw null;
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x0002D14C File Offset: 0x0002B34C
		[global::Cpp2ILInjected.Token(Token = "0x60046AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DC76C", Offset = "0x7DC76C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void AgeRoom(Rectangle room)
		{
			throw null;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x0002D14F File Offset: 0x0002B34F
		[global::Cpp2ILInjected.Token(Token = "0x60046AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DC770", Offset = "0x7DC770", Length = "0x4F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WoodHouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceEmptyRooms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StructureMap), Member = "AddProtectedStructure", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceDoors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceSupportBeams", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceBiomeSpecificPriorityTool", MemberParameters = new object[] { typeof(HouseBuilderContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "FillRooms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "PlaceBiomeSpecificTool", MemberParameters = new object[] { typeof(HouseBuilderContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public virtual void Place(HouseBuilderContext context, StructureMap structures)
		{
			throw null;
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0002D152 File Offset: 0x0002B352
		[global::Cpp2ILInjected.Token(Token = "0x60046AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DCC68", Offset = "0x7DCC68", Length = "0x554")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTileKeepWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetFrames), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearTile), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		private void PlaceEmptyRooms()
		{
			throw null;
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x0002D155 File Offset: 0x0002B355
		[global::Cpp2ILInjected.Token(Token = "0x60046AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DE958", Offset = "0x7DE958", Length = "0x9A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RandHousePictureDesert", ReturnType = typeof(PaintingEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "set_frameX", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "RandHousePicture", ReturnType = typeof(PaintingEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SetupStatueList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceSmallPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceStatueTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(Point) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Point[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private void FillRooms()
		{
			throw null;
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0002D158 File Offset: 0x0002B358
		[global::Cpp2ILInjected.Token(Token = "0x60046AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DD1BC", Offset = "0x7DD1BC", Length = "0x59C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "CreateStairsList", ReturnType = typeof(List<Tuple<Point, Point>>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ModShapes.All), Member = ".ctor", MemberParameters = new object[] { typeof(ShapeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceTile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetSlope), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetFrames), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Clear), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		private void PlaceStairs()
		{
			throw null;
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x0002D15B File Offset: 0x0002B35B
		[global::Cpp2ILInjected.Token(Token = "0x60046AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E0518", Offset = "0x7E0518", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceStairs", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<Point, Point>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private List<Tuple<Point, Point>> CreateStairsList()
		{
			throw null;
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0002D15E File Offset: 0x0002B35E
		[global::Cpp2ILInjected.Token(Token = "0x60046B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DD758", Offset = "0x7DD758", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "CreateDoorList", ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearTile), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void PlaceDoors()
		{
			throw null;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0002D161 File Offset: 0x0002B361
		[global::Cpp2ILInjected.Token(Token = "0x60046B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E0764", Offset = "0x7E0764", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceDoors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "FindSideExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private List<Point> CreateDoorList()
		{
			throw null;
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x0002D164 File Offset: 0x0002B364
		[global::Cpp2ILInjected.Token(Token = "0x60046B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DD970", Offset = "0x7DD970", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "CreatePlatformsList", ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.ClearMetadata), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.PlaceTile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetFrames), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void PlacePlatforms()
		{
			throw null;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x0002D167 File Offset: 0x0002B367
		[global::Cpp2ILInjected.Token(Token = "0x60046B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E0D5C", Offset = "0x7E0D5C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlacePlatforms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get_TopRoom", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get_BottomRoom", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "FindVerticalExit", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private List<Point> CreatePlatformsList()
		{
			throw null;
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x0002D16A File Offset: 0x0002B36A
		[global::Cpp2ILInjected.Token(Token = "0x60046B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DDC6C", Offset = "0x7DDC6C", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "CreateSupportBeamList", ReturnType = typeof(List<Rectangle>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shapes.Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetTileKeepWall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.SetFrames), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions), Member = "Chain", MemberParameters = new object[] { typeof(GenAction[]) }, ReturnType = typeof(GenAction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Gen", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenShape),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "slope", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void PlaceSupportBeams()
		{
			throw null;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0002D16D File Offset: 0x0002B36D
		[global::Cpp2ILInjected.Token(Token = "0x60046B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E1124", Offset = "0x7E1124", Length = "0x544")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "PlaceSupportBeams", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Rectangle>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<Rectangle, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Min", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(Func<Rectangle, int>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Max", MemberTypeParameters = new object[] { typeof(Rectangle) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<Rectangle>),
			typeof(Func<Rectangle, int>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Down), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private List<Rectangle> CreateSupportBeamList()
		{
			throw null;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0002D170 File Offset: 0x0002B370
		[global::Cpp2ILInjected.Token(Token = "0x60046B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E0FA8", Offset = "0x7E0FA8", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreatePlatformsList", ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Left), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "Not", ReturnType = typeof(GenCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "AreaOr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GenCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool FindVerticalExit(Rectangle wall, bool isUp, out int exitX)
		{
			throw null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x0002D173 File Offset: 0x0002B373
		[global::Cpp2ILInjected.Token(Token = "0x60046B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E0BDC", Offset = "0x7E0BDC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "CreateDoorList", ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches.Up), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Conditions.IsSolid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "Not", ReturnType = typeof(GenCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenCondition), Member = "AreaOr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GenCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Searches), Member = "Chain", MemberParameters = new object[]
		{
			typeof(GenSearch),
			typeof(GenCondition[])
		}, ReturnType = typeof(GenSearch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUtils), Member = "Find", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenSearch),
			typeof(ref Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool FindSideExit(Rectangle wall, bool isLeft, out int exitY)
		{
			throw null;
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0002D176 File Offset: 0x0002B376
		[global::Cpp2ILInjected.Token(Token = "0x60046B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DF2F8", Offset = "0x7DF2F8", Length = "0x900")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "AddBuriedChest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void PlaceChests()
		{
			throw null;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0002D179 File Offset: 0x0002B379
		[global::Cpp2ILInjected.Token(Token = "0x60046B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DE030", Offset = "0x7DE030", Length = "0x928")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private void PlaceBiomeSpecificPriorityTool(HouseBuilderContext context)
		{
			throw null;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0002D17C File Offset: 0x0002B37C
		[global::Cpp2ILInjected.Token(Token = "0x60046BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x7DFBF8", Offset = "0x7DFBF8", Length = "0x920")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseBuilder), Member = "Place", MemberParameters = new object[]
		{
			typeof(HouseBuilderContext),
			typeof(StructureMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = "get__random", ReturnType = typeof(UnifiedRandom))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<Rectangle>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private void PlaceBiomeSpecificTool(HouseBuilderContext context)
		{
			throw null;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0002D17F File Offset: 0x0002B37F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60046BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x7E1668", Offset = "0x7E1668", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HouseBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static HouseBuilder()
		{
			throw null;
		}

		// Token: 0x04006C15 RID: 27669
		[global::Cpp2ILInjected.Token(Token = "0x4008292")]
		private const int VERTICAL_EXIT_WIDTH = 3;

		// Token: 0x04006C16 RID: 27670
		[global::Cpp2ILInjected.Token(Token = "0x4008293")]
		public static readonly HouseBuilder Invalid;

		// Token: 0x04006C17 RID: 27671
		[global::Cpp2ILInjected.Token(Token = "0x4008294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly HouseType Type;

		// Token: 0x04006C18 RID: 27672
		[global::Cpp2ILInjected.Token(Token = "0x4008295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly bool IsValid;

		// Token: 0x04006C19 RID: 27673
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private double <ChestChance>k__BackingField;

		// Token: 0x04006C1A RID: 27674
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ushort <TileType>k__BackingField;

		// Token: 0x04006C1B RID: 27675
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private ushort <WallType>k__BackingField;

		// Token: 0x04006C1C RID: 27676
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private ushort <BeamType>k__BackingField;

		// Token: 0x04006C1D RID: 27677
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int <PlatformStyle>k__BackingField;

		// Token: 0x04006C1E RID: 27678
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int <DoorStyle>k__BackingField;

		// Token: 0x04006C1F RID: 27679
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int <TableStyle>k__BackingField;

		// Token: 0x04006C20 RID: 27680
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool <UsesTables2>k__BackingField;

		// Token: 0x04006C21 RID: 27681
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <WorkbenchStyle>k__BackingField;

		// Token: 0x04006C22 RID: 27682
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400829F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int <PianoStyle>k__BackingField;

		// Token: 0x04006C23 RID: 27683
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40082A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int <BookcaseStyle>k__BackingField;

		// Token: 0x04006C24 RID: 27684
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40082A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int <ChairStyle>k__BackingField;

		// Token: 0x04006C25 RID: 27685
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40082A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int <ChestStyle>k__BackingField;

		// Token: 0x04006C26 RID: 27686
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40082A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private bool <UsesContainers2>k__BackingField;

		// Token: 0x04006C27 RID: 27687
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40082A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ReadOnlyCollection<Rectangle> <Rooms>k__BackingField;

		// Token: 0x04006C28 RID: 27688
		[global::Cpp2ILInjected.Token(Token = "0x40082A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected ushort[] SkipTilesDuringWallAging;

		// Token: 0x02000A0E RID: 2574
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200090E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F74 RID: 20340 RVA: 0x00030080 File Offset: 0x0002E280
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60046BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x7E16C0", Offset = "0x7E16C0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004F75 RID: 20341 RVA: 0x00030083 File Offset: 0x0002E283
			[global::Cpp2ILInjected.Token(Token = "0x60046BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x7E171C", Offset = "0x7E171C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004F76 RID: 20342 RVA: 0x00030086 File Offset: 0x0002E286
			[global::Cpp2ILInjected.Token(Token = "0x60046BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x7E1724", Offset = "0x7E1724", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			internal int <.ctor>b__74_0(Rectangle lhs, Rectangle rhs)
			{
				throw null;
			}

			// Token: 0x06004F77 RID: 20343 RVA: 0x00030089 File Offset: 0x0002E289
			[global::Cpp2ILInjected.Token(Token = "0x60046BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7E1748", Offset = "0x7E1748", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal int <CreateSupportBeamList>b__86_0(Rectangle room)
			{
				throw null;
			}

			// Token: 0x06004F78 RID: 20344 RVA: 0x0003008C File Offset: 0x0002E28C
			[global::Cpp2ILInjected.Token(Token = "0x60046C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x7E1750", Offset = "0x7E1750", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
			internal int <CreateSupportBeamList>b__86_1(Rectangle room)
			{
				throw null;
			}

			// Token: 0x04008D30 RID: 36144
			[global::Cpp2ILInjected.Token(Token = "0x40082A6")]
			public static readonly HouseBuilder.<>c <>9;

			// Token: 0x04008D31 RID: 36145
			[global::Cpp2ILInjected.Token(Token = "0x40082A7")]
			public static Comparison<Rectangle> <>9__74_0;

			// Token: 0x04008D32 RID: 36146
			[global::Cpp2ILInjected.Token(Token = "0x40082A8")]
			public static Func<Rectangle, int> <>9__86_0;

			// Token: 0x04008D33 RID: 36147
			[global::Cpp2ILInjected.Token(Token = "0x40082A9")]
			public static Func<Rectangle, int> <>9__86_1;
		}
	}
}
