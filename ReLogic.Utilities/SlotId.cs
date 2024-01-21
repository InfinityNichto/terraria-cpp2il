using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000714")]
public struct SlotId
{
	[Cpp2IlInjected.Token(Token = "0x400714E")]
	public static readonly SlotId Invalid;

	[Cpp2IlInjected.Token(Token = "0x400714F")]
	private const uint KEY_INC = 65536u;

	[Cpp2IlInjected.Token(Token = "0x4007150")]
	private const uint INDEX_MASK = 65535u;

	[Cpp2IlInjected.Token(Token = "0x4007151")]
	private const uint ACTIVE_MASK = 2147483648u;

	[Cpp2IlInjected.Token(Token = "0x4007152")]
	private const uint KEY_MASK = 2147418112u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007153")]
	public readonly uint Value;

	[Cpp2IlInjected.Token(Token = "0x170007E0")]
	public bool IsValid
	{
		[Cpp2IlInjected.Token(Token = "0x600462A")]
		[Cpp2IlInjected.Address(RVA = "0x39A8C0", Offset = "0x39A8C0", VA = "0x39A8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E1")]
	internal bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x600462B")]
		[Cpp2IlInjected.Address(RVA = "0x39A8D4", Offset = "0x39A8D4", VA = "0x39A8D4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E2")]
	internal uint Index
	{
		[Cpp2IlInjected.Token(Token = "0x600462C")]
		[Cpp2IlInjected.Address(RVA = "0x39A908", Offset = "0x39A908", VA = "0x39A908")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E3")]
	internal uint Key
	{
		[Cpp2IlInjected.Token(Token = "0x600462D")]
		[Cpp2IlInjected.Address(RVA = "0x39A910", Offset = "0x39A910", VA = "0x39A910")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600462E")]
	[Cpp2IlInjected.Address(RVA = "0x39A924", Offset = "0x39A924", VA = "0x39A924")]
	internal SlotId ToInactive(uint freeHead)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x600462F")]
	[Cpp2IlInjected.Address(RVA = "0x39A93C", Offset = "0x39A93C", VA = "0x39A93C")]
	internal SlotId ToActive(uint index)
	{
		return default(SlotId);
	}

	[Cpp2IlInjected.Token(Token = "0x6004630")]
	[Cpp2IlInjected.Address(RVA = "0x39A95C", Offset = "0x39A95C", VA = "0x39A95C")]
	public SlotId(uint value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004631")]
	[Cpp2IlInjected.Address(RVA = "0x39A964", Offset = "0x39A964", VA = "0x39A964", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004632")]
	[Cpp2IlInjected.Address(RVA = "0x39A96C", Offset = "0x39A96C", VA = "0x39A96C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004633")]
	[Cpp2IlInjected.Address(RVA = "0xF96E58", Offset = "0xF96E58", VA = "0xF96E58")]
	public static bool operator ==(SlotId lhs, SlotId rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004634")]
	[Cpp2IlInjected.Address(RVA = "0xF96E68", Offset = "0xF96E68", VA = "0xF96E68")]
	public static bool operator !=(SlotId lhs, SlotId rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004635")]
	[Cpp2IlInjected.Address(RVA = "0x39A994", Offset = "0x39A994", VA = "0x39A994")]
	public float ToFloat()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004636")]
	[Cpp2IlInjected.Address(RVA = "0xF96E7C", Offset = "0xF96E7C", VA = "0xF96E7C")]
	public static SlotId FromFloat(float value)
	{
		return default(SlotId);
	}
}
