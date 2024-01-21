using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000362")]
public static class Searches
{
	[Cpp2IlInjected.Token(Token = "0x20008BC")]
	public class Left : GenSearch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008099")]
		private int _maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6004BD1")]
		[Cpp2IlInjected.Address(RVA = "0x1304534", Offset = "0x1304534", VA = "0x1304534")]
		public Left(int maxDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD2")]
		[Cpp2IlInjected.Address(RVA = "0x13045C0", Offset = "0x13045C0", VA = "0x13045C0", Slot = "4")]
		public override Point Find(Point origin)
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008BD")]
	public class Right : GenSearch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400809A")]
		private int _maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6004BD3")]
		[Cpp2IlInjected.Address(RVA = "0x1304878", Offset = "0x1304878", VA = "0x1304878")]
		public Right(int maxDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD4")]
		[Cpp2IlInjected.Address(RVA = "0x1304904", Offset = "0x1304904", VA = "0x1304904", Slot = "4")]
		public override Point Find(Point origin)
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008BE")]
	public class Down : GenSearch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400809B")]
		private int _maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6004BD5")]
		[Cpp2IlInjected.Address(RVA = "0x1304368", Offset = "0x1304368", VA = "0x1304368")]
		public Down(int maxDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD6")]
		[Cpp2IlInjected.Address(RVA = "0x13043F4", Offset = "0x13043F4", VA = "0x13043F4", Slot = "4")]
		public override Point Find(Point origin)
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008BF")]
	public class Up : GenSearch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400809C")]
		private int _maxDistance;

		[Cpp2IlInjected.Token(Token = "0x6004BD7")]
		[Cpp2IlInjected.Address(RVA = "0x13049F8", Offset = "0x13049F8", VA = "0x13049F8")]
		public Up(int maxDistance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1304A84", Offset = "0x1304A84", VA = "0x1304A84", Slot = "4")]
		public override Point Find(Point origin)
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C0")]
	public class Rectangle : GenSearch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400809D")]
		private int _width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400809E")]
		private int _height;

		[Cpp2IlInjected.Token(Token = "0x6004BD9")]
		[Cpp2IlInjected.Address(RVA = "0x13046B4", Offset = "0x13046B4", VA = "0x13046B4")]
		public Rectangle(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1304748", Offset = "0x1304748", VA = "0x1304748", Slot = "4")]
		public override Point Find(Point origin)
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C76")]
	[Cpp2IlInjected.Address(RVA = "0x1304360", Offset = "0x1304360", VA = "0x1304360")]
	public static GenSearch Chain(GenSearch search, params GenCondition[] conditions)
	{
		return null;
	}
}
