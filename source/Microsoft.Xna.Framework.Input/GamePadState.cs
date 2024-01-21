using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000288")]
public struct GamePadState
{
	[Cpp2IlInjected.Token(Token = "0x4001D35")]
	public static readonly GamePadState Default;

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public bool IsConnected
	{
		[Cpp2IlInjected.Token(Token = "0x600143A")]
		[Cpp2IlInjected.Address(RVA = "0x3A1640", Offset = "0x3A1640", VA = "0x3A1640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600143B")]
		[Cpp2IlInjected.Address(RVA = "0x3A1648", Offset = "0x3A1648", VA = "0x3A1648")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public int PacketNumber
	{
		[Cpp2IlInjected.Token(Token = "0x600143C")]
		[Cpp2IlInjected.Address(RVA = "0x3A1650", Offset = "0x3A1650", VA = "0x3A1650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600143D")]
		[Cpp2IlInjected.Address(RVA = "0x3A1658", Offset = "0x3A1658", VA = "0x3A1658")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public GamePadButtons Buttons
	{
		[Cpp2IlInjected.Token(Token = "0x600143E")]
		[Cpp2IlInjected.Address(RVA = "0x3A1660", Offset = "0x3A1660", VA = "0x3A1660")]
		[CompilerGenerated]
		get
		{
			return default(GamePadButtons);
		}
		[Cpp2IlInjected.Token(Token = "0x600143F")]
		[Cpp2IlInjected.Address(RVA = "0x3A1668", Offset = "0x3A1668", VA = "0x3A1668")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public GamePadDPad DPad
	{
		[Cpp2IlInjected.Token(Token = "0x6001440")]
		[Cpp2IlInjected.Address(RVA = "0x3A1670", Offset = "0x3A1670", VA = "0x3A1670")]
		[CompilerGenerated]
		get
		{
			return default(GamePadDPad);
		}
		[Cpp2IlInjected.Token(Token = "0x6001441")]
		[Cpp2IlInjected.Address(RVA = "0x3A1680", Offset = "0x3A1680", VA = "0x3A1680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public GamePadThumbSticks ThumbSticks
	{
		[Cpp2IlInjected.Token(Token = "0x6001442")]
		[Cpp2IlInjected.Address(RVA = "0x3A1690", Offset = "0x3A1690", VA = "0x3A1690")]
		[CompilerGenerated]
		get
		{
			return default(GamePadThumbSticks);
		}
		[Cpp2IlInjected.Token(Token = "0x6001443")]
		[Cpp2IlInjected.Address(RVA = "0x3A16A8", Offset = "0x3A16A8", VA = "0x3A16A8")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public GamePadTriggers Triggers
	{
		[Cpp2IlInjected.Token(Token = "0x6001444")]
		[Cpp2IlInjected.Address(RVA = "0x3A16D0", Offset = "0x3A16D0", VA = "0x3A16D0")]
		[CompilerGenerated]
		get
		{
			return default(GamePadTriggers);
		}
		[Cpp2IlInjected.Token(Token = "0x6001445")]
		[Cpp2IlInjected.Address(RVA = "0x3A16E4", Offset = "0x3A16E4", VA = "0x3A16E4")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001446")]
	[Cpp2IlInjected.Address(RVA = "0x3A16F0", Offset = "0x3A16F0", VA = "0x3A16F0")]
	public GamePadState(GamePadThumbSticks thumbSticks, GamePadTriggers triggers, GamePadButtons buttons, GamePadDPad dPad)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001447")]
	[Cpp2IlInjected.Address(RVA = "0x3A175C", Offset = "0x3A175C", VA = "0x3A175C")]
	public GamePadState(Vector2 leftThumbStick, Vector2 rightThumbStick, float leftTrigger, float rightTrigger, Buttons buttons)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001448")]
	[Cpp2IlInjected.Address(RVA = "0x3A1798", Offset = "0x3A1798", VA = "0x3A1798")]
	private Buttons GetVirtualButtons()
	{
		return default(Buttons);
	}

	[Cpp2IlInjected.Token(Token = "0x6001449")]
	[Cpp2IlInjected.Address(RVA = "0x3A17DC", Offset = "0x3A17DC", VA = "0x3A17DC")]
	public bool IsButtonDown(Buttons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600144A")]
	[Cpp2IlInjected.Address(RVA = "0x3A182C", Offset = "0x3A182C", VA = "0x3A182C")]
	public bool IsButtonUp(Buttons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600144B")]
	[Cpp2IlInjected.Address(RVA = "0x1552298", Offset = "0x1552298", VA = "0x1552298")]
	public static bool operator ==(GamePadState left, GamePadState right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600144C")]
	[Cpp2IlInjected.Address(RVA = "0x15524C8", Offset = "0x15524C8", VA = "0x15524C8")]
	public static bool operator !=(GamePadState left, GamePadState right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600144D")]
	[Cpp2IlInjected.Address(RVA = "0x3A1878", Offset = "0x3A1878", VA = "0x3A1878", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600144E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1880", Offset = "0x3A1880", VA = "0x3A1880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600144F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1888", Offset = "0x3A1888", VA = "0x3A1888", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
