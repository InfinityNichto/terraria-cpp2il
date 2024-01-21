using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002BD")]
public class PresentationParameters
{
	[Cpp2IlInjected.Token(Token = "0x4001FE9")]
	public const int DefaultPresentRate = 60;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001FEA")]
	private DepthFormat depthStencilFormat;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001FEB")]
	private SurfaceFormat backBufferFormat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001FEC")]
	private int backBufferHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001FED")]
	private int backBufferWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001FEE")]
	private IntPtr deviceWindowHandle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001FEF")]
	private int multiSampleCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001FF0")]
	private bool isFullScreen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4001FF1")]
	private bool hardwareModeSwitch;

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public SurfaceFormat BackBufferFormat
	{
		[Cpp2IlInjected.Token(Token = "0x6001697")]
		[Cpp2IlInjected.Address(RVA = "0x1592608", Offset = "0x1592608", VA = "0x1592608")]
		get
		{
			return default(SurfaceFormat);
		}
		[Cpp2IlInjected.Token(Token = "0x6001698")]
		[Cpp2IlInjected.Address(RVA = "0x1592610", Offset = "0x1592610", VA = "0x1592610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public int BackBufferHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6001699")]
		[Cpp2IlInjected.Address(RVA = "0x1592618", Offset = "0x1592618", VA = "0x1592618")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600169A")]
		[Cpp2IlInjected.Address(RVA = "0x1592620", Offset = "0x1592620", VA = "0x1592620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public int BackBufferWidth
	{
		[Cpp2IlInjected.Token(Token = "0x600169B")]
		[Cpp2IlInjected.Address(RVA = "0x1592628", Offset = "0x1592628", VA = "0x1592628")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600169C")]
		[Cpp2IlInjected.Address(RVA = "0x1592630", Offset = "0x1592630", VA = "0x1592630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public Rectangle Bounds
	{
		[Cpp2IlInjected.Token(Token = "0x600169D")]
		[Cpp2IlInjected.Address(RVA = "0x1592638", Offset = "0x1592638", VA = "0x1592638")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public IntPtr DeviceWindowHandle
	{
		[Cpp2IlInjected.Token(Token = "0x600169E")]
		[Cpp2IlInjected.Address(RVA = "0x1592674", Offset = "0x1592674", VA = "0x1592674")]
		get
		{
			return default(IntPtr);
		}
		[Cpp2IlInjected.Token(Token = "0x600169F")]
		[Cpp2IlInjected.Address(RVA = "0x159267C", Offset = "0x159267C", VA = "0x159267C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public DepthFormat DepthStencilFormat
	{
		[Cpp2IlInjected.Token(Token = "0x60016A0")]
		[Cpp2IlInjected.Address(RVA = "0x1592684", Offset = "0x1592684", VA = "0x1592684")]
		get
		{
			return default(DepthFormat);
		}
		[Cpp2IlInjected.Token(Token = "0x60016A1")]
		[Cpp2IlInjected.Address(RVA = "0x159268C", Offset = "0x159268C", VA = "0x159268C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public bool IsFullScreen
	{
		[Cpp2IlInjected.Token(Token = "0x60016A2")]
		[Cpp2IlInjected.Address(RVA = "0x1592694", Offset = "0x1592694", VA = "0x1592694")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60016A3")]
		[Cpp2IlInjected.Address(RVA = "0x159269C", Offset = "0x159269C", VA = "0x159269C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public bool HardwareModeSwitch
	{
		[Cpp2IlInjected.Token(Token = "0x60016A4")]
		[Cpp2IlInjected.Address(RVA = "0x15926A4", Offset = "0x15926A4", VA = "0x15926A4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60016A5")]
		[Cpp2IlInjected.Address(RVA = "0x15926AC", Offset = "0x15926AC", VA = "0x15926AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int MultiSampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x60016A6")]
		[Cpp2IlInjected.Address(RVA = "0x15926B4", Offset = "0x15926B4", VA = "0x15926B4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60016A7")]
		[Cpp2IlInjected.Address(RVA = "0x15926BC", Offset = "0x15926BC", VA = "0x15926BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public PresentInterval PresentationInterval
	{
		[Cpp2IlInjected.Token(Token = "0x60016A8")]
		[Cpp2IlInjected.Address(RVA = "0x15926C4", Offset = "0x15926C4", VA = "0x15926C4")]
		[CompilerGenerated]
		get
		{
			return default(PresentInterval);
		}
		[Cpp2IlInjected.Token(Token = "0x60016A9")]
		[Cpp2IlInjected.Address(RVA = "0x15926CC", Offset = "0x15926CC", VA = "0x15926CC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public DisplayOrientation DisplayOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x60016AA")]
		[Cpp2IlInjected.Address(RVA = "0x15926D4", Offset = "0x15926D4", VA = "0x15926D4")]
		[CompilerGenerated]
		get
		{
			return default(DisplayOrientation);
		}
		[Cpp2IlInjected.Token(Token = "0x60016AB")]
		[Cpp2IlInjected.Address(RVA = "0x15926DC", Offset = "0x15926DC", VA = "0x15926DC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public RenderTargetUsage RenderTargetUsage
	{
		[Cpp2IlInjected.Token(Token = "0x60016AC")]
		[Cpp2IlInjected.Address(RVA = "0x15926E4", Offset = "0x15926E4", VA = "0x15926E4")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetUsage);
		}
		[Cpp2IlInjected.Token(Token = "0x60016AD")]
		[Cpp2IlInjected.Address(RVA = "0x15926EC", Offset = "0x15926EC", VA = "0x15926EC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001696")]
	[Cpp2IlInjected.Address(RVA = "0x15924F8", Offset = "0x15924F8", VA = "0x15924F8")]
	public PresentationParameters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016AE")]
	[Cpp2IlInjected.Address(RVA = "0x1592580", Offset = "0x1592580", VA = "0x1592580")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60016AF")]
	[Cpp2IlInjected.Address(RVA = "0x15926F4", Offset = "0x15926F4", VA = "0x15926F4")]
	public PresentationParameters Clone()
	{
		return null;
	}
}
