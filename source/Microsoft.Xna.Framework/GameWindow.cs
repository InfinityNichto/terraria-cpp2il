using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000278")]
public abstract class GameWindow
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CE1")]
	private string title;

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public string Title
	{
		[Cpp2IlInjected.Token(Token = "0x600137E")]
		[Cpp2IlInjected.Address(RVA = "0x1394160", Offset = "0x1394160", VA = "0x1394160")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600137F")]
		[Cpp2IlInjected.Address(RVA = "0x1394168", Offset = "0x1394168", VA = "0x1394168")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public abstract bool AllowUserResizing
	{
		[Cpp2IlInjected.Token(Token = "0x6001380")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6001381")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public abstract Rectangle ClientBounds
	{
		[Cpp2IlInjected.Token(Token = "0x6001382")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public abstract IntPtr Handle
	{
		[Cpp2IlInjected.Token(Token = "0x6001383")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	public abstract string ScreenDeviceName
	{
		[Cpp2IlInjected.Token(Token = "0x6001384")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	public DisplayOrientation CurrentOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x6001392")]
		[Cpp2IlInjected.Address(RVA = "0x139469C", Offset = "0x139469C", VA = "0x139469C")]
		[CompilerGenerated]
		get
		{
			return default(DisplayOrientation);
		}
		[Cpp2IlInjected.Token(Token = "0x6001393")]
		[Cpp2IlInjected.Address(RVA = "0x13946A4", Offset = "0x13946A4", VA = "0x13946A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EventHandler ClientSizeChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6001385")]
		[Cpp2IlInjected.Address(RVA = "0x13941AC", Offset = "0x13941AC", VA = "0x13941AC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001386")]
		[Cpp2IlInjected.Address(RVA = "0x139425C", Offset = "0x139425C", VA = "0x139425C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EventHandler ScreenDeviceNameChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6001387")]
		[Cpp2IlInjected.Address(RVA = "0x139430C", Offset = "0x139430C", VA = "0x139430C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001388")]
		[Cpp2IlInjected.Address(RVA = "0x13943BC", Offset = "0x13943BC", VA = "0x13943BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001389")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BeginScreenDeviceChange(bool willBeFullScreen);

	[Cpp2IlInjected.Token(Token = "0x600138A")]
	[Cpp2IlInjected.Address(RVA = "0x139446C", Offset = "0x139446C", VA = "0x139446C")]
	public void EndScreenDeviceChange(string screenDeviceName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600138B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);

	[Cpp2IlInjected.Token(Token = "0x600138C")]
	[Cpp2IlInjected.Address(RVA = "0x13944E4", Offset = "0x13944E4", VA = "0x13944E4")]
	protected void OnActivated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600138D")]
	[Cpp2IlInjected.Address(RVA = "0x13944E8", Offset = "0x13944E8", VA = "0x13944E8")]
	protected void OnClientSizeChanged()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600138E")]
	[Cpp2IlInjected.Address(RVA = "0x1394584", Offset = "0x1394584", VA = "0x1394584")]
	protected void OnDeactivated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600138F")]
	[Cpp2IlInjected.Address(RVA = "0x1394588", Offset = "0x1394588", VA = "0x1394588")]
	protected void OnPaint()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001390")]
	[Cpp2IlInjected.Address(RVA = "0x1394600", Offset = "0x1394600", VA = "0x1394600")]
	protected void OnScreenDeviceNameChanged()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001391")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void SetTitle(string title);

	[Cpp2IlInjected.Token(Token = "0x6001394")]
	[Cpp2IlInjected.Address(RVA = "0x13946AC", Offset = "0x13946AC", VA = "0x13946AC")]
	protected GameWindow()
	{
	}
}
