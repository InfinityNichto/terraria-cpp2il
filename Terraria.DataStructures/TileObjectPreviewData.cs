using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200047F")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x385128", Offset = "0x385128")]
public class TileObjectPreviewData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006486")]
	private ushort _type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4006487")]
	private short _style;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006488")]
	private int _alternate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006489")]
	private int _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400648A")]
	private bool _active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x400648B")]
	private Point16 _size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400648C")]
	private Point16 _coordinates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400648D")]
	private Point16 _objectStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400648E")]
	private int[,] _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400648F")]
	private Point16 _dataSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006490")]
	private float _percentValid;

	[Cpp2IlInjected.Token(Token = "0x4006491")]
	public static TileObjectPreviewData placementCache;

	[Cpp2IlInjected.Token(Token = "0x4006492")]
	public static TileObjectPreviewData randomCache;

	[Cpp2IlInjected.Token(Token = "0x4006493")]
	public const int None = 0;

	[Cpp2IlInjected.Token(Token = "0x4006494")]
	public const int ValidSpot = 1;

	[Cpp2IlInjected.Token(Token = "0x4006495")]
	public const int InvalidSpot = 2;

	[Cpp2IlInjected.Token(Token = "0x1700062D")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x600328C")]
		[Cpp2IlInjected.Address(RVA = "0x12313D8", Offset = "0x12313D8", VA = "0x12313D8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600328D")]
		[Cpp2IlInjected.Address(RVA = "0x12313E0", Offset = "0x12313E0", VA = "0x12313E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700062E")]
	public ushort Type
	{
		[Cpp2IlInjected.Token(Token = "0x600328E")]
		[Cpp2IlInjected.Address(RVA = "0x12313E8", Offset = "0x12313E8", VA = "0x12313E8")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x600328F")]
		[Cpp2IlInjected.Address(RVA = "0x12313F0", Offset = "0x12313F0", VA = "0x12313F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700062F")]
	public short Style
	{
		[Cpp2IlInjected.Token(Token = "0x6003290")]
		[Cpp2IlInjected.Address(RVA = "0x12313F8", Offset = "0x12313F8", VA = "0x12313F8")]
		get
		{
			return default(short);
		}
		[Cpp2IlInjected.Token(Token = "0x6003291")]
		[Cpp2IlInjected.Address(RVA = "0x1231400", Offset = "0x1231400", VA = "0x1231400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000630")]
	public int Alternate
	{
		[Cpp2IlInjected.Token(Token = "0x6003292")]
		[Cpp2IlInjected.Address(RVA = "0x1231408", Offset = "0x1231408", VA = "0x1231408")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003293")]
		[Cpp2IlInjected.Address(RVA = "0x1231410", Offset = "0x1231410", VA = "0x1231410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000631")]
	public int Random
	{
		[Cpp2IlInjected.Token(Token = "0x6003294")]
		[Cpp2IlInjected.Address(RVA = "0x1231418", Offset = "0x1231418", VA = "0x1231418")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003295")]
		[Cpp2IlInjected.Address(RVA = "0x1231420", Offset = "0x1231420", VA = "0x1231420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000632")]
	public Point16 Size
	{
		[Cpp2IlInjected.Token(Token = "0x6003296")]
		[Cpp2IlInjected.Address(RVA = "0x1231428", Offset = "0x1231428", VA = "0x1231428")]
		get
		{
			return default(Point16);
		}
		[Cpp2IlInjected.Token(Token = "0x6003297")]
		[Cpp2IlInjected.Address(RVA = "0x1231430", Offset = "0x1231430", VA = "0x1231430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000633")]
	public Point16 Coordinates
	{
		[Cpp2IlInjected.Token(Token = "0x6003298")]
		[Cpp2IlInjected.Address(RVA = "0x12315CC", Offset = "0x12315CC", VA = "0x12315CC")]
		get
		{
			return default(Point16);
		}
		[Cpp2IlInjected.Token(Token = "0x6003299")]
		[Cpp2IlInjected.Address(RVA = "0x12315D4", Offset = "0x12315D4", VA = "0x12315D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000634")]
	public Point16 ObjectStart
	{
		[Cpp2IlInjected.Token(Token = "0x600329A")]
		[Cpp2IlInjected.Address(RVA = "0x12315DC", Offset = "0x12315DC", VA = "0x12315DC")]
		get
		{
			return default(Point16);
		}
		[Cpp2IlInjected.Token(Token = "0x600329B")]
		[Cpp2IlInjected.Address(RVA = "0x12315E4", Offset = "0x12315E4", VA = "0x12315E4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000635")]
	public int Item
	{
		[Cpp2IlInjected.Token(Token = "0x600329D")]
		[Cpp2IlInjected.Address(RVA = "0x1231664", Offset = "0x1231664", VA = "0x1231664")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600329E")]
		[Cpp2IlInjected.Address(RVA = "0x1231724", Offset = "0x1231724", VA = "0x1231724")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600328A")]
	[Cpp2IlInjected.Address(RVA = "0x1231104", Offset = "0x1231104", VA = "0x1231104")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600328B")]
	[Cpp2IlInjected.Address(RVA = "0x12311E0", Offset = "0x12311E0", VA = "0x12311E0")]
	public void CopyFrom(TileObjectPreviewData copy)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600329C")]
	[Cpp2IlInjected.Address(RVA = "0x12315EC", Offset = "0x12315EC", VA = "0x12315EC")]
	public void AllInvalid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600329F")]
	[Cpp2IlInjected.Address(RVA = "0x12317E8", Offset = "0x12317E8", VA = "0x12317E8")]
	public TileObjectPreviewData()
	{
	}
}
