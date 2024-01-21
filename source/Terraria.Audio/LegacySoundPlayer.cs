using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;

namespace Terraria.Audio;

[Cpp2IlInjected.Token(Token = "0x2000488")]
public class LegacySoundPlayer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40064B9")]
	public Asset<SoundEffect>[] SoundDrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40064BA")]
	public SoundEffectInstance[] SoundInstanceDrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40064BB")]
	public Asset<SoundEffect>[] SoundLiquid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40064BC")]
	public SoundEffectInstance[] SoundInstanceLiquid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40064BD")]
	public Asset<SoundEffect>[] SoundMech;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40064BE")]
	public SoundEffectInstance[] SoundInstanceMech;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40064BF")]
	public Asset<SoundEffect>[] SoundDig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40064C0")]
	public SoundEffectInstance[] SoundInstanceDig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40064C1")]
	private int _digLastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40064C2")]
	public int[] SoundDigPlayCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40064C3")]
	public Asset<SoundEffect>[] SoundThunder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40064C4")]
	public SoundEffectInstance[] SoundInstanceThunder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40064C5")]
	public Asset<SoundEffect>[] SoundResearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40064C6")]
	public SoundEffectInstance[] SoundInstanceResearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40064C7")]
	public Asset<SoundEffect>[] SoundTink;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40064C8")]
	public SoundEffectInstance[] SoundInstanceTink;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40064C9")]
	public Asset<SoundEffect>[] SoundCoin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40064CA")]
	public SoundEffectInstance[] SoundInstanceCoin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40064CB")]
	public Asset<SoundEffect>[] SoundPlayerHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40064CC")]
	public SoundEffectInstance[] SoundInstancePlayerHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40064CD")]
	public Asset<SoundEffect>[] SoundFemaleHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40064CE")]
	public SoundEffectInstance[] SoundInstanceFemaleHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40064CF")]
	public Asset<SoundEffect> SoundPlayerKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40064D0")]
	public SoundEffectInstance SoundInstancePlayerKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40064D1")]
	public Asset<SoundEffect> SoundGrass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40064D2")]
	public SoundEffectInstance SoundInstanceGrass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40064D3")]
	public Asset<SoundEffect> SoundGrab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40064D4")]
	public SoundEffectInstance SoundInstanceGrab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40064D5")]
	public Asset<SoundEffect> SoundPixie;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40064D6")]
	public SoundEffectInstance SoundInstancePixie;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40064D7")]
	public Asset<SoundEffect>[] SoundItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40064D8")]
	public SoundEffectInstance[] SoundInstanceItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40064D9")]
	public Asset<SoundEffect>[] SoundNpcHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40064DA")]
	public SoundEffectInstance[] SoundInstanceNpcHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40064DB")]
	public Asset<SoundEffect>[] SoundNpcKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40064DC")]
	public SoundEffectInstance[] SoundInstanceNpcKilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40064DD")]
	public SoundEffectInstance SoundInstanceMoonlordCry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40064DE")]
	public Asset<SoundEffect> SoundDoorOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40064DF")]
	public SoundEffectInstance SoundInstanceDoorOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40064E0")]
	public Asset<SoundEffect> SoundDoorClosed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40064E1")]
	public SoundEffectInstance SoundInstanceDoorClosed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40064E2")]
	public Asset<SoundEffect> SoundMenuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40064E3")]
	public SoundEffectInstance SoundInstanceMenuOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40064E4")]
	public Asset<SoundEffect> SoundMenuClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40064E5")]
	public SoundEffectInstance SoundInstanceMenuClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40064E6")]
	public Asset<SoundEffect> SoundMenuTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40064E7")]
	public SoundEffectInstance SoundInstanceMenuTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40064E8")]
	public Asset<SoundEffect> SoundShatter;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40064E9")]
	public SoundEffectInstance SoundInstanceShatter;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40064EA")]
	public Asset<SoundEffect> SoundCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40064EB")]
	public SoundEffectInstance SoundInstanceCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40064EC")]
	public Asset<SoundEffect>[] SoundZombie;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40064ED")]
	public SoundEffectInstance[] SoundInstanceZombie;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40064EE")]
	public Asset<SoundEffect>[] SoundRoar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40064EF")]
	public SoundEffectInstance[] SoundInstanceRoar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40064F0")]
	public Asset<SoundEffect>[] SoundSplash;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40064F1")]
	public SoundEffectInstance[] SoundInstanceSplash;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40064F2")]
	public Asset<SoundEffect> SoundDoubleJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40064F3")]
	public SoundEffectInstance SoundInstanceDoubleJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40064F4")]
	public Asset<SoundEffect> SoundRun;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40064F5")]
	public SoundEffectInstance SoundInstanceRun;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40064F6")]
	public Asset<SoundEffect> SoundCoins;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40064F7")]
	public SoundEffectInstance SoundInstanceCoins;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40064F8")]
	public Asset<SoundEffect> SoundUnlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40064F9")]
	public SoundEffectInstance SoundInstanceUnlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40064FA")]
	public Asset<SoundEffect> SoundChat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40064FB")]
	public SoundEffectInstance SoundInstanceChat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40064FC")]
	public Asset<SoundEffect> SoundMaxMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40064FD")]
	public SoundEffectInstance SoundInstanceMaxMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40064FE")]
	public Asset<SoundEffect> SoundDrown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40064FF")]
	public SoundEffectInstance SoundInstanceDrown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4006500")]
	public Asset<SoundEffect>[] TrackableSounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4006501")]
	public SoundEffectInstance[] TrackableSoundInstances;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4006502")]
	private readonly IServiceProvider _services;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4006503")]
	private List<SoundEffectInstance> _trackedInstances;

	[Cpp2IlInjected.Token(Token = "0x60032ED")]
	[Cpp2IlInjected.Address(RVA = "0x106FC40", Offset = "0x106FC40", VA = "0x106FC40")]
	public LegacySoundPlayer(IServiceProvider services)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032EE")]
	[Cpp2IlInjected.Address(RVA = "0x10710B4", Offset = "0x10710B4", VA = "0x10710B4")]
	public void Reload()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032EF")]
	[Cpp2IlInjected.Address(RVA = "0x106FF64", Offset = "0x106FF64", VA = "0x106FF64")]
	private void LoadAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032F0")]
	[Cpp2IlInjected.Address(RVA = "0x10710B8", Offset = "0x10710B8", VA = "0x10710B8")]
	public void CreateAllSoundInstances()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032F1")]
	[Cpp2IlInjected.Address(RVA = "0x1071C78", Offset = "0x1071C78", VA = "0x1071C78")]
	private SoundEffectInstance CreateInstance(Asset<SoundEffect> asset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032F2")]
	[Cpp2IlInjected.Address(RVA = "0x1071B80", Offset = "0x1071B80", VA = "0x1071B80")]
	private Asset<SoundEffect> Load(string assetName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032F3")]
	[Cpp2IlInjected.Address(RVA = "0x1071CF0", Offset = "0x1071CF0", VA = "0x1071CF0")]
	public SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032F4")]
	[Cpp2IlInjected.Address(RVA = "0x1076E0C", Offset = "0x1076E0C", VA = "0x1076E0C")]
	public SoundEffect GetTrackableSoundByStyleId(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60032F5")]
	[Cpp2IlInjected.Address(RVA = "0x1076E64", Offset = "0x1076E64", VA = "0x1076E64")]
	public void StopAmbientSounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032F6")]
	[Cpp2IlInjected.Address(RVA = "0x1076DD4", Offset = "0x1076DD4", VA = "0x1076DD4")]
	public bool DoesSoundScaleWithAmbientVolume(int soundType)
	{
		return default(bool);
	}
}
