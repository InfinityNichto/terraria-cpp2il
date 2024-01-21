using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent.Drawing;

[Cpp2IlInjected.Token(Token = "0x2000669")]
public class ParticleOrchestrator
{
	[Cpp2IlInjected.Token(Token = "0x4006D1C")]
	private static ParticlePool<FadingParticle> _poolFading;

	[Cpp2IlInjected.Token(Token = "0x4006D1D")]
	private static ParticlePool<FlameParticle> _poolFlame;

	[Cpp2IlInjected.Token(Token = "0x4006D1E")]
	private static ParticlePool<RandomizedFrameParticle> _poolRandomizedFrame;

	[Cpp2IlInjected.Token(Token = "0x4006D1F")]
	private static ParticlePool<PrettySparkleParticle> _poolPrettySparkle;

	[Cpp2IlInjected.Token(Token = "0x4006D20")]
	private static ParticlePool<ItemTransferParticle> _poolItemTransfer;

	[Cpp2IlInjected.Token(Token = "0x4006D21")]
	private static ParticlePool<LittleFlyingCritterParticle> _poolFlies;

	[Cpp2IlInjected.Token(Token = "0x4006D22")]
	private static ParticlePool<GasParticle> _poolGas;

	[Cpp2IlInjected.Token(Token = "0x600405A")]
	[Cpp2IlInjected.Address(RVA = "0xD79EB0", Offset = "0xD79EB0", VA = "0xD79EB0")]
	public static void RequestParticleSpawn(bool clientOnly, ParticleOrchestraType type, ParticleOrchestraSettings settings, [Optional] int? overrideInvokingPlayerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600405B")]
	[Cpp2IlInjected.Address(RVA = "0xD7AB68", Offset = "0xD7AB68", VA = "0xD7AB68")]
	public static void BroadcastParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600405C")]
	[Cpp2IlInjected.Address(RVA = "0xD7AC88", Offset = "0xD7AC88", VA = "0xD7AC88")]
	public static void BroadcastOrRequestParticleSpawn(ParticleOrchestraType type, ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600405D")]
	[Cpp2IlInjected.Address(RVA = "0xD7AE40", Offset = "0xD7AE40", VA = "0xD7AE40")]
	private static FadingParticle GetNewFadingParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600405E")]
	[Cpp2IlInjected.Address(RVA = "0xD7AEA4", Offset = "0xD7AEA4", VA = "0xD7AEA4")]
	private static LittleFlyingCritterParticle GetNewPooFlyParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600405F")]
	[Cpp2IlInjected.Address(RVA = "0xD7AF08", Offset = "0xD7AF08", VA = "0xD7AF08")]
	private static ItemTransferParticle GetNewItemTransferParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004060")]
	[Cpp2IlInjected.Address(RVA = "0xD7AF6C", Offset = "0xD7AF6C", VA = "0xD7AF6C")]
	private static FlameParticle GetNewFlameParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004061")]
	[Cpp2IlInjected.Address(RVA = "0xD7AFD0", Offset = "0xD7AFD0", VA = "0xD7AFD0")]
	private static RandomizedFrameParticle GetNewRandomizedFrameParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004062")]
	[Cpp2IlInjected.Address(RVA = "0xD7B034", Offset = "0xD7B034", VA = "0xD7B034")]
	private static PrettySparkleParticle GetNewPrettySparkleParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004063")]
	[Cpp2IlInjected.Address(RVA = "0xD7B098", Offset = "0xD7B098", VA = "0xD7B098")]
	private static GasParticle GetNewGasParticle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004064")]
	[Cpp2IlInjected.Address(RVA = "0xD7A064", Offset = "0xD7A064", VA = "0xD7A064")]
	public static void SpawnParticlesDirect(ParticleOrchestraType type, ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004065")]
	[Cpp2IlInjected.Address(RVA = "0xD89BF4", Offset = "0xD89BF4", VA = "0xD89BF4")]
	private static void Spawn_ShimmerTownNPCSend(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004066")]
	[Cpp2IlInjected.Address(RVA = "0xD8935C", Offset = "0xD8935C", VA = "0xD8935C")]
	private static void Spawn_ShimmerTownNPC(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004067")]
	[Cpp2IlInjected.Address(RVA = "0xD89148", Offset = "0xD89148", VA = "0xD89148")]
	private static void Spawn_PooFly(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004068")]
	[Cpp2IlInjected.Address(RVA = "0xD88A1C", Offset = "0xD88A1C", VA = "0xD88A1C")]
	private static void Spawn_Digestion(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004069")]
	[Cpp2IlInjected.Address(RVA = "0xD886FC", Offset = "0xD886FC", VA = "0xD886FC")]
	private static void Spawn_ShimmerBlock(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406A")]
	[Cpp2IlInjected.Address(RVA = "0xD880BC", Offset = "0xD880BC", VA = "0xD880BC")]
	private static void Spawn_LoadOutChange(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406B")]
	[Cpp2IlInjected.Address(RVA = "0xD87F70", Offset = "0xD87F70", VA = "0xD87F70")]
	private static void Spawn_TownSlimeTransform(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406C")]
	[Cpp2IlInjected.Address(RVA = "0xD8A6D0", Offset = "0xD8A6D0", VA = "0xD8A6D0")]
	private static void ElderSlimeEffect(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406D")]
	[Cpp2IlInjected.Address(RVA = "0xD8A0E4", Offset = "0xD8A0E4", VA = "0xD8A0E4")]
	private static void NerdySlimeEffect(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406E")]
	[Cpp2IlInjected.Address(RVA = "0xD8A350", Offset = "0xD8A350", VA = "0xD8A350")]
	private static void CopperSlimeEffect(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600406F")]
	[Cpp2IlInjected.Address(RVA = "0xD873F8", Offset = "0xD873F8", VA = "0xD873F8")]
	private static void Spawn_ShimmerArrow(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004070")]
	[Cpp2IlInjected.Address(RVA = "0xD87020", Offset = "0xD87020", VA = "0xD87020")]
	private static void Spawn_ItemTransfer(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004071")]
	[Cpp2IlInjected.Address(RVA = "0xD86254", Offset = "0xD86254", VA = "0xD86254")]
	private static void Spawn_PetExchange(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004072")]
	[Cpp2IlInjected.Address(RVA = "0xD83998", Offset = "0xD83998", VA = "0xD83998")]
	private static void Spawn_TerraBlade(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004073")]
	[Cpp2IlInjected.Address(RVA = "0xD84610", Offset = "0xD84610", VA = "0xD84610")]
	private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004074")]
	[Cpp2IlInjected.Address(RVA = "0xD86594", Offset = "0xD86594", VA = "0xD86594")]
	private static void Spawn_SlapHand(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004075")]
	[Cpp2IlInjected.Address(RVA = "0xD86624", Offset = "0xD86624", VA = "0xD86624")]
	private static void Spawn_WaffleIron(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004076")]
	[Cpp2IlInjected.Address(RVA = "0xD866B4", Offset = "0xD866B4", VA = "0xD866B4")]
	private static void Spawn_FlyMeal(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004077")]
	[Cpp2IlInjected.Address(RVA = "0xD86744", Offset = "0xD86744", VA = "0xD86744")]
	private static void Spawn_GasTrap(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004078")]
	[Cpp2IlInjected.Address(RVA = "0xD85028", Offset = "0xD85028", VA = "0xD85028")]
	private static void Spawn_TrueExcalibur(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004079")]
	[Cpp2IlInjected.Address(RVA = "0xD82DB8", Offset = "0xD82DB8", VA = "0xD82DB8")]
	private static void Spawn_AshTreeShake(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407A")]
	[Cpp2IlInjected.Address(RVA = "0xD826F0", Offset = "0xD826F0", VA = "0xD826F0")]
	private static void Spawn_LeafCrystalPassive(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407B")]
	[Cpp2IlInjected.Address(RVA = "0xD82AB0", Offset = "0xD82AB0", VA = "0xD82AB0")]
	private static void Spawn_LeafCrystalShot(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407C")]
	[Cpp2IlInjected.Address(RVA = "0xD81E78", Offset = "0xD81E78", VA = "0xD81E78")]
	private static void Spawn_TrueNightsEdge(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407D")]
	[Cpp2IlInjected.Address(RVA = "0xD813B8", Offset = "0xD813B8", VA = "0xD813B8")]
	private static void Spawn_NightsEdge(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407E")]
	[Cpp2IlInjected.Address(RVA = "0xD81B44", Offset = "0xD81B44", VA = "0xD81B44")]
	private static void Spawn_SilverBulletSparkle(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600407F")]
	[Cpp2IlInjected.Address(RVA = "0xD80A04", Offset = "0xD80A04", VA = "0xD80A04")]
	private static void Spawn_PaladinsHammer(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004080")]
	[Cpp2IlInjected.Address(RVA = "0xD7FE10", Offset = "0xD7FE10", VA = "0xD7FE10")]
	private static void Spawn_PrincessWeapon(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004081")]
	[Cpp2IlInjected.Address(RVA = "0xD7F368", Offset = "0xD7F368", VA = "0xD7F368")]
	private static void Spawn_StardustPunch(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004082")]
	[Cpp2IlInjected.Address(RVA = "0xD7DF1C", Offset = "0xD7DF1C", VA = "0xD7DF1C")]
	private static void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004083")]
	[Cpp2IlInjected.Address(RVA = "0xD7EA10", Offset = "0xD7EA10", VA = "0xD7EA10")]
	private static void Spawn_BlackLightningSmall(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004084")]
	[Cpp2IlInjected.Address(RVA = "0xD7D60C", Offset = "0xD7D60C", VA = "0xD7D60C")]
	private static void Spawn_BlackLightningHit(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004085")]
	[Cpp2IlInjected.Address(RVA = "0xD7C900", Offset = "0xD7C900", VA = "0xD7C900")]
	private static void Spawn_StellarTune(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004086")]
	[Cpp2IlInjected.Address(RVA = "0xD7B0FC", Offset = "0xD7B0FC", VA = "0xD7B0FC")]
	private static void Spawn_Keybrand(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004087")]
	[Cpp2IlInjected.Address(RVA = "0xD7C1EC", Offset = "0xD7C1EC", VA = "0xD7C1EC")]
	private static void Spawn_FlameWaders(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004088")]
	[Cpp2IlInjected.Address(RVA = "0xD7CEF8", Offset = "0xD7CEF8", VA = "0xD7CEF8")]
	private static void Spawn_WallOfFleshGoatMountFlames(ParticleOrchestraSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004089")]
	[Cpp2IlInjected.Address(RVA = "0xD8AC74", Offset = "0xD8AC74", VA = "0xD8AC74")]
	public ParticleOrchestrator()
	{
	}
}
