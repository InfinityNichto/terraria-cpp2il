using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002D4")]
public class SamplerState : GraphicsResource
{
	[Cpp2IlInjected.Token(Token = "0x40020C4")]
	public static readonly SamplerState AnisotropicClamp;

	[Cpp2IlInjected.Token(Token = "0x40020C5")]
	public static readonly SamplerState AnisotropicWrap;

	[Cpp2IlInjected.Token(Token = "0x40020C6")]
	public static readonly SamplerState LinearClamp;

	[Cpp2IlInjected.Token(Token = "0x40020C7")]
	public static readonly SamplerState LinearWrap;

	[Cpp2IlInjected.Token(Token = "0x40020C8")]
	public static readonly SamplerState PointClamp;

	[Cpp2IlInjected.Token(Token = "0x40020C9")]
	public static readonly SamplerState PointWrap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40020CA")]
	private readonly bool _defaultStateObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40020CB")]
	private TextureAddressMode _addressU;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40020CC")]
	private TextureAddressMode _addressV;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40020CD")]
	private TextureAddressMode _addressW;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40020CE")]
	private Color _borderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40020CF")]
	private TextureFilter _filter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40020D0")]
	private int _maxAnisotropy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40020D1")]
	private int _maxMipLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40020D2")]
	private float _mipMapLevelOfDetailBias;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40020D3")]
	private TextureFilterMode _filterMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40020D4")]
	private CompareFunction _comparisonFunction;

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public TextureAddressMode AddressU
	{
		[Cpp2IlInjected.Token(Token = "0x6001799")]
		[Cpp2IlInjected.Address(RVA = "0x1593560", Offset = "0x1593560", VA = "0x1593560")]
		get
		{
			return default(TextureAddressMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600179A")]
		[Cpp2IlInjected.Address(RVA = "0x1593568", Offset = "0x1593568", VA = "0x1593568")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public TextureAddressMode AddressV
	{
		[Cpp2IlInjected.Token(Token = "0x600179B")]
		[Cpp2IlInjected.Address(RVA = "0x1593654", Offset = "0x1593654", VA = "0x1593654")]
		get
		{
			return default(TextureAddressMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600179C")]
		[Cpp2IlInjected.Address(RVA = "0x159365C", Offset = "0x159365C", VA = "0x159365C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public TextureAddressMode AddressW
	{
		[Cpp2IlInjected.Token(Token = "0x600179D")]
		[Cpp2IlInjected.Address(RVA = "0x1593678", Offset = "0x1593678", VA = "0x1593678")]
		get
		{
			return default(TextureAddressMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600179E")]
		[Cpp2IlInjected.Address(RVA = "0x1593680", Offset = "0x1593680", VA = "0x1593680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public Color BorderColor
	{
		[Cpp2IlInjected.Token(Token = "0x600179F")]
		[Cpp2IlInjected.Address(RVA = "0x159369C", Offset = "0x159369C", VA = "0x159369C")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60017A0")]
		[Cpp2IlInjected.Address(RVA = "0x15936A4", Offset = "0x15936A4", VA = "0x15936A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public TextureFilter Filter
	{
		[Cpp2IlInjected.Token(Token = "0x60017A1")]
		[Cpp2IlInjected.Address(RVA = "0x15936C0", Offset = "0x15936C0", VA = "0x15936C0")]
		get
		{
			return default(TextureFilter);
		}
		[Cpp2IlInjected.Token(Token = "0x60017A2")]
		[Cpp2IlInjected.Address(RVA = "0x15936C8", Offset = "0x15936C8", VA = "0x15936C8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public int MaxAnisotropy
	{
		[Cpp2IlInjected.Token(Token = "0x60017A3")]
		[Cpp2IlInjected.Address(RVA = "0x15936E4", Offset = "0x15936E4", VA = "0x15936E4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017A4")]
		[Cpp2IlInjected.Address(RVA = "0x15936EC", Offset = "0x15936EC", VA = "0x15936EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public int MaxMipLevel
	{
		[Cpp2IlInjected.Token(Token = "0x60017A5")]
		[Cpp2IlInjected.Address(RVA = "0x1593708", Offset = "0x1593708", VA = "0x1593708")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60017A6")]
		[Cpp2IlInjected.Address(RVA = "0x1593710", Offset = "0x1593710", VA = "0x1593710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public float MipMapLevelOfDetailBias
	{
		[Cpp2IlInjected.Token(Token = "0x60017A7")]
		[Cpp2IlInjected.Address(RVA = "0x159372C", Offset = "0x159372C", VA = "0x159372C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60017A8")]
		[Cpp2IlInjected.Address(RVA = "0x1593734", Offset = "0x1593734", VA = "0x1593734")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public CompareFunction ComparisonFunction
	{
		[Cpp2IlInjected.Token(Token = "0x60017A9")]
		[Cpp2IlInjected.Address(RVA = "0x1593750", Offset = "0x1593750", VA = "0x1593750")]
		get
		{
			return default(CompareFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x60017AA")]
		[Cpp2IlInjected.Address(RVA = "0x1593758", Offset = "0x1593758", VA = "0x1593758")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public TextureFilterMode FilterMode
	{
		[Cpp2IlInjected.Token(Token = "0x60017AB")]
		[Cpp2IlInjected.Address(RVA = "0x1593774", Offset = "0x1593774", VA = "0x1593774")]
		get
		{
			return default(TextureFilterMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60017AC")]
		[Cpp2IlInjected.Address(RVA = "0x159377C", Offset = "0x159377C", VA = "0x159377C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001798")]
	[Cpp2IlInjected.Address(RVA = "0x159332C", Offset = "0x159332C", VA = "0x159332C")]
	static SamplerState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017AD")]
	[Cpp2IlInjected.Address(RVA = "0x1593798", Offset = "0x1593798", VA = "0x1593798")]
	internal void BindToGraphicsDevice(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017AE")]
	[Cpp2IlInjected.Address(RVA = "0x1593584", Offset = "0x1593584", VA = "0x1593584")]
	internal void ThrowIfBound()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017AF")]
	[Cpp2IlInjected.Address(RVA = "0x1593884", Offset = "0x1593884", VA = "0x1593884")]
	public SamplerState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017B0")]
	[Cpp2IlInjected.Address(RVA = "0x1593524", Offset = "0x1593524", VA = "0x1593524")]
	private SamplerState(string name, TextureFilter filter, TextureAddressMode addressMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017B1")]
	[Cpp2IlInjected.Address(RVA = "0x1593990", Offset = "0x1593990", VA = "0x1593990")]
	private SamplerState(SamplerState cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60017B2")]
	[Cpp2IlInjected.Address(RVA = "0x1593A04", Offset = "0x1593A04", VA = "0x1593A04")]
	internal SamplerState Clone()
	{
		return null;
	}
}
