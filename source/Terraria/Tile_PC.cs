using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000462")]
	public class Tile_PC
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179A8C", Offset = "0x1179A8C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Tile_PC()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179AB8", Offset = "0x1179AB8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Tile_PC(Tile_PC copy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179B50", Offset = "0x1179B50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179B58", Offset = "0x1179B58", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearEverything()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179B70", Offset = "0x1179B70", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearTile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179BF0", Offset = "0x1179BF0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader2", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader3", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		public void CopyFrom(Tile from)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005F9")]
		public int collisionType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1179C78", Offset = "0x1179C78", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179D68", Offset = "0x1179D68", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_bTileHeader", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool isTheSameAs(Tile compTile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179EE8", Offset = "0x1179EE8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int blockType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179F0C", Offset = "0x1179F0C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void liquidType(int liquidType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179F90", Offset = "0x1179F90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte liquidType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179F9C", Offset = "0x1179F9C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool nactive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179FB0", Offset = "0x1179FB0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetToType(ushort type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179FCC", Offset = "0x1179FCC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ClearMetadata()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179FE0", Offset = "0x1179FE0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Color actColor(Color oldColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A074", Offset = "0x117A074", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void actColor(ref Vector3 oldColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A10C", Offset = "0x117A10C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool topSlope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A128", Offset = "0x117A128", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool bottomSlope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A144", Offset = "0x117A144", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool leftSlope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A164", Offset = "0x117A164", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool rightSlope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A180", Offset = "0x117A180", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		public bool HasSameSlope(Tile tile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179ECC", Offset = "0x1179ECC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte wallColor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A1B4", Offset = "0x117A1B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wallColor(byte wallColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A1C8", Offset = "0x117A1C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool lava()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179F50", Offset = "0x1179F50", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void lava(bool lava)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A1D4", Offset = "0x117A1D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool honey()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179F70", Offset = "0x1179F70", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void honey(bool honey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179ED8", Offset = "0x1179ED8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool wire4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B08")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A1E0", Offset = "0x117A1E0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wire4(bool wire4)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B09")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A1FC", Offset = "0x117A1FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int wallFrameX()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A210", Offset = "0x117A210", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wallFrameX(int wallFrameX)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A238", Offset = "0x117A238", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte frameNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A244", Offset = "0x117A244", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void frameNumber(byte frameNumber)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A25C", Offset = "0x117A25C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte wallFrameNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A268", Offset = "0x117A268", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wallFrameNumber(byte wallFrameNumber)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A278", Offset = "0x117A278", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int wallFrameY()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A28C", Offset = "0x117A28C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wallFrameY(int wallFrameY)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A2B4", Offset = "0x117A2B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool checkingLiquid()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A2C0", Offset = "0x117A2C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void checkingLiquid(bool checkingLiquid)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A2DC", Offset = "0x117A2DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool skipLiquid()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A2E8", Offset = "0x117A2E8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void skipLiquid(bool skipLiquid)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A304", Offset = "0x117A304", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte color()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A310", Offset = "0x117A310", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void color(byte color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179D44", Offset = "0x1179D44", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool active()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179BB8", Offset = "0x1179BB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void active(bool active)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A068", Offset = "0x117A068", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool inActive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179BD4", Offset = "0x1179BD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void inActive(bool inActive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A328", Offset = "0x117A328", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool wire()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A334", Offset = "0x117A334", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wire(bool wire)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A350", Offset = "0x117A350", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool wire2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A35C", Offset = "0x117A35C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wire2(bool wire2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A378", Offset = "0x117A378", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool wire3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A384", Offset = "0x117A384", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void wire3(bool wire3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179D50", Offset = "0x1179D50", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool halfBrick()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179B9C", Offset = "0x1179B9C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void halfBrick(bool halfBrick)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A3A0", Offset = "0x117A3A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool actuator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A3AC", Offset = "0x117A3AC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void actuator(bool actuator)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179D5C", Offset = "0x1179D5C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte slope()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1179B84", Offset = "0x1179B84", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void slope(byte slope)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A3C8", Offset = "0x117A3C8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear(TileDataType types)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A4A8", Offset = "0x117A4A8", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile_PC), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile_PC), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CanPoundTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidOrSlopedTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TileEmpty", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void SmoothSlope(int x, int y, bool applyToNeighbors = true, bool sync = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x117A8A4", Offset = "0x117A8A4", Length = "0x12D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400377A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ushort type;

		[global::Cpp2ILInjected.Token(Token = "0x400377B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		public ushort wall;

		[global::Cpp2ILInjected.Token(Token = "0x400377C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public byte liquid;

		[global::Cpp2ILInjected.Token(Token = "0x400377D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
		public short sTileHeader;

		[global::Cpp2ILInjected.Token(Token = "0x400377E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte bTileHeader;

		[global::Cpp2ILInjected.Token(Token = "0x400377F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public byte bTileHeader2;

		[global::Cpp2ILInjected.Token(Token = "0x4003780")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public byte bTileHeader3;

		[global::Cpp2ILInjected.Token(Token = "0x4003781")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public short frameX;

		[global::Cpp2ILInjected.Token(Token = "0x4003782")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
		public short frameY;

		[global::Cpp2ILInjected.Token(Token = "0x4003783")]
		public const int Type_Solid = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4003784")]
		public const int Type_Halfbrick = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4003785")]
		public const int Type_SlopeDownRight = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4003786")]
		public const int Type_SlopeDownLeft = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4003787")]
		public const int Type_SlopeUpRight = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4003788")]
		public const int Type_SlopeUpLeft = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4003789")]
		public const int Liquid_Water = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400378A")]
		public const int Liquid_Lava = 1;

		[global::Cpp2ILInjected.Token(Token = "0x400378B")]
		public const int Liquid_Honey = 2;
	}
}
