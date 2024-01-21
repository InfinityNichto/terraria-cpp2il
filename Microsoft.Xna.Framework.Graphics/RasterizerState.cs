using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002D3")]
public class RasterizerState : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40020B9")]
	private readonly bool _defaultStateObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40020BA")]
	private CullMode _cullMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40020BB")]
	private float _depthBias;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40020BC")]
	private FillMode _fillMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40020BD")]
	private bool _multiSampleAntiAlias;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40020BE")]
	private bool _scissorTestEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40020BF")]
	private float _slopeScaleDepthBias;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40020C0")]
	private bool _depthClipEnable;

	[Cpp2IlInjected.Token(Token = "0x40020C1")]
	public static readonly RasterizerState CullClockwise;

	[Cpp2IlInjected.Token(Token = "0x40020C2")]
	public static readonly RasterizerState CullCounterClockwise;

	[Cpp2IlInjected.Token(Token = "0x40020C3")]
	public static readonly RasterizerState CullNone;

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public CullMode CullMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001783")]
		[Cpp2IlInjected.Address(RVA = "0x15927B0", Offset = "0x15927B0", VA = "0x15927B0")]
		get
		{
			return default(CullMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6001784")]
		[Cpp2IlInjected.Address(RVA = "0x15927B8", Offset = "0x15927B8", VA = "0x15927B8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public float DepthBias
	{
		[Cpp2IlInjected.Token(Token = "0x6001785")]
		[Cpp2IlInjected.Address(RVA = "0x15928A4", Offset = "0x15928A4", VA = "0x15928A4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001786")]
		[Cpp2IlInjected.Address(RVA = "0x15928AC", Offset = "0x15928AC", VA = "0x15928AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public FillMode FillMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001787")]
		[Cpp2IlInjected.Address(RVA = "0x15928C8", Offset = "0x15928C8", VA = "0x15928C8")]
		get
		{
			return default(FillMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6001788")]
		[Cpp2IlInjected.Address(RVA = "0x15928D0", Offset = "0x15928D0", VA = "0x15928D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public bool MultiSampleAntiAlias
	{
		[Cpp2IlInjected.Token(Token = "0x6001789")]
		[Cpp2IlInjected.Address(RVA = "0x15928EC", Offset = "0x15928EC", VA = "0x15928EC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600178A")]
		[Cpp2IlInjected.Address(RVA = "0x15928F4", Offset = "0x15928F4", VA = "0x15928F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public bool ScissorTestEnable
	{
		[Cpp2IlInjected.Token(Token = "0x600178B")]
		[Cpp2IlInjected.Address(RVA = "0x1592910", Offset = "0x1592910", VA = "0x1592910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600178C")]
		[Cpp2IlInjected.Address(RVA = "0x1592918", Offset = "0x1592918", VA = "0x1592918")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public float SlopeScaleDepthBias
	{
		[Cpp2IlInjected.Token(Token = "0x600178D")]
		[Cpp2IlInjected.Address(RVA = "0x1592934", Offset = "0x1592934", VA = "0x1592934")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600178E")]
		[Cpp2IlInjected.Address(RVA = "0x159293C", Offset = "0x159293C", VA = "0x159293C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public bool DepthClipEnable
	{
		[Cpp2IlInjected.Token(Token = "0x600178F")]
		[Cpp2IlInjected.Address(RVA = "0x1592958", Offset = "0x1592958", VA = "0x1592958")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001790")]
		[Cpp2IlInjected.Address(RVA = "0x1592960", Offset = "0x1592960", VA = "0x1592960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001791")]
	[Cpp2IlInjected.Address(RVA = "0x159297C", Offset = "0x159297C", VA = "0x159297C")]
	internal void BindToGraphicsDevice(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001792")]
	[Cpp2IlInjected.Address(RVA = "0x15927D4", Offset = "0x15927D4", VA = "0x15927D4")]
	internal void ThrowIfBound()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001793")]
	[Cpp2IlInjected.Address(RVA = "0x1592A68", Offset = "0x1592A68", VA = "0x1592A68")]
	public RasterizerState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001794")]
	[Cpp2IlInjected.Address(RVA = "0x1592AE0", Offset = "0x1592AE0", VA = "0x1592AE0")]
	private RasterizerState(string name, CullMode cullMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001795")]
	[Cpp2IlInjected.Address(RVA = "0x1592B0C", Offset = "0x1592B0C", VA = "0x1592B0C")]
	private RasterizerState(RasterizerState cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001796")]
	[Cpp2IlInjected.Address(RVA = "0x1592B68", Offset = "0x1592B68", VA = "0x1592B68")]
	static RasterizerState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001797")]
	[Cpp2IlInjected.Address(RVA = "0x1592C70", Offset = "0x1592C70", VA = "0x1592C70")]
	internal RasterizerState Clone()
	{
		return null;
	}
}
