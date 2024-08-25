using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.Audio
{
	[global::Cpp2ILInjected.Token(Token = "0x2000689")]
	public class LegacySoundPlayer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60037DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422454", Offset = "0x1422454", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Load", MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public LegacySoundPlayer(IServiceProvider services)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14237A8", Offset = "0x14237A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reload()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1422788", Offset = "0x1422788", Length = "0x1020")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Asset<SoundEffect>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "get_TrackableLegacySoundCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "GetTrackableLegacySoundPath", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 97)]
		private void LoadAll()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14237AC", Offset = "0x14237AC", Length = "0x874")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundPlayer), Member = "CreateInstance", MemberParameters = new object[] { typeof(Asset<SoundEffect>) }, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void CreateAllSoundInstances()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1424110", Offset = "0x1424110", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "CreateAllSoundInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private SoundEffectInstance CreateInstance(Asset<SoundEffect> asset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1424020", Offset = "0x1424020", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "LoadAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XnaExtensions), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Asset<SoundEffect> Load(string assetName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14241D4", Offset = "0x14241D4", Length = "0x4404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_soundVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ambientVolume", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffect), Member = "CreateInstance", ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEffectInstance), Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstanceGarbageCollector), Member = "Track", MemberParameters = new object[] { typeof(SoundEffectInstance) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 278)]
		public SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1428608", Offset = "0x1428608", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "GetTrackableSoundByStyleId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SoundEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SoundEffect GetTrackableSoundByStyleId(int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1428654", Offset = "0x1428654", Length = "0x105C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEngine), Member = "StopAmbientSounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void StopAmbientSounds()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60037E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14285D8", Offset = "0x14285D8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool DoesSoundScaleWithAmbientVolume(int soundType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40078B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Asset<SoundEffect>[] SoundDrip;

		[global::Cpp2ILInjected.Token(Token = "0x40078B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SoundEffectInstance[] SoundInstanceDrip;

		[global::Cpp2ILInjected.Token(Token = "0x40078B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Asset<SoundEffect>[] SoundLiquid;

		[global::Cpp2ILInjected.Token(Token = "0x40078B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public SoundEffectInstance[] SoundInstanceLiquid;

		[global::Cpp2ILInjected.Token(Token = "0x40078B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Asset<SoundEffect>[] SoundMech;

		[global::Cpp2ILInjected.Token(Token = "0x40078B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public SoundEffectInstance[] SoundInstanceMech;

		[global::Cpp2ILInjected.Token(Token = "0x40078BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Asset<SoundEffect>[] SoundDig;

		[global::Cpp2ILInjected.Token(Token = "0x40078BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public SoundEffectInstance[] SoundInstanceDig;

		[global::Cpp2ILInjected.Token(Token = "0x40078BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _digLastFrame;

		[global::Cpp2ILInjected.Token(Token = "0x40078BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public int[] SoundDigPlayCount;

		[global::Cpp2ILInjected.Token(Token = "0x40078BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Asset<SoundEffect>[] SoundThunder;

		[global::Cpp2ILInjected.Token(Token = "0x40078BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public SoundEffectInstance[] SoundInstanceThunder;

		[global::Cpp2ILInjected.Token(Token = "0x40078C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Asset<SoundEffect>[] SoundResearch;

		[global::Cpp2ILInjected.Token(Token = "0x40078C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public SoundEffectInstance[] SoundInstanceResearch;

		[global::Cpp2ILInjected.Token(Token = "0x40078C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Asset<SoundEffect>[] SoundTink;

		[global::Cpp2ILInjected.Token(Token = "0x40078C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public SoundEffectInstance[] SoundInstanceTink;

		[global::Cpp2ILInjected.Token(Token = "0x40078C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Asset<SoundEffect>[] SoundCoin;

		[global::Cpp2ILInjected.Token(Token = "0x40078C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public SoundEffectInstance[] SoundInstanceCoin;

		[global::Cpp2ILInjected.Token(Token = "0x40078C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Asset<SoundEffect>[] SoundPlayerHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public SoundEffectInstance[] SoundInstancePlayerHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Asset<SoundEffect>[] SoundFemaleHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public SoundEffectInstance[] SoundInstanceFemaleHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public Asset<SoundEffect> SoundPlayerKilled;

		[global::Cpp2ILInjected.Token(Token = "0x40078CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public SoundEffectInstance SoundInstancePlayerKilled;

		[global::Cpp2ILInjected.Token(Token = "0x40078CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Asset<SoundEffect> SoundGrass;

		[global::Cpp2ILInjected.Token(Token = "0x40078CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public SoundEffectInstance SoundInstanceGrass;

		[global::Cpp2ILInjected.Token(Token = "0x40078CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Asset<SoundEffect> SoundGrab;

		[global::Cpp2ILInjected.Token(Token = "0x40078CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public SoundEffectInstance SoundInstanceGrab;

		[global::Cpp2ILInjected.Token(Token = "0x40078D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public Asset<SoundEffect> SoundPixie;

		[global::Cpp2ILInjected.Token(Token = "0x40078D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public SoundEffectInstance SoundInstancePixie;

		[global::Cpp2ILInjected.Token(Token = "0x40078D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public Asset<SoundEffect>[] SoundItem;

		[global::Cpp2ILInjected.Token(Token = "0x40078D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public SoundEffectInstance[] SoundInstanceItem;

		[global::Cpp2ILInjected.Token(Token = "0x40078D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public Asset<SoundEffect>[] SoundNpcHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public SoundEffectInstance[] SoundInstanceNpcHit;

		[global::Cpp2ILInjected.Token(Token = "0x40078D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public Asset<SoundEffect>[] SoundNpcKilled;

		[global::Cpp2ILInjected.Token(Token = "0x40078D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public SoundEffectInstance[] SoundInstanceNpcKilled;

		[global::Cpp2ILInjected.Token(Token = "0x40078D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public SoundEffectInstance SoundInstanceMoonlordCry;

		[global::Cpp2ILInjected.Token(Token = "0x40078D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public Asset<SoundEffect> SoundDoorOpen;

		[global::Cpp2ILInjected.Token(Token = "0x40078DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public SoundEffectInstance SoundInstanceDoorOpen;

		[global::Cpp2ILInjected.Token(Token = "0x40078DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Asset<SoundEffect> SoundDoorClosed;

		[global::Cpp2ILInjected.Token(Token = "0x40078DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public SoundEffectInstance SoundInstanceDoorClosed;

		[global::Cpp2ILInjected.Token(Token = "0x40078DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public Asset<SoundEffect> SoundMenuOpen;

		[global::Cpp2ILInjected.Token(Token = "0x40078DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public SoundEffectInstance SoundInstanceMenuOpen;

		[global::Cpp2ILInjected.Token(Token = "0x40078DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public Asset<SoundEffect> SoundMenuClose;

		[global::Cpp2ILInjected.Token(Token = "0x40078E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		public SoundEffectInstance SoundInstanceMenuClose;

		[global::Cpp2ILInjected.Token(Token = "0x40078E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public Asset<SoundEffect> SoundMenuTick;

		[global::Cpp2ILInjected.Token(Token = "0x40078E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		public SoundEffectInstance SoundInstanceMenuTick;

		[global::Cpp2ILInjected.Token(Token = "0x40078E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public Asset<SoundEffect> SoundShatter;

		[global::Cpp2ILInjected.Token(Token = "0x40078E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public SoundEffectInstance SoundInstanceShatter;

		[global::Cpp2ILInjected.Token(Token = "0x40078E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		public Asset<SoundEffect> SoundCamera;

		[global::Cpp2ILInjected.Token(Token = "0x40078E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		public SoundEffectInstance SoundInstanceCamera;

		[global::Cpp2ILInjected.Token(Token = "0x40078E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		public Asset<SoundEffect>[] SoundZombie;

		[global::Cpp2ILInjected.Token(Token = "0x40078E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		public SoundEffectInstance[] SoundInstanceZombie;

		[global::Cpp2ILInjected.Token(Token = "0x40078E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		public Asset<SoundEffect>[] SoundRoar;

		[global::Cpp2ILInjected.Token(Token = "0x40078EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		public SoundEffectInstance[] SoundInstanceRoar;

		[global::Cpp2ILInjected.Token(Token = "0x40078EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		public Asset<SoundEffect>[] SoundSplash;

		[global::Cpp2ILInjected.Token(Token = "0x40078EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		public SoundEffectInstance[] SoundInstanceSplash;

		[global::Cpp2ILInjected.Token(Token = "0x40078ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		public Asset<SoundEffect> SoundDoubleJump;

		[global::Cpp2ILInjected.Token(Token = "0x40078EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		public SoundEffectInstance SoundInstanceDoubleJump;

		[global::Cpp2ILInjected.Token(Token = "0x40078EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public Asset<SoundEffect> SoundRun;

		[global::Cpp2ILInjected.Token(Token = "0x40078F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public SoundEffectInstance SoundInstanceRun;

		[global::Cpp2ILInjected.Token(Token = "0x40078F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public Asset<SoundEffect> SoundCoins;

		[global::Cpp2ILInjected.Token(Token = "0x40078F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public SoundEffectInstance SoundInstanceCoins;

		[global::Cpp2ILInjected.Token(Token = "0x40078F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public Asset<SoundEffect> SoundUnlock;

		[global::Cpp2ILInjected.Token(Token = "0x40078F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public SoundEffectInstance SoundInstanceUnlock;

		[global::Cpp2ILInjected.Token(Token = "0x40078F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public Asset<SoundEffect> SoundChat;

		[global::Cpp2ILInjected.Token(Token = "0x40078F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public SoundEffectInstance SoundInstanceChat;

		[global::Cpp2ILInjected.Token(Token = "0x40078F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public Asset<SoundEffect> SoundMaxMana;

		[global::Cpp2ILInjected.Token(Token = "0x40078F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public SoundEffectInstance SoundInstanceMaxMana;

		[global::Cpp2ILInjected.Token(Token = "0x40078F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public Asset<SoundEffect> SoundDrown;

		[global::Cpp2ILInjected.Token(Token = "0x40078FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public SoundEffectInstance SoundInstanceDrown;

		[global::Cpp2ILInjected.Token(Token = "0x40078FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
		public Asset<SoundEffect>[] TrackableSounds;

		[global::Cpp2ILInjected.Token(Token = "0x40078FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
		public SoundEffectInstance[] TrackableSoundInstances;

		[global::Cpp2ILInjected.Token(Token = "0x40078FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
		private readonly IServiceProvider _services;

		[global::Cpp2ILInjected.Token(Token = "0x40078FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
		private List<SoundEffectInstance> _trackedInstances;
	}
}
