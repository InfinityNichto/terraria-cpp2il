using Cpp2IlInjected;
using Terraria.IO;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x200035F")]
public abstract class GenPass : GenBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030C6")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40030C7")]
	public double Weight;

	[Cpp2IlInjected.Token(Token = "0x6002C6D")]
	[Cpp2IlInjected.Address(RVA = "0x1300844", Offset = "0x1300844", VA = "0x1300844")]
	public GenPass(string name, double loadWeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C6E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

	[Cpp2IlInjected.Token(Token = "0x6002C6F")]
	[Cpp2IlInjected.Address(RVA = "0x1300870", Offset = "0x1300870", VA = "0x1300870")]
	public void Apply(GenerationProgress progress, GameConfiguration configuration)
	{
	}
}
