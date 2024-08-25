using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Skies;
using Terraria.Utilities;

namespace Terraria.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000744")]
	public struct VirtualCamera
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x149F96C", Offset = "0x149F96C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public VirtualCamera(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077C")]
		public Vector2 Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D48")]
			[global::Cpp2ILInjected.Address(RVA = "0x149F974", Offset = "0x149F974", Length = "0xA8")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginZigZag", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginChasingPlayer", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077D")]
		public Vector2 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FA28", Offset = "0x149FA28", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualCamera), Member = "get_Position", ReturnType = typeof(Vector2))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginZigZag", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = "BeginChasingPlayer", MemberParameters = new object[]
			{
				typeof(ref FastRandom),
				typeof(VirtualCamera)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077E")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FA1C", Offset = "0x149FA1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007C28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Player Player;
	}
}
