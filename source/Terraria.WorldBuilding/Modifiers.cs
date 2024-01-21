using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035E")]
public static class Modifiers
{
	[Cpp2IlInjected.Token(Token = "0x20008A4")]
	public class ShapeScale : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008073")]
		private int _scale;

		[Cpp2IlInjected.Token(Token = "0x6004B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1303954", Offset = "0x1303954", VA = "0x1303954")]
		public ShapeScale(int scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B9B")]
		[Cpp2IlInjected.Address(RVA = "0x1303980", Offset = "0x1303980", VA = "0x1303980", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A5")]
	public class Expand : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008074")]
		private int _xExpansion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008075")]
		private int _yExpansion;

		[Cpp2IlInjected.Token(Token = "0x6004B9C")]
		[Cpp2IlInjected.Address(RVA = "0x130226C", Offset = "0x130226C", VA = "0x130226C")]
		public Expand(int expansion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B9D")]
		[Cpp2IlInjected.Address(RVA = "0x130229C", Offset = "0x130229C", VA = "0x130229C")]
		public Expand(int xExpansion, int yExpansion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B9E")]
		[Cpp2IlInjected.Address(RVA = "0x13022D0", Offset = "0x13022D0", VA = "0x13022D0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A6")]
	public class RadialDither : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008076")]
		private double _innerRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008077")]
		private double _outerRadius;

		[Cpp2IlInjected.Token(Token = "0x6004B9F")]
		[Cpp2IlInjected.Address(RVA = "0x1303664", Offset = "0x1303664", VA = "0x1303664")]
		public RadialDither(double innerRadius, double outerRadius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA0")]
		[Cpp2IlInjected.Address(RVA = "0x13036A0", Offset = "0x13036A0", VA = "0x13036A0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A7")]
	public class Blotches : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008078")]
		private int _minX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008079")]
		private int _minY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400807A")]
		private int _maxX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400807B")]
		private int _maxY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400807C")]
		private double _chance;

		[Cpp2IlInjected.Token(Token = "0x6004BA1")]
		[Cpp2IlInjected.Address(RVA = "0x1301E8C", Offset = "0x1301E8C", VA = "0x1301E8C")]
		public Blotches(int scale = 2, double chance = 0.3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA2")]
		[Cpp2IlInjected.Address(RVA = "0x1301ECC", Offset = "0x1301ECC", VA = "0x1301ECC")]
		public Blotches(int xScale, int yScale, double chance = 0.3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA3")]
		[Cpp2IlInjected.Address(RVA = "0x1301F10", Offset = "0x1301F10", VA = "0x1301F10")]
		public Blotches(int leftScale, int upScale, int rightScale, int downScale, double chance = 0.3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA4")]
		[Cpp2IlInjected.Address(RVA = "0x1301F5C", Offset = "0x1301F5C", VA = "0x1301F5C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A8")]
	public class InShape : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400807D")]
		private readonly ShapeData _shapeData;

		[Cpp2IlInjected.Token(Token = "0x6004BA5")]
		[Cpp2IlInjected.Address(RVA = "0x1302568", Offset = "0x1302568", VA = "0x1302568")]
		public InShape(ShapeData shapeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA6")]
		[Cpp2IlInjected.Address(RVA = "0x1302594", Offset = "0x1302594", VA = "0x1302594", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A9")]
	public class NotInShape : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400807E")]
		private readonly ShapeData _shapeData;

		[Cpp2IlInjected.Token(Token = "0x6004BA7")]
		[Cpp2IlInjected.Address(RVA = "0x1302F3C", Offset = "0x1302F3C", VA = "0x1302F3C")]
		public NotInShape(ShapeData shapeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BA8")]
		[Cpp2IlInjected.Address(RVA = "0x1302F68", Offset = "0x1302F68", VA = "0x1302F68", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AA")]
	public class Conditions : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400807F")]
		private readonly GenCondition[] _conditions;

		[Cpp2IlInjected.Token(Token = "0x6004BA9")]
		[Cpp2IlInjected.Address(RVA = "0x13020E8", Offset = "0x13020E8", VA = "0x13020E8")]
		public Conditions(params GenCondition[] conditions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAA")]
		[Cpp2IlInjected.Address(RVA = "0x1302114", Offset = "0x1302114", VA = "0x1302114", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AB")]
	public class OnlyWalls : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008080")]
		private ushort[] _types;

		[Cpp2IlInjected.Token(Token = "0x6004BAB")]
		[Cpp2IlInjected.Address(RVA = "0x1303504", Offset = "0x1303504", VA = "0x1303504")]
		public OnlyWalls(params ushort[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAC")]
		[Cpp2IlInjected.Address(RVA = "0x1303530", Offset = "0x1303530", VA = "0x1303530", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AC")]
	public class OnlyTiles : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008081")]
		private ushort[] _types;

		[Cpp2IlInjected.Token(Token = "0x6004BAD")]
		[Cpp2IlInjected.Address(RVA = "0x130331C", Offset = "0x130331C", VA = "0x130331C")]
		public OnlyTiles(params ushort[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BAE")]
		[Cpp2IlInjected.Address(RVA = "0x1303348", Offset = "0x1303348", VA = "0x1303348", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AD")]
	public class IsTouching : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x4008082")]
		private static readonly int[] DIRECTIONS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008083")]
		private bool _useDiagonals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008084")]
		private ushort[] _tileIds;

		[Cpp2IlInjected.Token(Token = "0x6004BAF")]
		[Cpp2IlInjected.Address(RVA = "0x1302A04", Offset = "0x1302A04", VA = "0x1302A04")]
		public IsTouching(bool useDiagonals, params ushort[] tileIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB0")]
		[Cpp2IlInjected.Address(RVA = "0x1302A38", Offset = "0x1302A38", VA = "0x1302A38", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AE")]
	public class NotTouching : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x4008085")]
		private static readonly int[] DIRECTIONS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008086")]
		private bool _useDiagonals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008087")]
		private ushort[] _tileIds;

		[Cpp2IlInjected.Token(Token = "0x6004BB2")]
		[Cpp2IlInjected.Address(RVA = "0x1302FDC", Offset = "0x1302FDC", VA = "0x1302FDC")]
		public NotTouching(bool useDiagonals, params ushort[] tileIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB3")]
		[Cpp2IlInjected.Address(RVA = "0x1303010", Offset = "0x1303010", VA = "0x1303010", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008AF")]
	public class IsTouchingAir : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x4008088")]
		private static readonly int[] DIRECTIONS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008089")]
		private bool _useDiagonals;

		[Cpp2IlInjected.Token(Token = "0x6004BB5")]
		[Cpp2IlInjected.Address(RVA = "0x1302CDC", Offset = "0x1302CDC", VA = "0x1302CDC")]
		public IsTouchingAir(bool useDiagonals = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB6")]
		[Cpp2IlInjected.Address(RVA = "0x1302D08", Offset = "0x1302D08", VA = "0x1302D08", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B0")]
	public class SkipTiles : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400808A")]
		private ushort[] _types;

		[Cpp2IlInjected.Token(Token = "0x6004BB8")]
		[Cpp2IlInjected.Address(RVA = "0x1303B20", Offset = "0x1303B20", VA = "0x1303B20")]
		public SkipTiles(params ushort[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BB9")]
		[Cpp2IlInjected.Address(RVA = "0x1303B4C", Offset = "0x1303B4C", VA = "0x1303B4C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B1")]
	public class HasLiquid : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400808B")]
		private int _liquidType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400808C")]
		private int _liquidLevel;

		[Cpp2IlInjected.Token(Token = "0x6004BBA")]
		[Cpp2IlInjected.Address(RVA = "0x13023F8", Offset = "0x13023F8", VA = "0x13023F8")]
		public HasLiquid(int liquidLevel = -1, int liquidType = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BBB")]
		[Cpp2IlInjected.Address(RVA = "0x130242C", Offset = "0x130242C", VA = "0x130242C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B2")]
	public class SkipWalls : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400808D")]
		private ushort[] _types;

		[Cpp2IlInjected.Token(Token = "0x6004BBC")]
		[Cpp2IlInjected.Address(RVA = "0x1303D44", Offset = "0x1303D44", VA = "0x1303D44")]
		public SkipWalls(params ushort[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BBD")]
		[Cpp2IlInjected.Address(RVA = "0x1303D70", Offset = "0x1303D70", VA = "0x1303D70", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B3")]
	public class IsEmpty : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004BBE")]
		[Cpp2IlInjected.Address(RVA = "0x1302608", Offset = "0x1302608", VA = "0x1302608", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BBF")]
		[Cpp2IlInjected.Address(RVA = "0x13026FC", Offset = "0x13026FC", VA = "0x13026FC")]
		public IsEmpty()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B4")]
	public class IsSolid : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004BC0")]
		[Cpp2IlInjected.Address(RVA = "0x1302888", Offset = "0x1302888", VA = "0x1302888", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC1")]
		[Cpp2IlInjected.Address(RVA = "0x13029F4", Offset = "0x13029F4", VA = "0x13029F4")]
		public IsSolid()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B5")]
	public class IsNotSolid : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004BC2")]
		[Cpp2IlInjected.Address(RVA = "0x130270C", Offset = "0x130270C", VA = "0x130270C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC3")]
		[Cpp2IlInjected.Address(RVA = "0x1302878", Offset = "0x1302878", VA = "0x1302878")]
		public IsNotSolid()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B6")]
	public class RectangleMask : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400808E")]
		private int _xMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400808F")]
		private int _yMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008090")]
		private int _xMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008091")]
		private int _yMax;

		[Cpp2IlInjected.Token(Token = "0x6004BC4")]
		[Cpp2IlInjected.Address(RVA = "0x1303898", Offset = "0x1303898", VA = "0x1303898")]
		public RectangleMask(int xMin, int xMax, int yMin, int yMax)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC5")]
		[Cpp2IlInjected.Address(RVA = "0x13038DC", Offset = "0x13038DC", VA = "0x13038DC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B7")]
	public class Offset : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008092")]
		private int _xOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008093")]
		private int _yOffset;

		[Cpp2IlInjected.Token(Token = "0x6004BC6")]
		[Cpp2IlInjected.Address(RVA = "0x13032B4", Offset = "0x13032B4", VA = "0x13032B4")]
		public Offset(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC7")]
		[Cpp2IlInjected.Address(RVA = "0x13032E8", Offset = "0x13032E8", VA = "0x13032E8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B8")]
	public class Dither : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008094")]
		private double _failureChance;

		[Cpp2IlInjected.Token(Token = "0x6004BC8")]
		[Cpp2IlInjected.Address(RVA = "0x13021BC", Offset = "0x13021BC", VA = "0x13021BC")]
		public Dither(double failureChance = 0.5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BC9")]
		[Cpp2IlInjected.Address(RVA = "0x13021F0", Offset = "0x13021F0", VA = "0x13021F0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008B9")]
	public class Flip : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008095")]
		private bool _flipX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008096")]
		private bool _flipY;

		[Cpp2IlInjected.Token(Token = "0x6004BCA")]
		[Cpp2IlInjected.Address(RVA = "0x1302384", Offset = "0x1302384", VA = "0x1302384")]
		public Flip(bool flipX, bool flipY)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCB")]
		[Cpp2IlInjected.Address(RVA = "0x13023B8", Offset = "0x13023B8", VA = "0x13023B8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}
}
