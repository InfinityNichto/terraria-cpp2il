using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200032B")]
public abstract class Entity
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002CC4")]
	public int whoAmI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002CC5")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002CC6")]
	internal long entityId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002CC7")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002CC8")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002CC9")]
	public Vector2 oldPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002CCA")]
	public Vector2 oldVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002CCB")]
	public int oldDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002CCC")]
	public int direction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002CCD")]
	public int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002CCE")]
	public int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4002CCF")]
	public bool wet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4002CD0")]
	public bool shimmerWet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x4002CD1")]
	public bool honeyWet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
	[Cpp2IlInjected.Token(Token = "0x4002CD2")]
	public byte wetCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4002CD3")]
	public bool lavaWet;

	[Cpp2IlInjected.Token(Token = "0x1700052B")]
	public virtual Vector2 VisualPosition
	{
		[Cpp2IlInjected.Token(Token = "0x600260C")]
		[Cpp2IlInjected.Address(RVA = "0x132D578", Offset = "0x132D578", VA = "0x132D578", Slot = "4")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700052C")]
	public Vector2 Center
	{
		[Cpp2IlInjected.Token(Token = "0x6002614")]
		[Cpp2IlInjected.Address(RVA = "0x132AFAC", Offset = "0x132AFAC", VA = "0x132AFAC")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002615")]
		[Cpp2IlInjected.Address(RVA = "0x132DD44", Offset = "0x132DD44", VA = "0x132DD44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700052D")]
	public Vector2 Left
	{
		[Cpp2IlInjected.Token(Token = "0x6002616")]
		[Cpp2IlInjected.Address(RVA = "0x132DDBC", Offset = "0x132DDBC", VA = "0x132DDBC")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002617")]
		[Cpp2IlInjected.Address(RVA = "0x132DE00", Offset = "0x132DE00", VA = "0x132DE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700052E")]
	public Vector2 Right
	{
		[Cpp2IlInjected.Token(Token = "0x6002618")]
		[Cpp2IlInjected.Address(RVA = "0x132DE58", Offset = "0x132DE58", VA = "0x132DE58")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002619")]
		[Cpp2IlInjected.Address(RVA = "0x132DEAC", Offset = "0x132DEAC", VA = "0x132DEAC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700052F")]
	public Vector2 Top
	{
		[Cpp2IlInjected.Token(Token = "0x600261A")]
		[Cpp2IlInjected.Address(RVA = "0x132DF18", Offset = "0x132DF18", VA = "0x132DF18")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600261B")]
		[Cpp2IlInjected.Address(RVA = "0x132DF60", Offset = "0x132DF60", VA = "0x132DF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000530")]
	public Vector2 TopLeft
	{
		[Cpp2IlInjected.Token(Token = "0x600261C")]
		[Cpp2IlInjected.Address(RVA = "0x132DFB8", Offset = "0x132DFB8", VA = "0x132DFB8")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600261D")]
		[Cpp2IlInjected.Address(RVA = "0x132DFC4", Offset = "0x132DFC4", VA = "0x132DFC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000531")]
	public Vector2 TopRight
	{
		[Cpp2IlInjected.Token(Token = "0x600261E")]
		[Cpp2IlInjected.Address(RVA = "0x132DFD4", Offset = "0x132DFD4", VA = "0x132DFD4")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600261F")]
		[Cpp2IlInjected.Address(RVA = "0x132E010", Offset = "0x132E010", VA = "0x132E010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000532")]
	public Vector2 Bottom
	{
		[Cpp2IlInjected.Token(Token = "0x6002620")]
		[Cpp2IlInjected.Address(RVA = "0x132E05C", Offset = "0x132E05C", VA = "0x132E05C")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002621")]
		[Cpp2IlInjected.Address(RVA = "0x132E0B0", Offset = "0x132E0B0", VA = "0x132E0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000533")]
	public Vector2 BottomLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6002622")]
		[Cpp2IlInjected.Address(RVA = "0x132E11C", Offset = "0x132E11C", VA = "0x132E11C")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002623")]
		[Cpp2IlInjected.Address(RVA = "0x132E154", Offset = "0x132E154", VA = "0x132E154")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000534")]
	public Vector2 BottomRight
	{
		[Cpp2IlInjected.Token(Token = "0x6002624")]
		[Cpp2IlInjected.Address(RVA = "0x132E1A0", Offset = "0x132E1A0", VA = "0x132E1A0")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002625")]
		[Cpp2IlInjected.Address(RVA = "0x132E1E8", Offset = "0x132E1E8", VA = "0x132E1E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000535")]
	public Vector2 Size
	{
		[Cpp2IlInjected.Token(Token = "0x6002626")]
		[Cpp2IlInjected.Address(RVA = "0x132E248", Offset = "0x132E248", VA = "0x132E248")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002627")]
		[Cpp2IlInjected.Address(RVA = "0x132E280", Offset = "0x132E280", VA = "0x132E280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000536")]
	public Rectangle Hitbox
	{
		[Cpp2IlInjected.Token(Token = "0x6002628")]
		[Cpp2IlInjected.Address(RVA = "0x132E29C", Offset = "0x132E29C", VA = "0x132E29C")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6002629")]
		[Cpp2IlInjected.Address(RVA = "0x132E2E8", Offset = "0x132E2E8", VA = "0x132E2E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600260D")]
	[Cpp2IlInjected.Address(RVA = "0x132D584", Offset = "0x132D584", VA = "0x132D584")]
	public float AngleTo(Vector2 Destination)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600260E")]
	[Cpp2IlInjected.Address(RVA = "0x132D6E8", Offset = "0x132D6E8", VA = "0x132D6E8")]
	public float AngleFrom(Vector2 Source)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600260F")]
	[Cpp2IlInjected.Address(RVA = "0x132D84C", Offset = "0x132D84C", VA = "0x132D84C")]
	public float Distance(Vector2 Other)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002610")]
	[Cpp2IlInjected.Address(RVA = "0x132D938", Offset = "0x132D938", VA = "0x132D938")]
	public float DistanceSQ(Vector2 Other)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002611")]
	[Cpp2IlInjected.Address(RVA = "0x132DA24", Offset = "0x132DA24", VA = "0x132DA24")]
	public Vector2 DirectionTo(Vector2 Destination)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002612")]
	[Cpp2IlInjected.Address(RVA = "0x132DB2C", Offset = "0x132DB2C", VA = "0x132DB2C")]
	public Vector2 DirectionFrom(Vector2 Source)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002613")]
	[Cpp2IlInjected.Address(RVA = "0x132DC30", Offset = "0x132DC30", VA = "0x132DC30")]
	public bool WithinRange(Vector2 Target, float MaxRange)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600262A")]
	[Cpp2IlInjected.Address(RVA = "0x132E344", Offset = "0x132E344", VA = "0x132E344")]
	protected Entity()
	{
	}
}
