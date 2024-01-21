using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x200028A")]
public struct GamePadTriggers
{
	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public float Left
	{
		[Cpp2IlInjected.Token(Token = "0x600145E")]
		[Cpp2IlInjected.Address(RVA = "0x3A19E8", Offset = "0x3A19E8", VA = "0x3A19E8")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600145F")]
		[Cpp2IlInjected.Address(RVA = "0x3A19F0", Offset = "0x3A19F0", VA = "0x3A19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public float Right
	{
		[Cpp2IlInjected.Token(Token = "0x6001460")]
		[Cpp2IlInjected.Address(RVA = "0x3A19F8", Offset = "0x3A19F8", VA = "0x3A19F8")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001461")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A00", Offset = "0x3A1A00", VA = "0x3A1A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001462")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A08", Offset = "0x3A1A08", VA = "0x3A1A08")]
	public GamePadTriggers(float leftTrigger, float rightTrigger)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001463")]
	[Cpp2IlInjected.Address(RVA = "0x1552494", Offset = "0x1552494", VA = "0x1552494")]
	public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001464")]
	[Cpp2IlInjected.Address(RVA = "0x1553688", Offset = "0x1553688", VA = "0x1553688")]
	public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001465")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A58", Offset = "0x3A1A58", VA = "0x3A1A58", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001466")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A60", Offset = "0x3A1A60", VA = "0x3A1A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001467")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A68", Offset = "0x3A1A68", VA = "0x3A1A68", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
