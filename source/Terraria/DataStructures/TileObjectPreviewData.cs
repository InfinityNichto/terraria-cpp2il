using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x0200047C RID: 1148
	[global::Cpp2ILInjected.Token(Token = "0x200067F")]
	public class TileObjectPreviewData
	{
		// Token: 0x0600324E RID: 12878 RVA: 0x0002B001 File Offset: 0x00029201
		[global::Cpp2ILInjected.Token(Token = "0x6003777")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FEFC", Offset = "0x141FEFC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_TryReplacingTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0002B004 File Offset: 0x00029204
		[global::Cpp2ILInjected.Token(Token = "0x6003778")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FFB0", Offset = "0x141FFB0", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyFrom(TileObjectPreviewData copy)
		{
			throw null;
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x0002B007 File Offset: 0x00029207
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x0002B00A File Offset: 0x0002920A
		[global::Cpp2ILInjected.Token(Token = "0x170006AD")]
		public bool Active
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003779")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420178", Offset = "0x1420178", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600377A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420180", Offset = "0x1420180", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x0002B00D File Offset: 0x0002920D
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x0002B010 File Offset: 0x00029210
		[global::Cpp2ILInjected.Token(Token = "0x170006AE")]
		public ushort Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x600377B")]
			[global::Cpp2ILInjected.Address(RVA = "0x142018C", Offset = "0x142018C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600377C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420194", Offset = "0x1420194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x0002B013 File Offset: 0x00029213
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x0002B016 File Offset: 0x00029216
		[global::Cpp2ILInjected.Token(Token = "0x170006AF")]
		public short Style
		{
			[global::Cpp2ILInjected.Token(Token = "0x600377D")]
			[global::Cpp2ILInjected.Address(RVA = "0x142019C", Offset = "0x142019C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600377E")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201A4", Offset = "0x14201A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x0002B019 File Offset: 0x00029219
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x0002B01C File Offset: 0x0002921C
		[global::Cpp2ILInjected.Token(Token = "0x170006B0")]
		public int Alternate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600377F")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201AC", Offset = "0x14201AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003780")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201B4", Offset = "0x14201B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x0002B01F File Offset: 0x0002921F
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x0002B022 File Offset: 0x00029222
		[global::Cpp2ILInjected.Token(Token = "0x170006B1")]
		public int Random
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003781")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201BC", Offset = "0x14201BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003782")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201C4", Offset = "0x14201C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x0002B025 File Offset: 0x00029225
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x0002B028 File Offset: 0x00029228
		[global::Cpp2ILInjected.Token(Token = "0x170006B2")]
		public Point16 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003783")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201CC", Offset = "0x14201CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003784")]
			[global::Cpp2ILInjected.Address(RVA = "0x14201D4", Offset = "0x14201D4", Length = "0x180")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "SetupPreview", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x0002B02B File Offset: 0x0002922B
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x0002B02E File Offset: 0x0002922E
		[global::Cpp2ILInjected.Token(Token = "0x170006B3")]
		public Point16 Coordinates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003785")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420354", Offset = "0x1420354", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003786")]
			[global::Cpp2ILInjected.Address(RVA = "0x142035C", Offset = "0x142035C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x0002B031 File Offset: 0x00029231
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x0002B034 File Offset: 0x00029234
		[global::Cpp2ILInjected.Token(Token = "0x170006B4")]
		public Point16 ObjectStart
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003787")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420364", Offset = "0x1420364", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003788")]
			[global::Cpp2ILInjected.Address(RVA = "0x142036C", Offset = "0x142036C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x0002B037 File Offset: 0x00029237
		[global::Cpp2ILInjected.Token(Token = "0x6003789")]
		[global::Cpp2ILInjected.Address(RVA = "0x1420374", Offset = "0x1420374", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void AllInvalid()
		{
			throw null;
		}

		// Token: 0x17000633 RID: 1587
		[global::Cpp2ILInjected.Token(Token = "0x170006B5")]
		public int this[int x, int y]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600378A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14203E0", Offset = "0x14203E0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "DrawPreview", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(TileObjectPreviewData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600378B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1420460", Offset = "0x1420460", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(ref TileObject),
				typeof(bool),
				typeof(int?)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0002B040 File Offset: 0x00029240
		[global::Cpp2ILInjected.Token(Token = "0x600378C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14204E0", Offset = "0x14204E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObject), Member = "CanPlace", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref TileObject),
			typeof(bool),
			typeof(int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileObjectPreviewData()
		{
			throw null;
		}

		// Token: 0x04006485 RID: 25733
		[global::Cpp2ILInjected.Token(Token = "0x4007881")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ushort _type;

		// Token: 0x04006486 RID: 25734
		[global::Cpp2ILInjected.Token(Token = "0x4007882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private short _style;

		// Token: 0x04006487 RID: 25735
		[global::Cpp2ILInjected.Token(Token = "0x4007883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _alternate;

		// Token: 0x04006488 RID: 25736
		[global::Cpp2ILInjected.Token(Token = "0x4007884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _random;

		// Token: 0x04006489 RID: 25737
		[global::Cpp2ILInjected.Token(Token = "0x4007885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _active;

		// Token: 0x0400648A RID: 25738
		[global::Cpp2ILInjected.Token(Token = "0x4007886")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
		private Point16 _size;

		// Token: 0x0400648B RID: 25739
		[global::Cpp2ILInjected.Token(Token = "0x4007887")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private Point16 _coordinates;

		// Token: 0x0400648C RID: 25740
		[global::Cpp2ILInjected.Token(Token = "0x4007888")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		private Point16 _objectStart;

		// Token: 0x0400648D RID: 25741
		[global::Cpp2ILInjected.Token(Token = "0x4007889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[,] _data;

		// Token: 0x0400648E RID: 25742
		[global::Cpp2ILInjected.Token(Token = "0x400788A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Point16 _dataSize;

		// Token: 0x0400648F RID: 25743
		[global::Cpp2ILInjected.Token(Token = "0x400788B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private float _percentValid;

		// Token: 0x04006490 RID: 25744
		[global::Cpp2ILInjected.Token(Token = "0x400788C")]
		public static TileObjectPreviewData placementCache;

		// Token: 0x04006491 RID: 25745
		[global::Cpp2ILInjected.Token(Token = "0x400788D")]
		public static TileObjectPreviewData randomCache;

		// Token: 0x04006492 RID: 25746
		[global::Cpp2ILInjected.Token(Token = "0x400788E")]
		public const int None = 0;

		// Token: 0x04006493 RID: 25747
		[global::Cpp2ILInjected.Token(Token = "0x400788F")]
		public const int ValidSpot = 1;

		// Token: 0x04006494 RID: 25748
		[global::Cpp2ILInjected.Token(Token = "0x4007890")]
		public const int InvalidSpot = 2;
	}
}
