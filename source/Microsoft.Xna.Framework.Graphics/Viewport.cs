using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002DD")]
[DataContract]
public struct Viewport
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002138")]
	private int x;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4002139")]
	private int y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400213A")]
	private int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400213B")]
	private int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400213C")]
	private float minDepth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400213D")]
	private float maxDepth;

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	[DataMember]
	public int Height
	{
		[Cpp2IlInjected.Token(Token = "0x60017EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A6C", Offset = "0x3A0A6C", VA = "0x3A0A6C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A74", Offset = "0x3A0A74", VA = "0x3A0A74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	[DataMember]
	public float MaxDepth
	{
		[Cpp2IlInjected.Token(Token = "0x60017EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A7C", Offset = "0x3A0A7C", VA = "0x3A0A7C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60017ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A84", Offset = "0x3A0A84", VA = "0x3A0A84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	[DataMember]
	public float MinDepth
	{
		[Cpp2IlInjected.Token(Token = "0x60017EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A8C", Offset = "0x3A0A8C", VA = "0x3A0A8C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60017EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A94", Offset = "0x3A0A94", VA = "0x3A0A94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	[DataMember]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x60017F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A9C", Offset = "0x3A0A9C", VA = "0x3A0A9C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017F1")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AA4", Offset = "0x3A0AA4", VA = "0x3A0AA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	[DataMember]
	public int Y
	{
		[Cpp2IlInjected.Token(Token = "0x60017F2")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AAC", Offset = "0x3A0AAC", VA = "0x3A0AAC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AB4", Offset = "0x3A0AB4", VA = "0x3A0AB4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	[DataMember]
	public int X
	{
		[Cpp2IlInjected.Token(Token = "0x60017F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A0ABC", Offset = "0x3A0ABC", VA = "0x3A0ABC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AC4", Offset = "0x3A0AC4", VA = "0x3A0AC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public float AspectRatio
	{
		[Cpp2IlInjected.Token(Token = "0x60017F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A0ACC", Offset = "0x3A0ACC", VA = "0x3A0ACC")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public Rectangle Bounds
	{
		[Cpp2IlInjected.Token(Token = "0x60017F7")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B04", Offset = "0x3A0B04", VA = "0x3A0B04")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x60017F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B40", Offset = "0x3A0B40", VA = "0x3A0B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public Rectangle TitleSafeArea
	{
		[Cpp2IlInjected.Token(Token = "0x60017F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B50", Offset = "0x3A0B50", VA = "0x3A0B50")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60017FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B64", Offset = "0x3A0B64", VA = "0x3A0B64")]
	public Viewport(int x, int y, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B88", Offset = "0x3A0B88", VA = "0x3A0B88")]
	public Viewport(int x, int y, int width, int height, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BB0", Offset = "0x3A0BB0", VA = "0x3A0BB0")]
	public Viewport(Rectangle bounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BD4", Offset = "0x3A0BD4", VA = "0x3A0BD4")]
	public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60017FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A0D64", Offset = "0x3A0D64", VA = "0x3A0D64")]
	public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60017FF")]
	[Cpp2IlInjected.Address(RVA = "0x154F07C", Offset = "0x154F07C", VA = "0x154F07C")]
	private static bool WithinEpsilon(float a, float b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001800")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EF4", Offset = "0x3A0EF4", VA = "0x3A0EF4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
