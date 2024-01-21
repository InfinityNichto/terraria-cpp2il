using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035D")]
public static class ModShapes
{
	[Cpp2IlInjected.Token(Token = "0x20008A1")]
	public class All : GenModShape
	{
		[Cpp2IlInjected.Token(Token = "0x6004B92")]
		[Cpp2IlInjected.Address(RVA = "0x130137C", Offset = "0x130137C", VA = "0x130137C")]
		public All(ShapeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B93")]
		[Cpp2IlInjected.Address(RVA = "0x130139C", Offset = "0x130139C", VA = "0x130139C", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A2")]
	public class OuterOutline : GenModShape
	{
		[Cpp2IlInjected.Token(Token = "0x400806E")]
		private static readonly int[] POINT_OFFSETS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400806F")]
		private bool _useDiagonals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4008070")]
		private bool _useInterior;

		[Cpp2IlInjected.Token(Token = "0x6004B94")]
		[Cpp2IlInjected.Address(RVA = "0x130199C", Offset = "0x130199C", VA = "0x130199C")]
		public OuterOutline(ShapeData data, bool useDiagonals = true, bool useInterior = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B95")]
		[Cpp2IlInjected.Address(RVA = "0x13019CC", Offset = "0x13019CC", VA = "0x13019CC", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008A3")]
	public class InnerOutline : GenModShape
	{
		[Cpp2IlInjected.Token(Token = "0x4008071")]
		private static readonly int[] POINT_OFFSETS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008072")]
		private bool _useDiagonals;

		[Cpp2IlInjected.Token(Token = "0x6004B97")]
		[Cpp2IlInjected.Address(RVA = "0x13015B0", Offset = "0x13015B0", VA = "0x13015B0")]
		public InnerOutline(ShapeData data, bool useDiagonals = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B98")]
		[Cpp2IlInjected.Address(RVA = "0x13015D8", Offset = "0x13015D8", VA = "0x13015D8", Slot = "4")]
		public override bool Perform(Point origin, GenAction action)
		{
			return default(bool);
		}
	}
}
