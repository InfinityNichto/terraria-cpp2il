using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002BE")]
public class RenderTarget2D : Texture2D, IRenderTarget
{
	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DepthFormat DepthStencilFormat
	{
		[Cpp2IlInjected.Token(Token = "0x60016B0")]
		[Cpp2IlInjected.Address(RVA = "0x1592CD8", Offset = "0x1592CD8", VA = "0x1592CD8")]
		[CompilerGenerated]
		get
		{
			return default(DepthFormat);
		}
		[Cpp2IlInjected.Token(Token = "0x60016B1")]
		[Cpp2IlInjected.Address(RVA = "0x1592CE0", Offset = "0x1592CE0", VA = "0x1592CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public int MultiSampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x60016B2")]
		[Cpp2IlInjected.Address(RVA = "0x1592CE8", Offset = "0x1592CE8", VA = "0x1592CE8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60016B3")]
		[Cpp2IlInjected.Address(RVA = "0x1592CF0", Offset = "0x1592CF0", VA = "0x1592CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public RenderTargetUsage RenderTargetUsage
	{
		[Cpp2IlInjected.Token(Token = "0x60016B4")]
		[Cpp2IlInjected.Address(RVA = "0x1592CF8", Offset = "0x1592CF8", VA = "0x1592CF8", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetUsage);
		}
		[Cpp2IlInjected.Token(Token = "0x60016B5")]
		[Cpp2IlInjected.Address(RVA = "0x1592D00", Offset = "0x1592D00", VA = "0x1592D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public bool IsContentLost
	{
		[Cpp2IlInjected.Token(Token = "0x60016B6")]
		[Cpp2IlInjected.Address(RVA = "0x1592D08", Offset = "0x1592D08", VA = "0x1592D08")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EventHandler<EventArgs> ContentLost
	{
		[Cpp2IlInjected.Token(Token = "0x60016B7")]
		[Cpp2IlInjected.Address(RVA = "0x1592D10", Offset = "0x1592D10", VA = "0x1592D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60016B8")]
		[Cpp2IlInjected.Address(RVA = "0x1592DC0", Offset = "0x1592DC0", VA = "0x1592DC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60016B9")]
	[Cpp2IlInjected.Address(RVA = "0x1592E70", Offset = "0x1592E70", VA = "0x1592E70")]
	private bool SuppressEventHandlerWarningsUntilEventsAreProperlyImplemented()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60016BA")]
	[Cpp2IlInjected.Address(RVA = "0x1592E80", Offset = "0x1592E80", VA = "0x1592E80")]
	public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared, int arraySize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016BB")]
	[Cpp2IlInjected.Address(RVA = "0x1592F58", Offset = "0x1592F58", VA = "0x1592F58")]
	public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016BC")]
	[Cpp2IlInjected.Address(RVA = "0x1592F94", Offset = "0x1592F94", VA = "0x1592F94")]
	public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016BD")]
	[Cpp2IlInjected.Address(RVA = "0x1592FD4", Offset = "0x1592FD4", VA = "0x1592FD4")]
	public RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016BE")]
	[Cpp2IlInjected.Address(RVA = "0x1593010", Offset = "0x1593010", VA = "0x1593010")]
	public RenderTarget2D(GraphicsDevice device, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016BF")]
	[Cpp2IlInjected.Address(RVA = "0x1593044", Offset = "0x1593044", VA = "0x1593044")]
	protected RenderTarget2D(GraphicsDevice device, int width, int height, bool mipMap, SurfaceFormat format, DepthFormat depthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, SurfaceType surfaceType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016C0")]
	[Cpp2IlInjected.Address(RVA = "0x1593114", Offset = "0x1593114", VA = "0x1593114", Slot = "4")]
	protected internal override void GraphicsDeviceResetting()
	{
	}
}
