using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics;

[Cpp2IlInjected.Token(Token = "0x2000528")]
public class DD2Film : Film
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400687F")]
	private NPC _dryad;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006880")]
	private NPC _ogre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006881")]
	private NPC _portal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006882")]
	private List<NPC> _army;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006883")]
	private List<NPC> _critters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006884")]
	private Vector2 _startPoint;

	[Cpp2IlInjected.Token(Token = "0x60038CC")]
	[Cpp2IlInjected.Address(RVA = "0x11AAF98", Offset = "0x11AAF98", VA = "0x11AAF98")]
	public DD2Film()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038CD")]
	[Cpp2IlInjected.Address(RVA = "0x11AC2FC", Offset = "0x11AC2FC", VA = "0x11AC2FC")]
	private void PerFrameSettings(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038CE")]
	[Cpp2IlInjected.Address(RVA = "0x11AC370", Offset = "0x11AC370", VA = "0x11AC370")]
	private void CreateDryad(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038CF")]
	[Cpp2IlInjected.Address(RVA = "0x11AC58C", Offset = "0x11AC58C", VA = "0x11AC58C")]
	private void DryadInteract(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D0")]
	[Cpp2IlInjected.Address(RVA = "0x11AC5FC", Offset = "0x11AC5FC", VA = "0x11AC5FC")]
	private void SpawnWitherBeast(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D1")]
	[Cpp2IlInjected.Address(RVA = "0x11AC794", Offset = "0x11AC794", VA = "0x11AC794")]
	private void SpawnJavalinThrower(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D2")]
	[Cpp2IlInjected.Address(RVA = "0x11AC92C", Offset = "0x11AC92C", VA = "0x11AC92C")]
	private void SpawnGoblin(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D3")]
	[Cpp2IlInjected.Address(RVA = "0x11ACAC4", Offset = "0x11ACAC4", VA = "0x11ACAC4")]
	private void CreateCritters(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D4")]
	[Cpp2IlInjected.Address(RVA = "0x11ACF14", Offset = "0x11ACF14", VA = "0x11ACF14")]
	private void OgreSwingSound(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D5")]
	[Cpp2IlInjected.Address(RVA = "0x11ACFB8", Offset = "0x11ACFB8", VA = "0x11ACFB8")]
	private void DryadPortalKnock(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D6")]
	[Cpp2IlInjected.Address(RVA = "0x11AD1FC", Offset = "0x11AD1FC", VA = "0x11AD1FC")]
	private void RemoveEnemyDamage(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D7")]
	[Cpp2IlInjected.Address(RVA = "0x11AD308", Offset = "0x11AD308", VA = "0x11AD308")]
	private void RestoreEnemyDamage(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D8")]
	[Cpp2IlInjected.Address(RVA = "0x11AD414", Offset = "0x11AD414", VA = "0x11AD414")]
	private void DryadPortalFade(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038D9")]
	[Cpp2IlInjected.Address(RVA = "0x11AD900", Offset = "0x11AD900", VA = "0x11AD900")]
	private void CreatePortal(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DA")]
	[Cpp2IlInjected.Address(RVA = "0x11AD9DC", Offset = "0x11AD9DC", VA = "0x11AD9DC")]
	private void DryadStand(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DB")]
	[Cpp2IlInjected.Address(RVA = "0x11ADA24", Offset = "0x11ADA24", VA = "0x11ADA24")]
	private void DryadLookRight(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DC")]
	[Cpp2IlInjected.Address(RVA = "0x11ADA40", Offset = "0x11ADA40", VA = "0x11ADA40")]
	private void DryadLookLeft(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DD")]
	[Cpp2IlInjected.Address(RVA = "0x11ADA5C", Offset = "0x11ADA5C", VA = "0x11ADA5C")]
	private void DryadWalk(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DE")]
	[Cpp2IlInjected.Address(RVA = "0x11ADA80", Offset = "0x11ADA80", VA = "0x11ADA80")]
	private void DryadConfusedEmote(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038DF")]
	[Cpp2IlInjected.Address(RVA = "0x11ADB4C", Offset = "0x11ADB4C", VA = "0x11ADB4C")]
	private void DryadAlertEmote(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E0")]
	[Cpp2IlInjected.Address(RVA = "0x11ADC18", Offset = "0x11ADC18", VA = "0x11ADC18")]
	private void CreateOgre(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E1")]
	[Cpp2IlInjected.Address(RVA = "0x11ADDA0", Offset = "0x11ADDA0", VA = "0x11ADDA0")]
	private void OgreStand(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E2")]
	[Cpp2IlInjected.Address(RVA = "0x11ADE9C", Offset = "0x11ADE9C", VA = "0x11ADE9C")]
	private void DryadAttack(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E3")]
	[Cpp2IlInjected.Address(RVA = "0x11ADEF4", Offset = "0x11ADEF4", VA = "0x11ADEF4")]
	private void OgreLookRight(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E4")]
	[Cpp2IlInjected.Address(RVA = "0x11ADF10", Offset = "0x11ADF10", VA = "0x11ADF10")]
	private void OgreLookLeft(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E5")]
	[Cpp2IlInjected.Address(RVA = "0x11ADF2C", Offset = "0x11ADF2C", VA = "0x11ADF2C", Slot = "4")]
	public override void OnBegin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E6")]
	[Cpp2IlInjected.Address(RVA = "0x11AC3D4", Offset = "0x11AC3D4", VA = "0x11AC3D4")]
	private NPC PlaceNPCOnGround(int type, Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60038E7")]
	[Cpp2IlInjected.Address(RVA = "0x11AE0AC", Offset = "0x11AE0AC", VA = "0x11AE0AC", Slot = "5")]
	public override void OnEnd()
	{
	}
}
