using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.GameContent.Metadata;

[Cpp2IlInjected.Token(Token = "0x20005B5")]
public class TileMaterial
{
	[Cpp2IlInjected.Token(Token = "0x1700072D")]
	[JsonProperty]
	public TileGolfPhysics GolfPhysics
	{
		[Cpp2IlInjected.Token(Token = "0x6003C59")]
		[Cpp2IlInjected.Address(RVA = "0x1059484", Offset = "0x1059484", VA = "0x1059484")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003C5A")]
		[Cpp2IlInjected.Address(RVA = "0x105948C", Offset = "0x105948C", VA = "0x105948C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003C5B")]
	[Cpp2IlInjected.Address(RVA = "0x1059494", Offset = "0x1059494", VA = "0x1059494")]
	public TileMaterial()
	{
	}
}
