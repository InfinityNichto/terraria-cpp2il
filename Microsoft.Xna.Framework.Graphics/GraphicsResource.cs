using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002B7")]
public abstract class GraphicsResource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001FDF")]
	private GraphicsDevice graphicsDevice;

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public GraphicsDevice GraphicsDevice
	{
		[Cpp2IlInjected.Token(Token = "0x600167F")]
		[Cpp2IlInjected.Address(RVA = "0x13A388C", Offset = "0x13A388C", VA = "0x13A388C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001680")]
		[Cpp2IlInjected.Address(RVA = "0x1394798", Offset = "0x1394798", VA = "0x1394798")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6001681")]
		[Cpp2IlInjected.Address(RVA = "0x13A3894", Offset = "0x13A3894", VA = "0x13A3894")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001682")]
		[Cpp2IlInjected.Address(RVA = "0x13A389C", Offset = "0x13A389C", VA = "0x13A389C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public object Tag
	{
		[Cpp2IlInjected.Token(Token = "0x6001683")]
		[Cpp2IlInjected.Address(RVA = "0x13A38A4", Offset = "0x13A38A4", VA = "0x13A38A4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001684")]
		[Cpp2IlInjected.Address(RVA = "0x13A38AC", Offset = "0x13A38AC", VA = "0x13A38AC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event EventHandler<EventArgs> Disposing
	{
		[Cpp2IlInjected.Token(Token = "0x600167D")]
		[Cpp2IlInjected.Address(RVA = "0x13A372C", Offset = "0x13A372C", VA = "0x13A372C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600167E")]
		[Cpp2IlInjected.Address(RVA = "0x13A37DC", Offset = "0x13A37DC", VA = "0x13A37DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600167A")]
	[Cpp2IlInjected.Address(RVA = "0x1394D40", Offset = "0x1394D40", VA = "0x1394D40")]
	internal GraphicsResource()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600167B")]
	[Cpp2IlInjected.Address(RVA = "0x13A3724", Offset = "0x13A3724", VA = "0x13A3724")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600167C")]
	[Cpp2IlInjected.Address(RVA = "0x13A3728", Offset = "0x13A3728", VA = "0x13A3728", Slot = "4")]
	protected internal virtual void GraphicsDeviceResetting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001685")]
	[Cpp2IlInjected.Address(RVA = "0x13A38B4", Offset = "0x13A38B4", VA = "0x13A38B4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
