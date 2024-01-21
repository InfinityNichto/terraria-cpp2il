using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200027A")]
internal class UnityGameWindow : GameWindow
{
	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	public override bool AllowUserResizing
	{
		[Cpp2IlInjected.Token(Token = "0x600139A")]
		[Cpp2IlInjected.Address(RVA = "0x1587048", Offset = "0x1587048", VA = "0x1587048", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600139B")]
		[Cpp2IlInjected.Address(RVA = "0x1587050", Offset = "0x1587050", VA = "0x1587050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	public override Rectangle ClientBounds
	{
		[Cpp2IlInjected.Token(Token = "0x600139D")]
		[Cpp2IlInjected.Address(RVA = "0x1587058", Offset = "0x1587058", VA = "0x1587058", Slot = "6")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public override IntPtr Handle
	{
		[Cpp2IlInjected.Token(Token = "0x600139F")]
		[Cpp2IlInjected.Address(RVA = "0x1587148", Offset = "0x1587148", VA = "0x1587148", Slot = "7")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	public override string ScreenDeviceName
	{
		[Cpp2IlInjected.Token(Token = "0x60013A0")]
		[Cpp2IlInjected.Address(RVA = "0x15871C0", Offset = "0x15871C0", VA = "0x15871C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600139C")]
	[Cpp2IlInjected.Address(RVA = "0x1587054", Offset = "0x1587054", VA = "0x1587054", Slot = "9")]
	public override void BeginScreenDeviceChange(bool willBeFullScreen)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600139E")]
	[Cpp2IlInjected.Address(RVA = "0x15870D0", Offset = "0x15870D0", VA = "0x15870D0", Slot = "10")]
	public override void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013A1")]
	[Cpp2IlInjected.Address(RVA = "0x1587238", Offset = "0x1587238", VA = "0x1587238", Slot = "11")]
	protected override void SetTitle(string title)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60013A2")]
	[Cpp2IlInjected.Address(RVA = "0x158723C", Offset = "0x158723C", VA = "0x158723C")]
	public UnityGameWindow()
	{
	}
}
