using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.Ambience;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000659 RID: 1625
	[global::Cpp2ILInjected.Token(Token = "0x20009B4")]
	public class AmbientSky : CustomSky
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x0002D590 File Offset: 0x0002B790
		[global::Cpp2ILInjected.Token(Token = "0x6004983")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FD30", Offset = "0x82FD30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0002D593 File Offset: 0x0002B793
		[global::Cpp2ILInjected.Token(Token = "0x6004984")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FD3C", Offset = "0x82FD3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0002D596 File Offset: 0x0002B796
		[global::Cpp2ILInjected.Token(Token = "0x6004985")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FD44", Offset = "0x82FD44", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool AnActiveSkyConflictsWithAmbience()
		{
			throw null;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x0002D599 File Offset: 0x0002B799
		[global::Cpp2ILInjected.Token(Token = "0x6004986")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FE34", Offset = "0x82FE34", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky), Member = "AnActiveSkyConflictsWithAmbience", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Remove", MemberParameters = new object[] { typeof(SlotId) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x0002D59C File Offset: 0x0002B79C
		[global::Cpp2ILInjected.Token(Token = "0x6004987")]
		[global::Cpp2ILInjected.Address(RVA = "0x8303BC", Offset = "0x8303BC", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x0002D59F File Offset: 0x0002B79F
		[global::Cpp2ILInjected.Token(Token = "0x6004988")]
		[global::Cpp2ILInjected.Address(RVA = "0x830834", Offset = "0x830834", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x0002D5A2 File Offset: 0x0002B7A2
		[global::Cpp2ILInjected.Token(Token = "0x6004989")]
		[global::Cpp2ILInjected.Address(RVA = "0x83083C", Offset = "0x83083C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x0002D5A5 File Offset: 0x0002B7A5
		[global::Cpp2ILInjected.Token(Token = "0x600498A")]
		[global::Cpp2ILInjected.Address(RVA = "0x830840", Offset = "0x830840", Length = "0x728")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.NetModules.NetAmbienceModule.<>c__DisplayClass1_0", Member = "<Deserialize>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.BirdsPackSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.WyvernSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.AirshipSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.AirBalloonSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOCSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.MeteorSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.BatsGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.ButterfliesSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.LostKiteSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.VultureSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.PixiePosseSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SeagullsGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SlimeBalloonGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.GastropodGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.PegasusSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOSSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.CrimeraSkyEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky), Member = "AnActiveSkyConflictsWithAmbience", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Activate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.HellBatsGoupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public void Spawn(Player player, SkyEntityType type, int seed)
		{
			throw null;
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		[global::Cpp2ILInjected.Token(Token = "0x600498B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8349E4", Offset = "0x8349E4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlotVector<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public AmbientSky()
		{
			throw null;
		}

		// Token: 0x04006CCA RID: 27850
		[global::Cpp2ILInjected.Token(Token = "0x4008468")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _isActive;

		// Token: 0x04006CCB RID: 27851
		[global::Cpp2ILInjected.Token(Token = "0x4008469")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SlotVector<AmbientSky.SkyEntity> _entities;

		// Token: 0x04006CCC RID: 27852
		[global::Cpp2ILInjected.Token(Token = "0x400846A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _frameCounter;

		// Token: 0x02000A3A RID: 2618
		[global::Cpp2ILInjected.Token(Token = "0x20009B5")]
		private abstract class SkyEntity
		{
			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x0600501E RID: 20510 RVA: 0x0003021E File Offset: 0x0002E41E
			[global::Cpp2ILInjected.Token(Token = "0x1700084F")]
			public Rectangle SourceRectangle
			{
				[global::Cpp2ILInjected.Token(Token = "0x600498C")]
				[global::Cpp2ILInjected.Address(RVA = "0x834A64", Offset = "0x834A64", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SkyEntity), Member = "CommonDraw", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SkyEntity), Member = "Helper_GetOpacityWithAccountingForOceanWaterLine", ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = "GetSourceRectangle", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Rectangle))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600501F RID: 20511 RVA: 0x00030221 File Offset: 0x0002E421
			[global::Cpp2ILInjected.Token(Token = "0x600498D")]
			[global::Cpp2ILInjected.Address(RVA = "0x834AAC", Offset = "0x834AAC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected void NextFrame()
			{
				throw null;
			}

			// Token: 0x06005020 RID: 20512
			[global::Cpp2ILInjected.Token(Token = "0x600498E")]
			public abstract Color GetColor(Color backgroundColor);

			// Token: 0x06005021 RID: 20513
			[global::Cpp2ILInjected.Token(Token = "0x600498F")]
			public abstract void Update(int frameCount);

			// Token: 0x06005022 RID: 20514 RVA: 0x00030224 File Offset: 0x0002E424
			[global::Cpp2ILInjected.Token(Token = "0x6004990")]
			[global::Cpp2ILInjected.Address(RVA = "0x834AC8", Offset = "0x834AC8", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.ButterfliesSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.LostKiteSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PegasusSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.VultureSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PixiePosseSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BirdsPackSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.WyvernSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirshipSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			protected void SetPositionInWorldBasedOnScreenSpace(Vector2 actualWorldSpace)
			{
				throw null;
			}

			// Token: 0x06005023 RID: 20515
			[global::Cpp2ILInjected.Token(Token = "0x6004991")]
			public abstract Vector2 GetDrawPosition();

			// Token: 0x06005024 RID: 20516 RVA: 0x00030227 File Offset: 0x0002E427
			[global::Cpp2ILInjected.Token(Token = "0x6004992")]
			[global::Cpp2ILInjected.Address(RVA = "0x834BDC", Offset = "0x834BDC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

			// Token: 0x06005025 RID: 20517 RVA: 0x0003022A File Offset: 0x0002E42A
			[global::Cpp2ILInjected.Token(Token = "0x6004993")]
			[global::Cpp2ILInjected.Address(RVA = "0x834BE0", Offset = "0x834BE0", Length = "0x27C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PixiePosseSkyEntity", Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SkyEntity), Member = "GetDrawPositionByDepth", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SkyEntity), Member = "get_SourceRectangle", ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public void CommonDraw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

			// Token: 0x06005026 RID: 20518 RVA: 0x0003022D File Offset: 0x0002E42D
			[global::Cpp2ILInjected.Token(Token = "0x6004994")]
			[global::Cpp2ILInjected.Address(RVA = "0x834E5C", Offset = "0x834E5C", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SkyEntity), Member = "CommonDraw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SkyEntity), Member = "Helper_GetOpacityWithAccountingForOceanWaterLine", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal Vector2 GetDrawPositionByDepth()
			{
				throw null;
			}

			// Token: 0x06005027 RID: 20519 RVA: 0x00030230 File Offset: 0x0002E430
			[global::Cpp2ILInjected.Token(Token = "0x6004995")]
			[global::Cpp2ILInjected.Address(RVA = "0x834FA4", Offset = "0x834FA4", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SkyEntity), Member = "GetDrawPositionByDepth", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SkyEntity), Member = "get_SourceRectangle", ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal float Helper_GetOpacityWithAccountingForOceanWaterLine()
			{
				throw null;
			}

			// Token: 0x06005028 RID: 20520 RVA: 0x00030233 File Offset: 0x0002E433
			[global::Cpp2ILInjected.Token(Token = "0x6004996")]
			[global::Cpp2ILInjected.Address(RVA = "0x835120", Offset = "0x835120", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected SkyEntity()
			{
				throw null;
			}

			// Token: 0x04008DB7 RID: 36279
			[global::Cpp2ILInjected.Token(Token = "0x400846B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Vector2 Position;

			// Token: 0x04008DB8 RID: 36280
			[global::Cpp2ILInjected.Token(Token = "0x400846C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Asset<Texture2D> Texture;

			// Token: 0x04008DB9 RID: 36281
			[global::Cpp2ILInjected.Token(Token = "0x400846D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public SpriteFrame Frame;

			// Token: 0x04008DBA RID: 36282
			[global::Cpp2ILInjected.Token(Token = "0x400846E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float Depth;

			// Token: 0x04008DBB RID: 36283
			[global::Cpp2ILInjected.Token(Token = "0x400846F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public SpriteEffects Effects;

			// Token: 0x04008DBC RID: 36284
			[global::Cpp2ILInjected.Token(Token = "0x4008470")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public bool IsActive;

			// Token: 0x04008DBD RID: 36285
			[global::Cpp2ILInjected.Token(Token = "0x4008471")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float Rotation;
		}

		// Token: 0x02000A3B RID: 2619
		[global::Cpp2ILInjected.Token(Token = "0x20009B6")]
		private class FadingSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x06005029 RID: 20521 RVA: 0x00030236 File Offset: 0x0002E436
			[global::Cpp2ILInjected.Token(Token = "0x6004997")]
			[global::Cpp2ILInjected.Address(RVA = "0x835130", Offset = "0x835130", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FadingSkyEntity()
			{
				throw null;
			}

			// Token: 0x0600502A RID: 20522 RVA: 0x00030239 File Offset: 0x0002E439
			[global::Cpp2ILInjected.Token(Token = "0x6004998")]
			[global::Cpp2ILInjected.Address(RVA = "0x835170", Offset = "0x835170", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.ButterfliesSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.LostKiteSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PegasusSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.VultureSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PixiePosseSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BirdsPackSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirshipSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirBalloonSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.FadingSkyEntity), Member = "UpdateOpacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600502B RID: 20523 RVA: 0x0003023C File Offset: 0x0002E43C
			[global::Cpp2ILInjected.Token(Token = "0x6004999")]
			[global::Cpp2ILInjected.Address(RVA = "0x835374", Offset = "0x835374", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600502C RID: 20524 RVA: 0x0003023F File Offset: 0x0002E43F
			[global::Cpp2ILInjected.Token(Token = "0x600499A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8352AC", Offset = "0x8352AC", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.FadingSkyEntity), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void UpdateOpacity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600502D RID: 20525 RVA: 0x00030242 File Offset: 0x0002E442
			[global::Cpp2ILInjected.Token(Token = "0x600499B")]
			[global::Cpp2ILInjected.Address(RVA = "0x835274", Offset = "0x835274", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool IsMovementDone(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600502E RID: 20526 RVA: 0x00030245 File Offset: 0x0002E445
			[global::Cpp2ILInjected.Token(Token = "0x600499C")]
			[global::Cpp2ILInjected.Address(RVA = "0x835378", Offset = "0x835378", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.PegasusSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.VultureSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SeagullsGroupSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.CrimeraSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOSSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "Helper_GetOpacityWithAccountingForOceanWaterLine", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x0600502F RID: 20527 RVA: 0x00030248 File Offset: 0x0002E448
			[global::Cpp2ILInjected.Token(Token = "0x600499D")]
			[global::Cpp2ILInjected.Address(RVA = "0x83542C", Offset = "0x83542C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void StartFadingOut(int currentFrameCount)
			{
				throw null;
			}

			// Token: 0x06005030 RID: 20528 RVA: 0x0003024B File Offset: 0x0002E44B
			[global::Cpp2ILInjected.Token(Token = "0x600499E")]
			[global::Cpp2ILInjected.Address(RVA = "0x83546C", Offset = "0x83546C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override Vector2 GetDrawPosition()
			{
				throw null;
			}

			// Token: 0x04008DBE RID: 36286
			[global::Cpp2ILInjected.Token(Token = "0x4008472")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			protected int LifeTime;

			// Token: 0x04008DBF RID: 36287
			[global::Cpp2ILInjected.Token(Token = "0x4008473")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			protected Vector2 Velocity;

			// Token: 0x04008DC0 RID: 36288
			[global::Cpp2ILInjected.Token(Token = "0x4008474")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			protected int FramingSpeed;

			// Token: 0x04008DC1 RID: 36289
			[global::Cpp2ILInjected.Token(Token = "0x4008475")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			protected int TimeEntitySpawnedIn;

			// Token: 0x04008DC2 RID: 36290
			[global::Cpp2ILInjected.Token(Token = "0x4008476")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			protected float Opacity;

			// Token: 0x04008DC3 RID: 36291
			[global::Cpp2ILInjected.Token(Token = "0x4008477")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			protected float BrightnessLerper;

			// Token: 0x04008DC4 RID: 36292
			[global::Cpp2ILInjected.Token(Token = "0x4008478")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			protected float FinalOpacityMultiplier;

			// Token: 0x04008DC5 RID: 36293
			[global::Cpp2ILInjected.Token(Token = "0x4008479")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			protected float OpacityNormalizedTimeToFadeIn;

			// Token: 0x04008DC6 RID: 36294
			[global::Cpp2ILInjected.Token(Token = "0x400847A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			protected float OpacityNormalizedTimeToFadeOut;

			// Token: 0x04008DC7 RID: 36295
			[global::Cpp2ILInjected.Token(Token = "0x400847B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
			protected int FrameOffset;
		}

		// Token: 0x02000A3C RID: 2620
		[global::Cpp2ILInjected.Token(Token = "0x20009B7")]
		private class ButterfliesSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005031 RID: 20529 RVA: 0x0003024E File Offset: 0x0002E44E
			[global::Cpp2ILInjected.Token(Token = "0x600499F")]
			[global::Cpp2ILInjected.Address(RVA = "0x832504", Offset = "0x832504", Length = "0x31C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public ButterfliesSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005032 RID: 20530 RVA: 0x00030251 File Offset: 0x0002E451
			[global::Cpp2ILInjected.Token(Token = "0x60049A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x835474", Offset = "0x835474", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005033 RID: 20531 RVA: 0x00030254 File Offset: 0x0002E454
			[global::Cpp2ILInjected.Token(Token = "0x60049A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x835580", Offset = "0x835580", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}
		}

		// Token: 0x02000A3D RID: 2621
		[global::Cpp2ILInjected.Token(Token = "0x20009B8")]
		private class LostKiteSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005034 RID: 20532 RVA: 0x00030257 File Offset: 0x0002E457
			[global::Cpp2ILInjected.Token(Token = "0x60049A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x832820", Offset = "0x832820", Length = "0x318")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public LostKiteSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005035 RID: 20533 RVA: 0x0003025A File Offset: 0x0002E45A
			[global::Cpp2ILInjected.Token(Token = "0x60049A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x83566C", Offset = "0x83566C", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005036 RID: 20534 RVA: 0x0003025D File Offset: 0x0002E45D
			[global::Cpp2ILInjected.Token(Token = "0x60049A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8357C8", Offset = "0x8357C8", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override void Update(int frameCount)
			{
				throw null;
			}
		}

		// Token: 0x02000A3E RID: 2622
		[global::Cpp2ILInjected.Token(Token = "0x20009B9")]
		private class PegasusSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005037 RID: 20535 RVA: 0x00030260 File Offset: 0x0002E460
			[global::Cpp2ILInjected.Token(Token = "0x60049A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x833F20", Offset = "0x833F20", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public PegasusSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005038 RID: 20536 RVA: 0x00030263 File Offset: 0x0002E463
			[global::Cpp2ILInjected.Token(Token = "0x60049A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x835944", Offset = "0x835944", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005039 RID: 20537 RVA: 0x00030266 File Offset: 0x0002E466
			[global::Cpp2ILInjected.Token(Token = "0x60049A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x835A4C", Offset = "0x835A4C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600503A RID: 20538 RVA: 0x00030269 File Offset: 0x0002E469
			[global::Cpp2ILInjected.Token(Token = "0x60049A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x835B38", Offset = "0x835B38", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}
		}

		// Token: 0x02000A3F RID: 2623
		[global::Cpp2ILInjected.Token(Token = "0x20009BA")]
		private class VultureSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600503B RID: 20539 RVA: 0x0003026C File Offset: 0x0002E46C
			[global::Cpp2ILInjected.Token(Token = "0x60049A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x832B38", Offset = "0x832B38", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public VultureSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x0600503C RID: 20540 RVA: 0x0003026F File Offset: 0x0002E46F
			[global::Cpp2ILInjected.Token(Token = "0x60049AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x835BF8", Offset = "0x835BF8", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600503D RID: 20541 RVA: 0x00030272 File Offset: 0x0002E472
			[global::Cpp2ILInjected.Token(Token = "0x60049AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x835D00", Offset = "0x835D00", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600503E RID: 20542 RVA: 0x00030275 File Offset: 0x0002E475
			[global::Cpp2ILInjected.Token(Token = "0x60049AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x835DEC", Offset = "0x835DEC", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}
		}

		// Token: 0x02000A40 RID: 2624
		[global::Cpp2ILInjected.Token(Token = "0x20009BB")]
		private class PixiePosseSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600503F RID: 20543 RVA: 0x00030278 File Offset: 0x0002E478
			[global::Cpp2ILInjected.Token(Token = "0x60049AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x832E14", Offset = "0x832E14", Length = "0x328")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public PixiePosseSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005040 RID: 20544 RVA: 0x0003027B File Offset: 0x0002E47B
			[global::Cpp2ILInjected.Token(Token = "0x60049AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x835EF0", Offset = "0x835EF0", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005041 RID: 20545 RVA: 0x0003027E File Offset: 0x0002E47E
			[global::Cpp2ILInjected.Token(Token = "0x60049AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x835FFC", Offset = "0x835FFC", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005042 RID: 20546 RVA: 0x00030281 File Offset: 0x0002E481
			[global::Cpp2ILInjected.Token(Token = "0x60049B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x83616C", Offset = "0x83616C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "CommonDraw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

			// Token: 0x04008DC8 RID: 36296
			[global::Cpp2ILInjected.Token(Token = "0x400847C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private int pixieType;
		}

		// Token: 0x02000A41 RID: 2625
		[global::Cpp2ILInjected.Token(Token = "0x20009BC")]
		private class BirdsPackSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005043 RID: 20547 RVA: 0x00030284 File Offset: 0x0002E484
			[global::Cpp2ILInjected.Token(Token = "0x60049B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x831524", Offset = "0x831524", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public BirdsPackSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005044 RID: 20548 RVA: 0x00030287 File Offset: 0x0002E487
			[global::Cpp2ILInjected.Token(Token = "0x60049B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x83617C", Offset = "0x83617C", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005045 RID: 20549 RVA: 0x0003028A File Offset: 0x0002E48A
			[global::Cpp2ILInjected.Token(Token = "0x60049B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x836284", Offset = "0x836284", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}
		}

		// Token: 0x02000A42 RID: 2626
		[global::Cpp2ILInjected.Token(Token = "0x20009BD")]
		private class SeagullsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005046 RID: 20550 RVA: 0x0003028D File Offset: 0x0002E48D
			[global::Cpp2ILInjected.Token(Token = "0x60049B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x836370", Offset = "0x836370", Length = "0x330")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SeagullsGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.SeagullsGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public SeagullsGroupSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005047 RID: 20551 RVA: 0x00030290 File Offset: 0x0002E490
			[global::Cpp2ILInjected.Token(Token = "0x60049B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8366A0", Offset = "0x8366A0", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005048 RID: 20552 RVA: 0x00030293 File Offset: 0x0002E493
			[global::Cpp2ILInjected.Token(Token = "0x60049B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x836814", Offset = "0x836814", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005049 RID: 20553 RVA: 0x00030296 File Offset: 0x0002E496
			[global::Cpp2ILInjected.Token(Token = "0x60049B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x836900", Offset = "0x836900", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

			// Token: 0x0600504A RID: 20554 RVA: 0x00030299 File Offset: 0x0002E499
			[global::Cpp2ILInjected.Token(Token = "0x60049B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x83690C", Offset = "0x83690C", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x0600504B RID: 20555 RVA: 0x0003029C File Offset: 0x0002E49C
			[global::Cpp2ILInjected.Token(Token = "0x60049B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8369CC", Offset = "0x8369CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "CommonDraw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

			// Token: 0x0600504C RID: 20556 RVA: 0x0003029F File Offset: 0x0002E49F
			[global::Cpp2ILInjected.Token(Token = "0x60049BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x83313C", Offset = "0x83313C", Length = "0x4A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SeagullsGroupSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public static List<AmbientSky.SeagullsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x04008DC9 RID: 36297
			[global::Cpp2ILInjected.Token(Token = "0x400847D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04008DCA RID: 36298
			[global::Cpp2ILInjected.Token(Token = "0x400847E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04008DCB RID: 36299
			[global::Cpp2ILInjected.Token(Token = "0x400847F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04008DCC RID: 36300
			[global::Cpp2ILInjected.Token(Token = "0x4008480")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000A43 RID: 2627
		[global::Cpp2ILInjected.Token(Token = "0x20009BE")]
		private class GastropodGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600504D RID: 20557 RVA: 0x000302A2 File Offset: 0x0002E4A2
			[global::Cpp2ILInjected.Token(Token = "0x60049BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8369D8", Offset = "0x8369D8", Length = "0x2E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.GastropodGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.GastropodGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public GastropodGroupSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x0600504E RID: 20558 RVA: 0x000302A5 File Offset: 0x0002E4A5
			[global::Cpp2ILInjected.Token(Token = "0x60049BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x836CB8", Offset = "0x836CB8", Length = "0x200")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600504F RID: 20559 RVA: 0x000302A8 File Offset: 0x0002E4A8
			[global::Cpp2ILInjected.Token(Token = "0x60049BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x836EB8", Offset = "0x836EB8", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005050 RID: 20560 RVA: 0x000302AB File Offset: 0x0002E4AB
			[global::Cpp2ILInjected.Token(Token = "0x60049BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x836FDC", Offset = "0x836FDC", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x06005051 RID: 20561 RVA: 0x000302AE File Offset: 0x0002E4AE
			[global::Cpp2ILInjected.Token(Token = "0x60049BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x8370AC", Offset = "0x8370AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "CommonDraw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

			// Token: 0x06005052 RID: 20562 RVA: 0x000302B1 File Offset: 0x0002E4B1
			[global::Cpp2ILInjected.Token(Token = "0x60049C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8370BC", Offset = "0x8370BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

			// Token: 0x06005053 RID: 20563 RVA: 0x000302B4 File Offset: 0x0002E4B4
			[global::Cpp2ILInjected.Token(Token = "0x60049C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x833A80", Offset = "0x833A80", Length = "0x4A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.GastropodGroupSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public static List<AmbientSky.GastropodGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x04008DCD RID: 36301
			[global::Cpp2ILInjected.Token(Token = "0x4008481")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04008DCE RID: 36302
			[global::Cpp2ILInjected.Token(Token = "0x4008482")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04008DCF RID: 36303
			[global::Cpp2ILInjected.Token(Token = "0x4008483")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04008DD0 RID: 36304
			[global::Cpp2ILInjected.Token(Token = "0x4008484")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000A44 RID: 2628
		[global::Cpp2ILInjected.Token(Token = "0x20009BF")]
		private class SlimeBalloonGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005054 RID: 20564 RVA: 0x000302B7 File Offset: 0x0002E4B7
			[global::Cpp2ILInjected.Token(Token = "0x60049C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8370C8", Offset = "0x8370C8", Length = "0x2F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.SlimeBalloonGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.SlimeBalloonGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public SlimeBalloonGroupSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005055 RID: 20565 RVA: 0x000302BA File Offset: 0x0002E4BA
			[global::Cpp2ILInjected.Token(Token = "0x60049C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8373B8", Offset = "0x8373B8", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005056 RID: 20566 RVA: 0x000302BD File Offset: 0x0002E4BD
			[global::Cpp2ILInjected.Token(Token = "0x60049C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8375AC", Offset = "0x8375AC", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005057 RID: 20567 RVA: 0x000302C0 File Offset: 0x0002E4C0
			[global::Cpp2ILInjected.Token(Token = "0x60049C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x837738", Offset = "0x837738", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

			// Token: 0x06005058 RID: 20568 RVA: 0x000302C3 File Offset: 0x0002E4C3
			[global::Cpp2ILInjected.Token(Token = "0x60049C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x8335E4", Offset = "0x8335E4", Length = "0x49C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.SlimeBalloonGroupSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public static List<AmbientSky.SlimeBalloonGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x04008DD1 RID: 36305
			[global::Cpp2ILInjected.Token(Token = "0x4008485")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04008DD2 RID: 36306
			[global::Cpp2ILInjected.Token(Token = "0x4008486")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04008DD3 RID: 36307
			[global::Cpp2ILInjected.Token(Token = "0x4008487")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04008DD4 RID: 36308
			[global::Cpp2ILInjected.Token(Token = "0x4008488")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000A45 RID: 2629
		[global::Cpp2ILInjected.Token(Token = "0x20009C0")]
		private class HellBatsGoupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005059 RID: 20569 RVA: 0x000302C6 File Offset: 0x0002E4C6
			[global::Cpp2ILInjected.Token(Token = "0x60049C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x837744", Offset = "0x837744", Length = "0x350")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.HellBatsGoupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.HellBatsGoupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public HellBatsGoupSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x0600505A RID: 20570 RVA: 0x000302C9 File Offset: 0x0002E4C9
			[global::Cpp2ILInjected.Token(Token = "0x60049C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x837A94", Offset = "0x837A94", Length = "0x1F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600505B RID: 20571 RVA: 0x000302CC File Offset: 0x0002E4CC
			[global::Cpp2ILInjected.Token(Token = "0x60049C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x837C84", Offset = "0x837C84", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600505C RID: 20572 RVA: 0x000302CF File Offset: 0x0002E4CF
			[global::Cpp2ILInjected.Token(Token = "0x60049CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x837C88", Offset = "0x837C88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

			// Token: 0x0600505D RID: 20573 RVA: 0x000302D2 File Offset: 0x0002E4D2
			[global::Cpp2ILInjected.Token(Token = "0x60049CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x837C94", Offset = "0x837C94", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.HellBatsGoupSkyEntity), Member = "Helper_GetOpacityWithAccountingForBackgroundsOff", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x0600505E RID: 20574 RVA: 0x000302D5 File Offset: 0x0002E4D5
			[global::Cpp2ILInjected.Token(Token = "0x60049CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x834554", Offset = "0x834554", Length = "0x490")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_UnderworldLayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.HellBatsGoupSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public static List<AmbientSky.HellBatsGoupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x0600505F RID: 20575 RVA: 0x000302D8 File Offset: 0x0002E4D8
			[global::Cpp2ILInjected.Token(Token = "0x60049CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x837D40", Offset = "0x837D40", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.HellBatsGoupSkyEntity), Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_BackgroundEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float Helper_GetOpacityWithAccountingForBackgroundsOff()
			{
				throw null;
			}

			// Token: 0x04008DD5 RID: 36309
			[global::Cpp2ILInjected.Token(Token = "0x4008489")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04008DD6 RID: 36310
			[global::Cpp2ILInjected.Token(Token = "0x400848A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04008DD7 RID: 36311
			[global::Cpp2ILInjected.Token(Token = "0x400848B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04008DD8 RID: 36312
			[global::Cpp2ILInjected.Token(Token = "0x400848C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000A46 RID: 2630
		[global::Cpp2ILInjected.Token(Token = "0x20009C1")]
		private class BatsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005060 RID: 20576 RVA: 0x000302DB File Offset: 0x0002E4DB
			[global::Cpp2ILInjected.Token(Token = "0x60049CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x837DCC", Offset = "0x837DCC", Length = "0x36C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.BatsGroupSkyEntity), Member = "CreateGroup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(List<AmbientSky.BatsGroupSkyEntity>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public BatsGroupSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x000302DE File Offset: 0x0002E4DE
			[global::Cpp2ILInjected.Token(Token = "0x60049CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x838138", Offset = "0x838138", Length = "0x1F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005062 RID: 20578 RVA: 0x000302E1 File Offset: 0x0002E4E1
			[global::Cpp2ILInjected.Token(Token = "0x60049D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x838328", Offset = "0x838328", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005063 RID: 20579 RVA: 0x000302E4 File Offset: 0x0002E4E4
			[global::Cpp2ILInjected.Token(Token = "0x60049D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x838414", Offset = "0x838414", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

			// Token: 0x06005064 RID: 20580 RVA: 0x000302E7 File Offset: 0x0002E4E7
			[global::Cpp2ILInjected.Token(Token = "0x60049D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x838420", Offset = "0x838420", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Max", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[] { typeof(float[]) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x06005065 RID: 20581 RVA: 0x000302EA File Offset: 0x0002E4EA
			[global::Cpp2ILInjected.Token(Token = "0x60049D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x83205C", Offset = "0x83205C", Length = "0x4A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.BatsGroupSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public static List<AmbientSky.BatsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x04008DD9 RID: 36313
			[global::Cpp2ILInjected.Token(Token = "0x400848D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			// Token: 0x04008DDA RID: 36314
			[global::Cpp2ILInjected.Token(Token = "0x400848E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			// Token: 0x04008DDB RID: 36315
			[global::Cpp2ILInjected.Token(Token = "0x400848F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			// Token: 0x04008DDC RID: 36316
			[global::Cpp2ILInjected.Token(Token = "0x4008490")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		// Token: 0x02000A47 RID: 2631
		[global::Cpp2ILInjected.Token(Token = "0x20009C2")]
		private class WyvernSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005066 RID: 20582 RVA: 0x000302ED File Offset: 0x0002E4ED
			[global::Cpp2ILInjected.Token(Token = "0x60049D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x831D80", Offset = "0x831D80", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public WyvernSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005067 RID: 20583 RVA: 0x000302F0 File Offset: 0x0002E4F0
			[global::Cpp2ILInjected.Token(Token = "0x60049D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x838590", Offset = "0x838590", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}
		}

		// Token: 0x02000A48 RID: 2632
		[global::Cpp2ILInjected.Token(Token = "0x20009C3")]
		private class NormalizedBackgroundLayerSpaceSkyEntity : AmbientSky.SkyEntity
		{
			// Token: 0x06005068 RID: 20584 RVA: 0x000302F3 File Offset: 0x0002E4F3
			[global::Cpp2ILInjected.Token(Token = "0x60049D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x838698", Offset = "0x838698", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}

			// Token: 0x06005069 RID: 20585 RVA: 0x000302F6 File Offset: 0x0002E4F6
			[global::Cpp2ILInjected.Token(Token = "0x60049D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x83870C", Offset = "0x83870C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override Vector2 GetDrawPosition()
			{
				throw null;
			}

			// Token: 0x0600506A RID: 20586 RVA: 0x000302F9 File Offset: 0x0002E4F9
			[global::Cpp2ILInjected.Token(Token = "0x60049D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x838714", Offset = "0x838714", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600506B RID: 20587 RVA: 0x000302FC File Offset: 0x0002E4FC
			[global::Cpp2ILInjected.Token(Token = "0x60049D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x838718", Offset = "0x838718", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NormalizedBackgroundLayerSpaceSkyEntity()
			{
				throw null;
			}
		}

		// Token: 0x02000A49 RID: 2633
		[global::Cpp2ILInjected.Token(Token = "0x20009C4")]
		private class BoneSerpentSkyEntity : AmbientSky.NormalizedBackgroundLayerSpaceSkyEntity
		{
			// Token: 0x0600506C RID: 20588 RVA: 0x000302FF File Offset: 0x0002E4FF
			[global::Cpp2ILInjected.Token(Token = "0x60049DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x838728", Offset = "0x838728", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BoneSerpentSkyEntity()
			{
				throw null;
			}
		}

		// Token: 0x02000A4A RID: 2634
		[global::Cpp2ILInjected.Token(Token = "0x20009C5")]
		private class AirshipSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600506D RID: 20589 RVA: 0x00030302 File Offset: 0x0002E502
			[global::Cpp2ILInjected.Token(Token = "0x60049DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x831284", Offset = "0x831284", Length = "0x2A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public AirshipSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x0600506E RID: 20590 RVA: 0x00030305 File Offset: 0x0002E505
			[global::Cpp2ILInjected.Token(Token = "0x60049DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x838738", Offset = "0x838738", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x00030308 File Offset: 0x0002E508
			[global::Cpp2ILInjected.Token(Token = "0x60049DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x838840", Offset = "0x838840", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}
		}

		// Token: 0x02000A4B RID: 2635
		[global::Cpp2ILInjected.Token(Token = "0x20009C6")]
		private class AirBalloonSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005070 RID: 20592 RVA: 0x0003030B File Offset: 0x0002E50B
			[global::Cpp2ILInjected.Token(Token = "0x60049DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x830F68", Offset = "0x830F68", Length = "0x31C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public AirBalloonSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005071 RID: 20593 RVA: 0x0003030E File Offset: 0x0002E50E
			[global::Cpp2ILInjected.Token(Token = "0x60049DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x83892C", Offset = "0x83892C", Length = "0x1EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x06005072 RID: 20594 RVA: 0x00030311 File Offset: 0x0002E511
			[global::Cpp2ILInjected.Token(Token = "0x60049E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x838B18", Offset = "0x838B18", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			// Token: 0x04008DDD RID: 36317
			[global::Cpp2ILInjected.Token(Token = "0x4008491")]
			private const int RANDOM_TILE_SPAWN_RANGE = 100;
		}

		// Token: 0x02000A4C RID: 2636
		[global::Cpp2ILInjected.Token(Token = "0x20009C7")]
		private class CrimeraSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x06005073 RID: 20595 RVA: 0x00030314 File Offset: 0x0002E514
			[global::Cpp2ILInjected.Token(Token = "0x60049E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x8343A8", Offset = "0x8343A8", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public CrimeraSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005074 RID: 20596 RVA: 0x00030317 File Offset: 0x0002E517
			[global::Cpp2ILInjected.Token(Token = "0x60049E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x838C04", Offset = "0x838C04", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}
		}

		// Token: 0x02000A4D RID: 2637
		[global::Cpp2ILInjected.Token(Token = "0x20009C8")]
		private class EOSSkyEntity : AmbientSky.EOCSkyEntity
		{
			// Token: 0x06005075 RID: 20597 RVA: 0x0003031A File Offset: 0x0002E51A
			[global::Cpp2ILInjected.Token(Token = "0x60049E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8341FC", Offset = "0x8341FC", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public EOSSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005076 RID: 20598 RVA: 0x0003031D File Offset: 0x0002E51D
			[global::Cpp2ILInjected.Token(Token = "0x60049E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x838CC4", Offset = "0x838CC4", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "GetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgAlphaFrontLayer", ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override Color GetColor(Color backgroundColor)
			{
				throw null;
			}
		}

		// Token: 0x02000A4E RID: 2638
		[global::Cpp2ILInjected.Token(Token = "0x20009C9")]
		private class EOCSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x06005077 RID: 20599 RVA: 0x00030320 File Offset: 0x0002E520
			[global::Cpp2ILInjected.Token(Token = "0x60049E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x831800", Offset = "0x831800", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.CrimeraSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOSSkyEntity", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOCSkyEntity), Member = "BeginZigZag", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOCSkyEntity), Member = "BeginChasingPlayer", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "SetPositionInWorldBasedOnScreenSpace", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public EOCSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x00030323 File Offset: 0x0002E523
			[global::Cpp2ILInjected.Token(Token = "0x60049E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x838D84", Offset = "0x838D84", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.EOCSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			private void BeginZigZag(ref FastRandom random, VirtualCamera camera, int direction)
			{
				throw null;
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x00030326 File Offset: 0x0002E526
			[global::Cpp2ILInjected.Token(Token = "0x60049E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x838E50", Offset = "0x838E50", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.EOCSkyEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(FastRandom)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void BeginChasingPlayer(ref FastRandom random, VirtualCamera camera)
			{
				throw null;
			}

			// Token: 0x0600507A RID: 20602 RVA: 0x00030329 File Offset: 0x0002E529
			[global::Cpp2ILInjected.Token(Token = "0x60049E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x838F84", Offset = "0x838F84", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOCSkyEntity), Member = "ZigzagMove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky.EOCSkyEntity), Member = "ChasePlayerTop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void UpdateVelocity(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600507B RID: 20603 RVA: 0x0003032C File Offset: 0x0002E52C
			[global::Cpp2ILInjected.Token(Token = "0x60049E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x839024", Offset = "0x839024", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.EOCSkyEntity), Member = "UpdateVelocity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void ZigzagMove(int frameCount)
			{
				throw null;
			}

			// Token: 0x0600507C RID: 20604 RVA: 0x0003032F File Offset: 0x0002E52F
			[global::Cpp2ILInjected.Token(Token = "0x60049EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8390D8", Offset = "0x8390D8", Length = "0x1CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky.EOCSkyEntity), Member = "UpdateVelocity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void ChasePlayerTop(int frameCount)
			{
				throw null;
			}

			// Token: 0x04008DDE RID: 36318
			[global::Cpp2ILInjected.Token(Token = "0x4008492")]
			private const int STATE_ZIGZAG = 1;

			// Token: 0x04008DDF RID: 36319
			[global::Cpp2ILInjected.Token(Token = "0x4008493")]
			private const int STATE_GOOVERPLAYER = 2;

			// Token: 0x04008DE0 RID: 36320
			[global::Cpp2ILInjected.Token(Token = "0x4008494")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private int _state;

			// Token: 0x04008DE1 RID: 36321
			[global::Cpp2ILInjected.Token(Token = "0x4008495")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			private int _direction;

			// Token: 0x04008DE2 RID: 36322
			[global::Cpp2ILInjected.Token(Token = "0x4008496")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private float _waviness;
		}

		// Token: 0x02000A4F RID: 2639
		[global::Cpp2ILInjected.Token(Token = "0x20009CA")]
		private class MeteorSkyEntity : AmbientSky.FadingSkyEntity
		{
			// Token: 0x0600507D RID: 20605 RVA: 0x00030332 File Offset: 0x0002E532
			[global::Cpp2ILInjected.Token(Token = "0x60049EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x831A0C", Offset = "0x831A0C", Length = "0x374")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AmbientSky), Member = "Spawn", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SkyEntityType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "NextFloat", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FastRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public MeteorSkyEntity(Player player, FastRandom random)
			{
				throw null;
			}
		}

		// Token: 0x02000A50 RID: 2640
		// (Invoke) Token: 0x0600507F RID: 20607
		[global::Cpp2ILInjected.Token(Token = "0x20009CB")]
		private delegate AmbientSky.SkyEntity EntityFactoryMethod(Player player, int seed);
	}
}
