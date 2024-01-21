using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000596")]
public abstract class AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x17000726")]
	public string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x6003C09")]
		[Cpp2IlInjected.Address(RVA = "0x119681C", Offset = "0x119681C", VA = "0x119681C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003C0A")]
		[Cpp2IlInjected.Address(RVA = "0x1196824", Offset = "0x1196824", VA = "0x1196824")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003C0B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IsInBiome(Player player);

	[Cpp2IlInjected.Token(Token = "0x6003C0C")]
	[Cpp2IlInjected.Address(RVA = "0x119682C", Offset = "0x119682C", VA = "0x119682C")]
	protected AShoppingBiome()
	{
	}
}
