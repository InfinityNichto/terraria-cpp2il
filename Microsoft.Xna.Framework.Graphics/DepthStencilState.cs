using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002D1")]
public class DepthStencilState : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40020A2")]
	private readonly bool _defaultStateObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40020A3")]
	private bool _depthBufferEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x40020A4")]
	private bool _depthBufferWriteEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40020A5")]
	private StencilOperation _counterClockwiseStencilDepthBufferFail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40020A6")]
	private StencilOperation _counterClockwiseStencilFail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40020A7")]
	private CompareFunction _counterClockwiseStencilFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40020A8")]
	private StencilOperation _counterClockwiseStencilPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40020A9")]
	private CompareFunction _depthBufferFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40020AA")]
	private int _referenceStencil;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40020AB")]
	private StencilOperation _stencilDepthBufferFail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40020AC")]
	private bool _stencilEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40020AD")]
	private StencilOperation _stencilFail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40020AE")]
	private CompareFunction _stencilFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40020AF")]
	private int _stencilMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40020B0")]
	private StencilOperation _stencilPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40020B1")]
	private int _stencilWriteMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40020B2")]
	private bool _twoSidedStencilMode;

	[Cpp2IlInjected.Token(Token = "0x40020B3")]
	public static readonly DepthStencilState Default;

	[Cpp2IlInjected.Token(Token = "0x40020B4")]
	public static readonly DepthStencilState DepthRead;

	[Cpp2IlInjected.Token(Token = "0x40020B5")]
	public static readonly DepthStencilState None;

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public bool DepthBufferEnable
	{
		[Cpp2IlInjected.Token(Token = "0x600175C")]
		[Cpp2IlInjected.Address(RVA = "0x1399B10", Offset = "0x1399B10", VA = "0x1399B10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600175D")]
		[Cpp2IlInjected.Address(RVA = "0x1399B18", Offset = "0x1399B18", VA = "0x1399B18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public bool DepthBufferWriteEnable
	{
		[Cpp2IlInjected.Token(Token = "0x600175E")]
		[Cpp2IlInjected.Address(RVA = "0x1399C04", Offset = "0x1399C04", VA = "0x1399C04")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600175F")]
		[Cpp2IlInjected.Address(RVA = "0x1399C0C", Offset = "0x1399C0C", VA = "0x1399C0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public StencilOperation CounterClockwiseStencilDepthBufferFail
	{
		[Cpp2IlInjected.Token(Token = "0x6001760")]
		[Cpp2IlInjected.Address(RVA = "0x1399C28", Offset = "0x1399C28", VA = "0x1399C28")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001761")]
		[Cpp2IlInjected.Address(RVA = "0x1399C30", Offset = "0x1399C30", VA = "0x1399C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public StencilOperation CounterClockwiseStencilFail
	{
		[Cpp2IlInjected.Token(Token = "0x6001762")]
		[Cpp2IlInjected.Address(RVA = "0x1399C4C", Offset = "0x1399C4C", VA = "0x1399C4C")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001763")]
		[Cpp2IlInjected.Address(RVA = "0x1399C54", Offset = "0x1399C54", VA = "0x1399C54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public CompareFunction CounterClockwiseStencilFunction
	{
		[Cpp2IlInjected.Token(Token = "0x6001764")]
		[Cpp2IlInjected.Address(RVA = "0x1399C70", Offset = "0x1399C70", VA = "0x1399C70")]
		get
		{
			return default(CompareFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x6001765")]
		[Cpp2IlInjected.Address(RVA = "0x1399C78", Offset = "0x1399C78", VA = "0x1399C78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public StencilOperation CounterClockwiseStencilPass
	{
		[Cpp2IlInjected.Token(Token = "0x6001766")]
		[Cpp2IlInjected.Address(RVA = "0x1399C94", Offset = "0x1399C94", VA = "0x1399C94")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001767")]
		[Cpp2IlInjected.Address(RVA = "0x1399C9C", Offset = "0x1399C9C", VA = "0x1399C9C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public CompareFunction DepthBufferFunction
	{
		[Cpp2IlInjected.Token(Token = "0x6001768")]
		[Cpp2IlInjected.Address(RVA = "0x1399CB8", Offset = "0x1399CB8", VA = "0x1399CB8")]
		get
		{
			return default(CompareFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x6001769")]
		[Cpp2IlInjected.Address(RVA = "0x1399CC0", Offset = "0x1399CC0", VA = "0x1399CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public int ReferenceStencil
	{
		[Cpp2IlInjected.Token(Token = "0x600176A")]
		[Cpp2IlInjected.Address(RVA = "0x1399CDC", Offset = "0x1399CDC", VA = "0x1399CDC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600176B")]
		[Cpp2IlInjected.Address(RVA = "0x1399CE4", Offset = "0x1399CE4", VA = "0x1399CE4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public StencilOperation StencilDepthBufferFail
	{
		[Cpp2IlInjected.Token(Token = "0x600176C")]
		[Cpp2IlInjected.Address(RVA = "0x1399D00", Offset = "0x1399D00", VA = "0x1399D00")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x600176D")]
		[Cpp2IlInjected.Address(RVA = "0x1399D08", Offset = "0x1399D08", VA = "0x1399D08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public bool StencilEnable
	{
		[Cpp2IlInjected.Token(Token = "0x600176E")]
		[Cpp2IlInjected.Address(RVA = "0x1399D24", Offset = "0x1399D24", VA = "0x1399D24")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600176F")]
		[Cpp2IlInjected.Address(RVA = "0x1399D2C", Offset = "0x1399D2C", VA = "0x1399D2C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public StencilOperation StencilFail
	{
		[Cpp2IlInjected.Token(Token = "0x6001770")]
		[Cpp2IlInjected.Address(RVA = "0x1399D48", Offset = "0x1399D48", VA = "0x1399D48")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001771")]
		[Cpp2IlInjected.Address(RVA = "0x1399D50", Offset = "0x1399D50", VA = "0x1399D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public CompareFunction StencilFunction
	{
		[Cpp2IlInjected.Token(Token = "0x6001772")]
		[Cpp2IlInjected.Address(RVA = "0x1399D6C", Offset = "0x1399D6C", VA = "0x1399D6C")]
		get
		{
			return default(CompareFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x6001773")]
		[Cpp2IlInjected.Address(RVA = "0x1399D74", Offset = "0x1399D74", VA = "0x1399D74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public int StencilMask
	{
		[Cpp2IlInjected.Token(Token = "0x6001774")]
		[Cpp2IlInjected.Address(RVA = "0x1399D90", Offset = "0x1399D90", VA = "0x1399D90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001775")]
		[Cpp2IlInjected.Address(RVA = "0x1399D98", Offset = "0x1399D98", VA = "0x1399D98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public StencilOperation StencilPass
	{
		[Cpp2IlInjected.Token(Token = "0x6001776")]
		[Cpp2IlInjected.Address(RVA = "0x1399DB4", Offset = "0x1399DB4", VA = "0x1399DB4")]
		get
		{
			return default(StencilOperation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001777")]
		[Cpp2IlInjected.Address(RVA = "0x1399DBC", Offset = "0x1399DBC", VA = "0x1399DBC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public int StencilWriteMask
	{
		[Cpp2IlInjected.Token(Token = "0x6001778")]
		[Cpp2IlInjected.Address(RVA = "0x1399DD8", Offset = "0x1399DD8", VA = "0x1399DD8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001779")]
		[Cpp2IlInjected.Address(RVA = "0x1399DE0", Offset = "0x1399DE0", VA = "0x1399DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public bool TwoSidedStencilMode
	{
		[Cpp2IlInjected.Token(Token = "0x600177A")]
		[Cpp2IlInjected.Address(RVA = "0x1399DFC", Offset = "0x1399DFC", VA = "0x1399DFC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600177B")]
		[Cpp2IlInjected.Address(RVA = "0x1399E04", Offset = "0x1399E04", VA = "0x1399E04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600177C")]
	[Cpp2IlInjected.Address(RVA = "0x1399E20", Offset = "0x1399E20", VA = "0x1399E20")]
	internal void BindToGraphicsDevice(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600177D")]
	[Cpp2IlInjected.Address(RVA = "0x1399B34", Offset = "0x1399B34", VA = "0x1399B34")]
	internal void ThrowIfBound()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600177E")]
	[Cpp2IlInjected.Address(RVA = "0x1399F04", Offset = "0x1399F04", VA = "0x1399F04")]
	public DepthStencilState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600177F")]
	[Cpp2IlInjected.Address(RVA = "0x1399FEC", Offset = "0x1399FEC", VA = "0x1399FEC")]
	private DepthStencilState(string name, bool depthBufferEnable, bool depthBufferWriteEnable)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001780")]
	[Cpp2IlInjected.Address(RVA = "0x139A020", Offset = "0x139A020", VA = "0x139A020")]
	private DepthStencilState(DepthStencilState cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001781")]
	[Cpp2IlInjected.Address(RVA = "0x139A0C4", Offset = "0x139A0C4", VA = "0x139A0C4")]
	static DepthStencilState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001782")]
	[Cpp2IlInjected.Address(RVA = "0x139A1CC", Offset = "0x139A1CC", VA = "0x139A1CC")]
	internal DepthStencilState Clone()
	{
		return null;
	}
}
