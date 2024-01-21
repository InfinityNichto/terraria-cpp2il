using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002CD")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384E54", Offset = "0x384E54")]
public class BlendState : GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002087")]
	private readonly TargetBlendState[] _targetBlendState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002088")]
	private readonly bool _defaultStateObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4002089")]
	private Color _blendFactor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400208A")]
	private int _multiSampleMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400208B")]
	private bool _independentBlendEnable;

	[Cpp2IlInjected.Token(Token = "0x400208C")]
	public static readonly BlendState Additive;

	[Cpp2IlInjected.Token(Token = "0x400208D")]
	public static readonly BlendState AlphaBlend;

	[Cpp2IlInjected.Token(Token = "0x400208E")]
	public static readonly BlendState NonPremultiplied;

	[Cpp2IlInjected.Token(Token = "0x400208F")]
	public static readonly BlendState Opaque;

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public TargetBlendState Item
	{
		[Cpp2IlInjected.Token(Token = "0x600173C")]
		[Cpp2IlInjected.Address(RVA = "0x1394878", Offset = "0x1394878", VA = "0x1394878")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public BlendFunction AlphaBlendFunction
	{
		[Cpp2IlInjected.Token(Token = "0x600173D")]
		[Cpp2IlInjected.Address(RVA = "0x1394888", Offset = "0x1394888", VA = "0x1394888")]
		get
		{
			return default(BlendFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x600173E")]
		[Cpp2IlInjected.Address(RVA = "0x1394898", Offset = "0x1394898", VA = "0x1394898")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public Blend AlphaDestinationBlend
	{
		[Cpp2IlInjected.Token(Token = "0x600173F")]
		[Cpp2IlInjected.Address(RVA = "0x13948C4", Offset = "0x13948C4", VA = "0x13948C4")]
		get
		{
			return default(Blend);
		}
		[Cpp2IlInjected.Token(Token = "0x6001740")]
		[Cpp2IlInjected.Address(RVA = "0x13948D4", Offset = "0x13948D4", VA = "0x13948D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public Blend AlphaSourceBlend
	{
		[Cpp2IlInjected.Token(Token = "0x6001741")]
		[Cpp2IlInjected.Address(RVA = "0x1394900", Offset = "0x1394900", VA = "0x1394900")]
		get
		{
			return default(Blend);
		}
		[Cpp2IlInjected.Token(Token = "0x6001742")]
		[Cpp2IlInjected.Address(RVA = "0x1394910", Offset = "0x1394910", VA = "0x1394910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public BlendFunction ColorBlendFunction
	{
		[Cpp2IlInjected.Token(Token = "0x6001743")]
		[Cpp2IlInjected.Address(RVA = "0x139493C", Offset = "0x139493C", VA = "0x139493C")]
		get
		{
			return default(BlendFunction);
		}
		[Cpp2IlInjected.Token(Token = "0x6001744")]
		[Cpp2IlInjected.Address(RVA = "0x139494C", Offset = "0x139494C", VA = "0x139494C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public Blend ColorDestinationBlend
	{
		[Cpp2IlInjected.Token(Token = "0x6001745")]
		[Cpp2IlInjected.Address(RVA = "0x1394978", Offset = "0x1394978", VA = "0x1394978")]
		get
		{
			return default(Blend);
		}
		[Cpp2IlInjected.Token(Token = "0x6001746")]
		[Cpp2IlInjected.Address(RVA = "0x1394988", Offset = "0x1394988", VA = "0x1394988")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public Blend ColorSourceBlend
	{
		[Cpp2IlInjected.Token(Token = "0x6001747")]
		[Cpp2IlInjected.Address(RVA = "0x13949B4", Offset = "0x13949B4", VA = "0x13949B4")]
		get
		{
			return default(Blend);
		}
		[Cpp2IlInjected.Token(Token = "0x6001748")]
		[Cpp2IlInjected.Address(RVA = "0x13949C4", Offset = "0x13949C4", VA = "0x13949C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public ColorWriteChannels ColorWriteChannels
	{
		[Cpp2IlInjected.Token(Token = "0x6001749")]
		[Cpp2IlInjected.Address(RVA = "0x13949F0", Offset = "0x13949F0", VA = "0x13949F0")]
		get
		{
			return default(ColorWriteChannels);
		}
		[Cpp2IlInjected.Token(Token = "0x600174A")]
		[Cpp2IlInjected.Address(RVA = "0x1394A00", Offset = "0x1394A00", VA = "0x1394A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public ColorWriteChannels ColorWriteChannels1
	{
		[Cpp2IlInjected.Token(Token = "0x600174B")]
		[Cpp2IlInjected.Address(RVA = "0x1394A2C", Offset = "0x1394A2C", VA = "0x1394A2C")]
		get
		{
			return default(ColorWriteChannels);
		}
		[Cpp2IlInjected.Token(Token = "0x600174C")]
		[Cpp2IlInjected.Address(RVA = "0x1394A3C", Offset = "0x1394A3C", VA = "0x1394A3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public ColorWriteChannels ColorWriteChannels2
	{
		[Cpp2IlInjected.Token(Token = "0x600174D")]
		[Cpp2IlInjected.Address(RVA = "0x1394A68", Offset = "0x1394A68", VA = "0x1394A68")]
		get
		{
			return default(ColorWriteChannels);
		}
		[Cpp2IlInjected.Token(Token = "0x600174E")]
		[Cpp2IlInjected.Address(RVA = "0x1394A78", Offset = "0x1394A78", VA = "0x1394A78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public ColorWriteChannels ColorWriteChannels3
	{
		[Cpp2IlInjected.Token(Token = "0x600174F")]
		[Cpp2IlInjected.Address(RVA = "0x1394AA4", Offset = "0x1394AA4", VA = "0x1394AA4")]
		get
		{
			return default(ColorWriteChannels);
		}
		[Cpp2IlInjected.Token(Token = "0x6001750")]
		[Cpp2IlInjected.Address(RVA = "0x1394AB4", Offset = "0x1394AB4", VA = "0x1394AB4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public Color BlendFactor
	{
		[Cpp2IlInjected.Token(Token = "0x6001751")]
		[Cpp2IlInjected.Address(RVA = "0x1394AE0", Offset = "0x1394AE0", VA = "0x1394AE0")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001752")]
		[Cpp2IlInjected.Address(RVA = "0x1394AE8", Offset = "0x1394AE8", VA = "0x1394AE8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public int MultiSampleMask
	{
		[Cpp2IlInjected.Token(Token = "0x6001753")]
		[Cpp2IlInjected.Address(RVA = "0x1394B04", Offset = "0x1394B04", VA = "0x1394B04")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001754")]
		[Cpp2IlInjected.Address(RVA = "0x1394B0C", Offset = "0x1394B0C", VA = "0x1394B0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public bool IndependentBlendEnable
	{
		[Cpp2IlInjected.Token(Token = "0x6001755")]
		[Cpp2IlInjected.Address(RVA = "0x1394B28", Offset = "0x1394B28", VA = "0x1394B28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001756")]
		[Cpp2IlInjected.Address(RVA = "0x1394B30", Offset = "0x1394B30", VA = "0x1394B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600173A")]
	[Cpp2IlInjected.Address(RVA = "0x13946B4", Offset = "0x13946B4", VA = "0x13946B4")]
	internal void BindToGraphicsDevice(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600173B")]
	[Cpp2IlInjected.Address(RVA = "0x13947A8", Offset = "0x13947A8", VA = "0x13947A8")]
	internal void ThrowIfBound()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001757")]
	[Cpp2IlInjected.Address(RVA = "0x1394B4C", Offset = "0x1394B4C", VA = "0x1394B4C")]
	public BlendState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001758")]
	[Cpp2IlInjected.Address(RVA = "0x1394D48", Offset = "0x1394D48", VA = "0x1394D48")]
	private BlendState(string name, Blend sourceBlend, Blend destinationBlend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001759")]
	[Cpp2IlInjected.Address(RVA = "0x1394DE4", Offset = "0x1394DE4", VA = "0x1394DE4")]
	private BlendState(BlendState cloneSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600175A")]
	[Cpp2IlInjected.Address(RVA = "0x1394FA4", Offset = "0x1394FA4", VA = "0x1394FA4")]
	static BlendState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600175B")]
	[Cpp2IlInjected.Address(RVA = "0x13950D0", Offset = "0x13950D0", VA = "0x13950D0")]
	internal BlendState Clone()
	{
		return null;
	}
}
