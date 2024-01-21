using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000365")]
public static class Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20008C1")]
	public class Circle : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400809F")]
		private int _verticalRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40080A0")]
		private int _horizontalRadius;

		[Cpp2IlInjected.Token(Token = "0x6004BDB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D330", Offset = "0xA0D330", VA = "0xA0D330")]
		public Circle(int radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDC")]
		[Cpp2IlInjected.Address(RVA = "0xA0D354", Offset = "0xA0D354", VA = "0xA0D354")]
		public Circle(int horizontalRadius, int verticalRadius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA0D37C", Offset = "0xA0D37C", VA = "0xA0D37C")]
		public void SetRadius(int radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA0D388", Offset = "0xA0D388", VA = "0xA0D388", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C2")]
	public class HalfCircle : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080A1")]
		private int _radius;

		[Cpp2IlInjected.Token(Token = "0x6004BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA0D5CC", Offset = "0xA0D5CC", VA = "0xA0D5CC")]
		public HalfCircle(int radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE0")]
		[Cpp2IlInjected.Address(RVA = "0xA0D5EC", Offset = "0xA0D5EC", VA = "0xA0D5EC", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C3")]
	public class Slime : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080A2")]
		private int _radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40080A3")]
		private double _xScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40080A4")]
		private double _yScale;

		[Cpp2IlInjected.Token(Token = "0x6004BE1")]
		[Cpp2IlInjected.Address(RVA = "0xA0DCB8", Offset = "0xA0DCB8", VA = "0xA0DCB8")]
		public Slime(int radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE2")]
		[Cpp2IlInjected.Address(RVA = "0xA0DCF4", Offset = "0xA0DCF4", VA = "0xA0DCF4")]
		public Slime(int radius, double xScale, double yScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE3")]
		[Cpp2IlInjected.Address(RVA = "0xA0DD28", Offset = "0xA0DD28", VA = "0xA0DD28", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C4")]
	public class Rectangle : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080A5")]
		private Microsoft.Xna.Framework.Rectangle _area;

		[Cpp2IlInjected.Token(Token = "0x6004BE4")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA40", Offset = "0xA0DA40", VA = "0xA0DA40")]
		public Rectangle(Microsoft.Xna.Framework.Rectangle area)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE5")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA78", Offset = "0xA0DA78", VA = "0xA0DA78")]
		public Rectangle(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA0DAD8", Offset = "0xA0DAD8", VA = "0xA0DAD8")]
		public void SetArea(Microsoft.Xna.Framework.Rectangle area)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE7")]
		[Cpp2IlInjected.Address(RVA = "0xA0DAE8", Offset = "0xA0DAE8", VA = "0xA0DAE8", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C5")]
	public class Tail : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080A6")]
		private double _width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40080A7")]
		private Vector2D _endOffset;

		[Cpp2IlInjected.Token(Token = "0x6004BE8")]
		[Cpp2IlInjected.Address(RVA = "0xA0E188", Offset = "0xA0E188", VA = "0xA0E188")]
		public Tail(double width, Vector2D endOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BE9")]
		[Cpp2IlInjected.Address(RVA = "0xA0E270", Offset = "0xA0E270", VA = "0xA0E270", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008C6")]
	public class Mound : GenShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080A8")]
		private int _halfWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40080A9")]
		private int _height;

		[Cpp2IlInjected.Token(Token = "0x6004BEA")]
		[Cpp2IlInjected.Address(RVA = "0xA0D7F4", Offset = "0xA0D7F4", VA = "0xA0D7F4")]
		public Mound(int halfWidth, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BEB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D81C", Offset = "0xA0D81C", VA = "0xA0D81C", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}
}
