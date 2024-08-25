using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Map;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000677")]
	public struct SpriteFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x170006AA")]
		public byte CurrentColumn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003739")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3B4", Offset = "0x141E3B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600373A")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3BC", Offset = "0x141E3BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006AB")]
		public byte CurrentRow
		{
			[global::Cpp2ILInjected.Token(Token = "0x600373B")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3C4", Offset = "0x141E3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600373C")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3CC", Offset = "0x141E3CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600373D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3D4", Offset = "0x141E3D4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "set_numFrames", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PingMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.GastropodGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SlimeBalloonGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.HellBatsGoupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.BatsGroupSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.AirBalloonSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.EOCSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.MeteorSkyEntity", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(FastRandom)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		public SpriteFrame(byte columns, byte rows)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600373E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3EC", Offset = "0x141E3EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600373F")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E408", Offset = "0x141E408", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SpriteFrame With(byte columnToUse, byte rowToUse)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003740")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E428", Offset = "0x141E428", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawGoreBehind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawGore", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_Width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_Height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_AABBRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(SpriteFrame),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteFrame),
			typeof(float),
			typeof(float),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "get_SourceRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Rectangle GetSourceRectangle(Texture2D texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400782C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int PaddingX;

		[global::Cpp2ILInjected.Token(Token = "0x400782D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int PaddingY;

		[global::Cpp2ILInjected.Token(Token = "0x400782E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private byte _currentColumn;

		[global::Cpp2ILInjected.Token(Token = "0x400782F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		private byte _currentRow;

		[global::Cpp2ILInjected.Token(Token = "0x4007830")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public readonly byte ColumnCount;

		[global::Cpp2ILInjected.Token(Token = "0x4007831")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB")]
		public readonly byte RowCount;
	}
}
