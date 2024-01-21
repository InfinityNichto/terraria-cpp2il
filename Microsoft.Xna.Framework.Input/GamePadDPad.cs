using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000286")]
public struct GamePadDPad
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public ButtonState Down
	{
		[Cpp2IlInjected.Token(Token = "0x600142B")]
		[Cpp2IlInjected.Address(RVA = "0x3A14B4", Offset = "0x3A14B4", VA = "0x3A14B4")]
		[CompilerGenerated]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x600142C")]
		[Cpp2IlInjected.Address(RVA = "0x3A14BC", Offset = "0x3A14BC", VA = "0x3A14BC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public ButtonState Left
	{
		[Cpp2IlInjected.Token(Token = "0x600142D")]
		[Cpp2IlInjected.Address(RVA = "0x3A14C4", Offset = "0x3A14C4", VA = "0x3A14C4")]
		[CompilerGenerated]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x600142E")]
		[Cpp2IlInjected.Address(RVA = "0x3A14CC", Offset = "0x3A14CC", VA = "0x3A14CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public ButtonState Right
	{
		[Cpp2IlInjected.Token(Token = "0x600142F")]
		[Cpp2IlInjected.Address(RVA = "0x3A14D4", Offset = "0x3A14D4", VA = "0x3A14D4")]
		[CompilerGenerated]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x6001430")]
		[Cpp2IlInjected.Address(RVA = "0x3A14DC", Offset = "0x3A14DC", VA = "0x3A14DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public ButtonState Up
	{
		[Cpp2IlInjected.Token(Token = "0x6001431")]
		[Cpp2IlInjected.Address(RVA = "0x3A14E4", Offset = "0x3A14E4", VA = "0x3A14E4")]
		[CompilerGenerated]
		get
		{
			return default(ButtonState);
		}
		[Cpp2IlInjected.Token(Token = "0x6001432")]
		[Cpp2IlInjected.Address(RVA = "0x3A14EC", Offset = "0x3A14EC", VA = "0x3A14EC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001433")]
	[Cpp2IlInjected.Address(RVA = "0x3A14F4", Offset = "0x3A14F4", VA = "0x3A14F4")]
	public GamePadDPad(ButtonState upValue, ButtonState downValue, ButtonState leftValue, ButtonState rightValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001434")]
	[Cpp2IlInjected.Address(RVA = "0x3A150C", Offset = "0x3A150C", VA = "0x3A150C")]
	internal GamePadDPad(Buttons buttons)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001435")]
	[Cpp2IlInjected.Address(RVA = "0x1551C54", Offset = "0x1551C54", VA = "0x1551C54")]
	public static bool operator ==(GamePadDPad left, GamePadDPad right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001436")]
	[Cpp2IlInjected.Address(RVA = "0x1551C90", Offset = "0x1551C90", VA = "0x1551C90")]
	public static bool operator !=(GamePadDPad left, GamePadDPad right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001437")]
	[Cpp2IlInjected.Address(RVA = "0x3A154C", Offset = "0x3A154C", VA = "0x3A154C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001438")]
	[Cpp2IlInjected.Address(RVA = "0x3A1554", Offset = "0x3A1554", VA = "0x3A1554", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001439")]
	[Cpp2IlInjected.Address(RVA = "0x3A1584", Offset = "0x3A1584", VA = "0x3A1584", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
