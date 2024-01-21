using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000358")]
public static class Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000881")]
	public class ContinueWrapper : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400804D")]
		private GenAction _action;

		[Cpp2IlInjected.Token(Token = "0x6004B4E")]
		[Cpp2IlInjected.Address(RVA = "0x12FDBBC", Offset = "0x12FDBBC", VA = "0x12FDBBC")]
		public ContinueWrapper(GenAction action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B4F")]
		[Cpp2IlInjected.Address(RVA = "0x12FDF90", Offset = "0x12FDF90", VA = "0x12FDF90", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000882")]
	public class Count : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400804E")]
		private Ref<int> _count;

		[Cpp2IlInjected.Token(Token = "0x6004B50")]
		[Cpp2IlInjected.Address(RVA = "0x12FDFF4", Offset = "0x12FDFF4", VA = "0x12FDFF4")]
		public Count(Ref<int> count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B51")]
		[Cpp2IlInjected.Address(RVA = "0x12FE020", Offset = "0x12FE020", VA = "0x12FE020", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000883")]
	public class Scanner : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400804F")]
		private Ref<int> _count;

		[Cpp2IlInjected.Token(Token = "0x6004B52")]
		[Cpp2IlInjected.Address(RVA = "0x12FEAA4", Offset = "0x12FEAA4", VA = "0x12FEAA4")]
		public Scanner(Ref<int> count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B53")]
		[Cpp2IlInjected.Address(RVA = "0x12FEAD0", Offset = "0x12FEAD0", VA = "0x12FEAD0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000884")]
	public class TileScanner : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008050")]
		private ushort[] _tileIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008051")]
		private Dictionary<ushort, int> _tileCounts;

		[Cpp2IlInjected.Token(Token = "0x6004B54")]
		[Cpp2IlInjected.Address(RVA = "0x12FF6D0", Offset = "0x12FF6D0", VA = "0x12FF6D0")]
		public TileScanner(params ushort[] tiles)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B55")]
		[Cpp2IlInjected.Address(RVA = "0x12FF7D8", Offset = "0x12FF7D8", VA = "0x12FF7D8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B56")]
		[Cpp2IlInjected.Address(RVA = "0x12FF978", Offset = "0x12FF978", VA = "0x12FF978")]
		public TileScanner Output(Dictionary<ushort, int> resultsOutput)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B57")]
		[Cpp2IlInjected.Address(RVA = "0x12FFA50", Offset = "0x12FFA50", VA = "0x12FFA50")]
		public Dictionary<ushort, int> GetResults()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B58")]
		[Cpp2IlInjected.Address(RVA = "0x12FFA58", Offset = "0x12FFA58", VA = "0x12FFA58")]
		public int GetCount(ushort tileId)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000885")]
	public class Blank : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004B59")]
		[Cpp2IlInjected.Address(RVA = "0x12FDBE8", Offset = "0x12FDBE8", VA = "0x12FDBE8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5A")]
		[Cpp2IlInjected.Address(RVA = "0x12FDC88", Offset = "0x12FDC88", VA = "0x12FDC88")]
		public Blank()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000886")]
	public class Custom : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008052")]
		private CustomPerUnitAction _perUnit;

		[Cpp2IlInjected.Token(Token = "0x6004B5B")]
		[Cpp2IlInjected.Address(RVA = "0x12FE058", Offset = "0x12FE058", VA = "0x12FE058")]
		public Custom(CustomPerUnitAction perUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5C")]
		[Cpp2IlInjected.Address(RVA = "0x12FE084", Offset = "0x12FE084", VA = "0x12FE084", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000887")]
	public class ClearMetadata : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004B5D")]
		[Cpp2IlInjected.Address(RVA = "0x12FDD94", Offset = "0x12FDD94", VA = "0x12FDD94", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5E")]
		[Cpp2IlInjected.Address(RVA = "0x12FDE70", Offset = "0x12FDE70", VA = "0x12FDE70")]
		public ClearMetadata()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000888")]
	public class Clear : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004B5F")]
		[Cpp2IlInjected.Address(RVA = "0x12FDCA8", Offset = "0x12FDCA8", VA = "0x12FDCA8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B60")]
		[Cpp2IlInjected.Address(RVA = "0x12FDD84", Offset = "0x12FDD84", VA = "0x12FDD84")]
		public Clear()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000889")]
	public class ClearTile : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008053")]
		private bool _frameNeighbors;

		[Cpp2IlInjected.Token(Token = "0x6004B61")]
		[Cpp2IlInjected.Address(RVA = "0x12FDE80", Offset = "0x12FDE80", VA = "0x12FDE80")]
		public ClearTile(bool frameNeighbors = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B62")]
		[Cpp2IlInjected.Address(RVA = "0x12FDEAC", Offset = "0x12FDEAC", VA = "0x12FDEAC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088A")]
	public class ClearWall : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008054")]
		private bool _frameNeighbors;

		[Cpp2IlInjected.Token(Token = "0x6004B63")]
		[Cpp2IlInjected.Address(RVA = "0x12FDF08", Offset = "0x12FDF08", VA = "0x12FDF08")]
		public ClearWall(bool frameNeighbors = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B64")]
		[Cpp2IlInjected.Address(RVA = "0x12FDF34", Offset = "0x12FDF34", VA = "0x12FDF34", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088B")]
	public class HalfBlock : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008055")]
		private bool _value;

		[Cpp2IlInjected.Token(Token = "0x6004B65")]
		[Cpp2IlInjected.Address(RVA = "0x12FE5A0", Offset = "0x12FE5A0", VA = "0x12FE5A0")]
		public HalfBlock(bool value = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B66")]
		[Cpp2IlInjected.Address(RVA = "0x12FE5CC", Offset = "0x12FE5CC", VA = "0x12FE5CC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088C")]
	public class SetTile : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008056")]
		private ushort _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008057")]
		private bool _doFraming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4008058")]
		private bool _doNeighborFraming;

		[Cpp2IlInjected.Token(Token = "0x6004B67")]
		[Cpp2IlInjected.Address(RVA = "0x12FEEB0", Offset = "0x12FEEB0", VA = "0x12FEEB0")]
		public SetTile(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B68")]
		[Cpp2IlInjected.Address(RVA = "0x12FEEEC", Offset = "0x12FEEEC", VA = "0x12FEEEC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088D")]
	public class SetTileKeepWall : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008059")]
		private ushort _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400805A")]
		private bool _doFraming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400805B")]
		private bool _doNeighborFraming;

		[Cpp2IlInjected.Token(Token = "0x6004B69")]
		[Cpp2IlInjected.Address(RVA = "0x12FF268", Offset = "0x12FF268", VA = "0x12FF268")]
		public SetTileKeepWall(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B6A")]
		[Cpp2IlInjected.Address(RVA = "0x12FF2A4", Offset = "0x12FF2A4", VA = "0x12FF2A4", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088E")]
	public class DebugDraw : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400805C")]
		private Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400805D")]
		private SpriteBatch _spriteBatch;

		[Cpp2IlInjected.Token(Token = "0x6004B6B")]
		[Cpp2IlInjected.Address(RVA = "0x12FE3E8", Offset = "0x12FE3E8", VA = "0x12FE3E8")]
		public DebugDraw(SpriteBatch spriteBatch, [Optional] Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B6C")]
		[Cpp2IlInjected.Address(RVA = "0x12FE41C", Offset = "0x12FE41C", VA = "0x12FE41C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200088F")]
	public class SetSlope : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400805E")]
		private int _slope;

		[Cpp2IlInjected.Token(Token = "0x6004B6D")]
		[Cpp2IlInjected.Address(RVA = "0x12FEDC0", Offset = "0x12FEDC0", VA = "0x12FEDC0")]
		public SetSlope(int slope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B6E")]
		[Cpp2IlInjected.Address(RVA = "0x12FEDEC", Offset = "0x12FEDEC", VA = "0x12FEDEC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000890")]
	public class SetHalfTile : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400805F")]
		private bool _halfTile;

		[Cpp2IlInjected.Token(Token = "0x6004B6F")]
		[Cpp2IlInjected.Address(RVA = "0x12FEB90", Offset = "0x12FEB90", VA = "0x12FEB90")]
		public SetHalfTile(bool halfTile)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B70")]
		[Cpp2IlInjected.Address(RVA = "0x12FEBBC", Offset = "0x12FEBBC", VA = "0x12FEBBC", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000891")]
	public class SetTileAndWallRainbowPaint : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004B71")]
		[Cpp2IlInjected.Address(RVA = "0x12FF00C", Offset = "0x12FF00C", VA = "0x12FF00C")]
		public SetTileAndWallRainbowPaint()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B72")]
		[Cpp2IlInjected.Address(RVA = "0x12FF01C", Offset = "0x12FF01C", VA = "0x12FF01C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B73")]
		[Cpp2IlInjected.Address(RVA = "0x12FF180", Offset = "0x12FF180", VA = "0x12FF180")]
		private byte GetPaintIDForPosition(int x, int y)
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000892")]
	public class PlaceTile : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008060")]
		private ushort _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008061")]
		private int _style;

		[Cpp2IlInjected.Token(Token = "0x6004B74")]
		[Cpp2IlInjected.Address(RVA = "0x12FE6AC", Offset = "0x12FE6AC", VA = "0x12FE6AC")]
		public PlaceTile(ushort type, int style = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B75")]
		[Cpp2IlInjected.Address(RVA = "0x12FE6E0", Offset = "0x12FE6E0", VA = "0x12FE6E0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000893")]
	public class RemoveWall : GenAction
	{
		[Cpp2IlInjected.Token(Token = "0x6004B76")]
		[Cpp2IlInjected.Address(RVA = "0x12FE9B4", Offset = "0x12FE9B4", VA = "0x12FE9B4", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B77")]
		[Cpp2IlInjected.Address(RVA = "0x12FEA94", Offset = "0x12FEA94", VA = "0x12FEA94")]
		public RemoveWall()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000894")]
	public class PlaceWall : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008062")]
		private ushort _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008063")]
		private bool _neighbors;

		[Cpp2IlInjected.Token(Token = "0x6004B78")]
		[Cpp2IlInjected.Address(RVA = "0x12FE7B4", Offset = "0x12FE7B4", VA = "0x12FE7B4")]
		public PlaceWall(ushort type, bool neighbors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B79")]
		[Cpp2IlInjected.Address(RVA = "0x12FE7E8", Offset = "0x12FE7E8", VA = "0x12FE7E8", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000895")]
	public class SetLiquid : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008064")]
		private int _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008065")]
		private byte _value;

		[Cpp2IlInjected.Token(Token = "0x6004B7A")]
		[Cpp2IlInjected.Address(RVA = "0x12FEC9C", Offset = "0x12FEC9C", VA = "0x12FEC9C")]
		public SetLiquid(int type = 0, byte value = byte.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B7B")]
		[Cpp2IlInjected.Address(RVA = "0x12FECD0", Offset = "0x12FECD0", VA = "0x12FECD0", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000896")]
	public class SwapSolidTile : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4008066")]
		private ushort _type;

		[Cpp2IlInjected.Token(Token = "0x6004B7C")]
		[Cpp2IlInjected.Address(RVA = "0x12FF530", Offset = "0x12FF530", VA = "0x12FF530")]
		public SwapSolidTile(ushort type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B7D")]
		[Cpp2IlInjected.Address(RVA = "0x12FF55C", Offset = "0x12FF55C", VA = "0x12FF55C", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000897")]
	public class SetFrames : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008067")]
		private bool _frameNeighbors;

		[Cpp2IlInjected.Token(Token = "0x6004B7E")]
		[Cpp2IlInjected.Address(RVA = "0x12FEB08", Offset = "0x12FEB08", VA = "0x12FEB08")]
		public SetFrames(bool frameNeighbors = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B7F")]
		[Cpp2IlInjected.Address(RVA = "0x12FEB34", Offset = "0x12FEB34", VA = "0x12FEB34", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000898")]
	public class Smooth : GenAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008068")]
		private bool _applyToNeighbors;

		[Cpp2IlInjected.Token(Token = "0x6004B80")]
		[Cpp2IlInjected.Address(RVA = "0x12FF438", Offset = "0x12FF438", VA = "0x12FF438")]
		public Smooth(bool applyToNeighbors = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B81")]
		[Cpp2IlInjected.Address(RVA = "0x12FF464", Offset = "0x12FF464", VA = "0x12FF464", Slot = "4")]
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C5F")]
	[Cpp2IlInjected.Address(RVA = "0x12FDB04", Offset = "0x12FDB04", VA = "0x12FDB04")]
	public static GenAction Chain(params GenAction[] actions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C60")]
	[Cpp2IlInjected.Address(RVA = "0x12FDB44", Offset = "0x12FDB44", VA = "0x12FDB44")]
	public static GenAction Continue(GenAction action)
	{
		return null;
	}
}
