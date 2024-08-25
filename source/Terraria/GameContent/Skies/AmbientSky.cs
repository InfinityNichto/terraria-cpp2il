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
	[global::Cpp2ILInjected.Token(Token = "0x20009B4")]
	public class AmbientSky : CustomSky
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004983")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FD30", Offset = "0x82FD30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004984")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FD3C", Offset = "0x82FD3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6004988")]
		[global::Cpp2ILInjected.Address(RVA = "0x830834", Offset = "0x830834", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004989")]
		[global::Cpp2ILInjected.Address(RVA = "0x83083C", Offset = "0x83083C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4008468")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _isActive;

		[global::Cpp2ILInjected.Token(Token = "0x4008469")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SlotVector<AmbientSky.SkyEntity> _entities;

		[global::Cpp2ILInjected.Token(Token = "0x400846A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _frameCounter;

		[global::Cpp2ILInjected.Token(Token = "0x20009B5")]
		private abstract class SkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600498D")]
			[global::Cpp2ILInjected.Address(RVA = "0x834AAC", Offset = "0x834AAC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected void NextFrame()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600498E")]
			public abstract Color GetColor(Color backgroundColor);

			[global::Cpp2ILInjected.Token(Token = "0x600498F")]
			public abstract void Update(int frameCount);

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

			[global::Cpp2ILInjected.Token(Token = "0x6004991")]
			public abstract Vector2 GetDrawPosition();

			[global::Cpp2ILInjected.Token(Token = "0x6004992")]
			[global::Cpp2ILInjected.Address(RVA = "0x834BDC", Offset = "0x834BDC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6004996")]
			[global::Cpp2ILInjected.Address(RVA = "0x835120", Offset = "0x835120", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected SkyEntity()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400846B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Vector2 Position;

			[global::Cpp2ILInjected.Token(Token = "0x400846C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Asset<Texture2D> Texture;

			[global::Cpp2ILInjected.Token(Token = "0x400846D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public SpriteFrame Frame;

			[global::Cpp2ILInjected.Token(Token = "0x400846E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public float Depth;

			[global::Cpp2ILInjected.Token(Token = "0x400846F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public SpriteEffects Effects;

			[global::Cpp2ILInjected.Token(Token = "0x4008470")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public bool IsActive;

			[global::Cpp2ILInjected.Token(Token = "0x4008471")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float Rotation;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009B6")]
		private class FadingSkyEntity : AmbientSky.SkyEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004997")]
			[global::Cpp2ILInjected.Address(RVA = "0x835130", Offset = "0x835130", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public FadingSkyEntity()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6004999")]
			[global::Cpp2ILInjected.Address(RVA = "0x835374", Offset = "0x835374", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual void UpdateVelocity(int frameCount)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x600499B")]
			[global::Cpp2ILInjected.Address(RVA = "0x835274", Offset = "0x835274", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool IsMovementDone(int frameCount)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x600499D")]
			[global::Cpp2ILInjected.Address(RVA = "0x83542C", Offset = "0x83542C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void StartFadingOut(int currentFrameCount)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600499E")]
			[global::Cpp2ILInjected.Address(RVA = "0x83546C", Offset = "0x83546C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override Vector2 GetDrawPosition()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008472")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			protected int LifeTime;

			[global::Cpp2ILInjected.Token(Token = "0x4008473")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			protected Vector2 Velocity;

			[global::Cpp2ILInjected.Token(Token = "0x4008474")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			protected int FramingSpeed;

			[global::Cpp2ILInjected.Token(Token = "0x4008475")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			protected int TimeEntitySpawnedIn;

			[global::Cpp2ILInjected.Token(Token = "0x4008476")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			protected float Opacity;

			[global::Cpp2ILInjected.Token(Token = "0x4008477")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			protected float BrightnessLerper;

			[global::Cpp2ILInjected.Token(Token = "0x4008478")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			protected float FinalOpacityMultiplier;

			[global::Cpp2ILInjected.Token(Token = "0x4008479")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			protected float OpacityNormalizedTimeToFadeIn;

			[global::Cpp2ILInjected.Token(Token = "0x400847A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			protected float OpacityNormalizedTimeToFadeOut;

			[global::Cpp2ILInjected.Token(Token = "0x400847B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
			protected int FrameOffset;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009B7")]
		private class ButterfliesSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009B8")]
		private class LostKiteSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009B9")]
		private class PegasusSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009BA")]
		private class VultureSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009BB")]
		private class PixiePosseSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x400847C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private int pixieType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009BC")]
		private class BirdsPackSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009BD")]
		private class SeagullsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x836900", Offset = "0x836900", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400847D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			[global::Cpp2ILInjected.Token(Token = "0x400847E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			[global::Cpp2ILInjected.Token(Token = "0x400847F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			[global::Cpp2ILInjected.Token(Token = "0x4008480")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009BE")]
		private class GastropodGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x8370BC", Offset = "0x8370BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4008481")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			[global::Cpp2ILInjected.Token(Token = "0x4008482")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			[global::Cpp2ILInjected.Token(Token = "0x4008483")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			[global::Cpp2ILInjected.Token(Token = "0x4008484")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009BF")]
		private class SlimeBalloonGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x837738", Offset = "0x837738", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4008485")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			[global::Cpp2ILInjected.Token(Token = "0x4008486")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			[global::Cpp2ILInjected.Token(Token = "0x4008487")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			[global::Cpp2ILInjected.Token(Token = "0x4008488")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C0")]
		private class HellBatsGoupSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x837C84", Offset = "0x837C84", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.GameContent.Skies.AmbientSky.FadingSkyEntity", Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			public override void Update(int frameCount)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60049CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x837C88", Offset = "0x837C88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4008489")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			[global::Cpp2ILInjected.Token(Token = "0x400848A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			[global::Cpp2ILInjected.Token(Token = "0x400848B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			[global::Cpp2ILInjected.Token(Token = "0x400848C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C1")]
		private class BatsGroupSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x838414", Offset = "0x838414", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400848D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private Vector2 _magnetAccelerations;

			[global::Cpp2ILInjected.Token(Token = "0x400848E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private Vector2 _magnetPointTarget;

			[global::Cpp2ILInjected.Token(Token = "0x400848F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			private Vector2 _positionVsMagnet;

			[global::Cpp2ILInjected.Token(Token = "0x4008490")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private Vector2 _velocityVsMagnet;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C2")]
		private class WyvernSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009C3")]
		private class NormalizedBackgroundLayerSpaceSkyEntity : AmbientSky.SkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60049D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x83870C", Offset = "0x83870C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override Vector2 GetDrawPosition()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60049D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x838714", Offset = "0x838714", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Update(int frameCount)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60049D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x838718", Offset = "0x838718", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NormalizedBackgroundLayerSpaceSkyEntity()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C4")]
		private class BoneSerpentSkyEntity : AmbientSky.NormalizedBackgroundLayerSpaceSkyEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60049DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x838728", Offset = "0x838728", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BoneSerpentSkyEntity()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C5")]
		private class AirshipSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009C6")]
		private class AirBalloonSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4008491")]
			private const int RANDOM_TILE_SPAWN_RANGE = 100;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009C7")]
		private class CrimeraSkyEntity : AmbientSky.EOCSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009C8")]
		private class EOSSkyEntity : AmbientSky.EOCSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009C9")]
		private class EOCSkyEntity : AmbientSky.FadingSkyEntity
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4008492")]
			private const int STATE_ZIGZAG = 1;

			[global::Cpp2ILInjected.Token(Token = "0x4008493")]
			private const int STATE_GOOVERPLAYER = 2;

			[global::Cpp2ILInjected.Token(Token = "0x4008494")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private int _state;

			[global::Cpp2ILInjected.Token(Token = "0x4008495")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			private int _direction;

			[global::Cpp2ILInjected.Token(Token = "0x4008496")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private float _waviness;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009CA")]
		private class MeteorSkyEntity : AmbientSky.FadingSkyEntity
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x20009CB")]
		private delegate AmbientSky.SkyEntity EntityFactoryMethod(Player player, int seed);
	}
}
