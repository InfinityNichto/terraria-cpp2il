using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.IO;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000360")]
public static class Passes
{
	[Cpp2IlInjected.Token(Token = "0x20008BA")]
	public class Clear : GenPass
	{
		[Cpp2IlInjected.Token(Token = "0x6004BCC")]
		[Cpp2IlInjected.Address(RVA = "0x1303EA4", Offset = "0x1303EA4", VA = "0x1303EA4")]
		public Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCD")]
		[Cpp2IlInjected.Address(RVA = "0x1303F18", Offset = "0x1303F18", VA = "0x1303F18", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20008BB")]
	public class ScatterCustom : GenPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008097")]
		private CustomPerUnitAction _perUnit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008098")]
		private int _count;

		[Cpp2IlInjected.Token(Token = "0x6004BCE")]
		[Cpp2IlInjected.Address(RVA = "0x13040C4", Offset = "0x13040C4", VA = "0x13040C4")]
		public ScatterCustom(string name, double loadWeight, int count, [Optional] CustomPerUnitAction perUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BCF")]
		[Cpp2IlInjected.Address(RVA = "0x1304104", Offset = "0x1304104", VA = "0x1304104")]
		public void SetCustomAction(CustomPerUnitAction perUnit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BD0")]
		[Cpp2IlInjected.Address(RVA = "0x130410C", Offset = "0x130410C", VA = "0x130410C", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}
	}
}
