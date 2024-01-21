using Cpp2IlInjected;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035B")]
public static class Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200089B")]
	public class IsTile : GenCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400806D")]
		private ushort[] _types;

		[Cpp2IlInjected.Token(Token = "0x6004B86")]
		[Cpp2IlInjected.Address(RVA = "0x12FFE5C", Offset = "0x12FFE5C", VA = "0x12FFE5C")]
		public IsTile(params ushort[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B87")]
		[Cpp2IlInjected.Address(RVA = "0x12FFE88", Offset = "0x12FFE88", VA = "0x12FFE88", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200089C")]
	public class Continue : GenCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004B88")]
		[Cpp2IlInjected.Address(RVA = "0x12FFAE8", Offset = "0x12FFAE8", VA = "0x12FFAE8", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B89")]
		[Cpp2IlInjected.Address(RVA = "0x12FFAF0", Offset = "0x12FFAF0", VA = "0x12FFAF0")]
		public Continue()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200089D")]
	public class MysticSnake : GenCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004B8A")]
		[Cpp2IlInjected.Address(RVA = "0x130003C", Offset = "0x130003C", VA = "0x130003C", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B8B")]
		[Cpp2IlInjected.Address(RVA = "0x1300260", Offset = "0x1300260", VA = "0x1300260")]
		public MysticSnake()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200089E")]
	public class IsSolid : GenCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004B8C")]
		[Cpp2IlInjected.Address(RVA = "0x12FFC60", Offset = "0x12FFC60", VA = "0x12FFC60", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B8D")]
		[Cpp2IlInjected.Address(RVA = "0x12FFE4C", Offset = "0x12FFE4C", VA = "0x12FFE4C")]
		public IsSolid()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200089F")]
	public class HasLava : GenCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004B8E")]
		[Cpp2IlInjected.Address(RVA = "0x12FFB10", Offset = "0x12FFB10", VA = "0x12FFB10", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B8F")]
		[Cpp2IlInjected.Address(RVA = "0x12FFC50", Offset = "0x12FFC50", VA = "0x12FFC50")]
		public HasLava()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A0")]
	public class NotNull : GenCondition
	{
		[Cpp2IlInjected.Token(Token = "0x6004B90")]
		[Cpp2IlInjected.Address(RVA = "0x1300270", Offset = "0x1300270", VA = "0x1300270", Slot = "4")]
		protected override bool CheckValidity(int x, int y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B91")]
		[Cpp2IlInjected.Address(RVA = "0x1300304", Offset = "0x1300304", VA = "0x1300304")]
		public NotNull()
		{
		}
	}
}
