using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002BF")]
public struct RenderTargetBinding
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001FF9")]
	private readonly Texture _renderTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001FFA")]
	private readonly int _arraySlice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001FFB")]
	private DepthFormat _depthFormat;

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public Texture RenderTarget
	{
		[Cpp2IlInjected.Token(Token = "0x60016C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A40A0", Offset = "0x3A40A0", VA = "0x3A40A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public int ArraySlice
	{
		[Cpp2IlInjected.Token(Token = "0x60016C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A40A8", Offset = "0x3A40A8", VA = "0x3A40A8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	internal DepthFormat DepthFormat
	{
		[Cpp2IlInjected.Token(Token = "0x60016C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A40B0", Offset = "0x3A40B0", VA = "0x3A40B0")]
		get
		{
			return default(DepthFormat);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60016C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B8", Offset = "0x3A40B8", VA = "0x3A40B8")]
	public RenderTargetBinding(RenderTarget2D renderTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016C5")]
	[Cpp2IlInjected.Address(RVA = "0x15931E4", Offset = "0x15931E4", VA = "0x15931E4")]
	public static implicit operator RenderTargetBinding(RenderTarget2D renderTarget)
	{
		return default(RenderTargetBinding);
	}
}
