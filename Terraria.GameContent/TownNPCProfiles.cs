using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200056F")]
public class TownNPCProfiles
{
	[Cpp2IlInjected.Token(Token = "0x4006AB6")]
	private const string DefaultNPCFileFolderPath = "Images/TownNPCs/";

	[Cpp2IlInjected.Token(Token = "0x4006AB7")]
	private const string ShimmeredNPCFileFolderPath = "Images/TownNPCs/Shimmered/";

	[Cpp2IlInjected.Token(Token = "0x4006AB8")]
	private static readonly int[] CatHeadIDs;

	[Cpp2IlInjected.Token(Token = "0x4006AB9")]
	private static readonly int[] DogHeadIDs;

	[Cpp2IlInjected.Token(Token = "0x4006ABA")]
	private static readonly int[] BunnyHeadIDs;

	[Cpp2IlInjected.Token(Token = "0x4006ABB")]
	private static readonly int[] SlimeHeadIDs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ABC")]
	private Dictionary<int, ITownNPCProfile> _townNPCProfiles;

	[Cpp2IlInjected.Token(Token = "0x4006ABD")]
	public static TownNPCProfiles Instance;

	[Cpp2IlInjected.Token(Token = "0x6003ACE")]
	[Cpp2IlInjected.Address(RVA = "0x128D9F0", Offset = "0x128D9F0", VA = "0x128D9F0")]
	public bool GetProfile(int npcId, out ITownNPCProfile profile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003ACF")]
	[Cpp2IlInjected.Address(RVA = "0x128DA5C", Offset = "0x128DA5C", VA = "0x128DA5C")]
	public static ITownNPCProfile LegacyWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniquePartyTexture = true, bool uniquePartyTextureShimmered = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003AD0")]
	[Cpp2IlInjected.Address(RVA = "0x128DC04", Offset = "0x128DC04", VA = "0x128DC04")]
	public static ITownNPCProfile TransformableWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniqueCreditTexture = true, bool uniqueCreditTextureShimmered = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003AD1")]
	[Cpp2IlInjected.Address(RVA = "0x128DDA4", Offset = "0x128DDA4", VA = "0x128DDA4")]
	public static int GetHeadIndexSafe(NPC npc)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AD2")]
	[Cpp2IlInjected.Address(RVA = "0x128DF04", Offset = "0x128DF04", VA = "0x128DF04")]
	public TownNPCProfiles()
	{
	}
}
