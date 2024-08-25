using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200067F")]
	public class TileObjectPreviewData
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007881")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ushort _type;

		[global::Cpp2ILInjected.Token(Token = "0x4007882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private short _style;

		[global::Cpp2ILInjected.Token(Token = "0x4007883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _alternate;

		[global::Cpp2ILInjected.Token(Token = "0x4007884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _random;

		[global::Cpp2ILInjected.Token(Token = "0x4007885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _active;

		[global::Cpp2ILInjected.Token(Token = "0x4007886")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
		private Point16 _size;

		[global::Cpp2ILInjected.Token(Token = "0x4007887")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private Point16 _coordinates;

		[global::Cpp2ILInjected.Token(Token = "0x4007888")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		private Point16 _objectStart;

		[global::Cpp2ILInjected.Token(Token = "0x4007889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[,] _data;

		[global::Cpp2ILInjected.Token(Token = "0x400788A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Point16 _dataSize;

		[global::Cpp2ILInjected.Token(Token = "0x400788B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private float _percentValid;

		[global::Cpp2ILInjected.Token(Token = "0x400788C")]
		public static TileObjectPreviewData placementCache;

		[global::Cpp2ILInjected.Token(Token = "0x400788D")]
		public static TileObjectPreviewData randomCache;

		[global::Cpp2ILInjected.Token(Token = "0x400788E")]
		public const int None = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400788F")]
		public const int ValidSpot = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4007890")]
		public const int InvalidSpot = 2;
	}
}
