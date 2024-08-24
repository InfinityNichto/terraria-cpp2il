using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameInput;
using Terraria.IO;
using Terraria.Localization;

namespace Terraria.DataStructures
{
	// Token: 0x0200047B RID: 1147
	[global::Cpp2ILInjected.Token(Token = "0x200067E")]
	public abstract class TileEntity
	{
		// Token: 0x0600322A RID: 12842 RVA: 0x0002AF95 File Offset: 0x00029195
		[global::Cpp2ILInjected.Token(Token = "0x6003753")]
		[global::Cpp2ILInjected.Address(RVA = "0x141EDBC", Offset = "0x141EDBC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEFoodPlatter), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEWeaponsRack), Member = "Place", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int AssignNewID()
		{
			throw null;
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600322B RID: 12843 RVA: 0x0002AF98 File Offset: 0x00029198
		// (remove) Token: 0x0600322C RID: 12844 RVA: 0x0002AF9B File Offset: 0x0002919B
		[global::Cpp2ILInjected.Token(Token = "0x1400003F")]
		public static event Action _UpdateStart
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003754")]
			[global::Cpp2ILInjected.Address(RVA = "0x141EE1C", Offset = "0x141EE1C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "RegisterTileEntityID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "RegisterTileEntityID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003755")]
			[global::Cpp2ILInjected.Address(RVA = "0x141EEF8", Offset = "0x141EEF8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600322D RID: 12845 RVA: 0x0002AF9E File Offset: 0x0002919E
		// (remove) Token: 0x0600322E RID: 12846 RVA: 0x0002AFA1 File Offset: 0x000291A1
		[global::Cpp2ILInjected.Token(Token = "0x14000040")]
		public static event Action _UpdateEnd
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003756")]
			[global::Cpp2ILInjected.Address(RVA = "0x141EFD4", Offset = "0x141EFD4", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "RegisterTileEntityID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003757")]
			[global::Cpp2ILInjected.Address(RVA = "0x141F0B0", Offset = "0x141F0B0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0002AFA4 File Offset: 0x000291A4
		[global::Cpp2ILInjected.Token(Token = "0x6003758")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F18C", Offset = "0x141F18C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Clear()
		{
			throw null;
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0002AFA7 File Offset: 0x000291A7
		[global::Cpp2ILInjected.Token(Token = "0x6003759")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F220", Offset = "0x141F220", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void UpdateStart()
		{
			throw null;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0002AFAA File Offset: 0x000291AA
		[global::Cpp2ILInjected.Token(Token = "0x600375A")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F2AC", Offset = "0x141F2AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void UpdateEnd()
		{
			throw null;
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0002AFAD File Offset: 0x000291AD
		[global::Cpp2ILInjected.Token(Token = "0x600375B")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F338", Offset = "0x141F338", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "RegisterAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void InitializeAll()
		{
			throw null;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x0002AFB0 File Offset: 0x000291B0
		[global::Cpp2ILInjected.Token(Token = "0x600375C")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F3C0", Offset = "0x141F3C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		public static int GetKey(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x0002AFB3 File Offset: 0x000291B3
		[global::Cpp2ILInjected.Token(Token = "0x600375D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F3C8", Offset = "0x141F3C8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "NetPlaceEntity", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void PlaceEntityNet(int x, int y, int type)
		{
			throw null;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x0002AFB6 File Offset: 0x000291B6
		[global::Cpp2ILInjected.Token(Token = "0x170006AC")]
		public int PositionKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x600375E")]
			[global::Cpp2ILInjected.Address(RVA = "0x141F4CC", Offset = "0x141F4CC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
			{
				typeof(BinaryReader),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEFoodPlatter), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "UpdateEndInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEWeaponsRack), Member = "Place", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x0002AFB9 File Offset: 0x000291B9
		[global::Cpp2ILInjected.Token(Token = "0x600375F")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F528", Offset = "0x141F528", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Update()
		{
			throw null;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x0002AFBC File Offset: 0x000291BC
		[global::Cpp2ILInjected.Token(Token = "0x6003760")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F52C", Offset = "0x141F52C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "CompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveTileEntities", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static void Write(BinaryWriter writer, TileEntity ent, bool networkSend = false)
		{
			throw null;
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x0002AFBF File Offset: 0x000291BF
		[global::Cpp2ILInjected.Token(Token = "0x6003761")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F5EC", Offset = "0x141F5EC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "ValidateWorld", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "GenerateInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "ReadInner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TileEntity Read(BinaryReader reader, bool networkSend = false)
		{
			throw null;
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x0002AFC2 File Offset: 0x000291C2
		[global::Cpp2ILInjected.Token(Token = "0x6003762")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F718", Offset = "0x141F718", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadTileEntities", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntitiesManager), Member = "GenerateInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "ReadInnerPos32", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TileEntity ReadPos32(BinaryReader reader, bool networkSend = false)
		{
			throw null;
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x0002AFC5 File Offset: 0x000291C5
		[global::Cpp2ILInjected.Token(Token = "0x6003763")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F56C", Offset = "0x141F56C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteInner(BinaryWriter writer, bool networkSend)
		{
			throw null;
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x0002AFC8 File Offset: 0x000291C8
		[global::Cpp2ILInjected.Token(Token = "0x6003764")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F68C", Offset = "0x141F68C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "Read", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ReadInner(BinaryReader reader, bool networkSend)
		{
			throw null;
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x0002AFCB File Offset: 0x000291CB
		[global::Cpp2ILInjected.Token(Token = "0x6003765")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F7B8", Offset = "0x141F7B8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "ReadPos32", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool)
		}, ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ReadInnerPos32(BinaryReader reader, bool networkSend)
		{
			throw null;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x0002AFCE File Offset: 0x000291CE
		[global::Cpp2ILInjected.Token(Token = "0x6003766")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F844", Offset = "0x141F844", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void WriteExtraData(BinaryWriter writer, bool networkSend)
		{
			throw null;
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x0002AFD1 File Offset: 0x000291D1
		[global::Cpp2ILInjected.Token(Token = "0x6003767")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F848", Offset = "0x141F848", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void ReadExtraData(BinaryReader reader, bool networkSend)
		{
			throw null;
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0002AFD4 File Offset: 0x000291D4
		[global::Cpp2ILInjected.Token(Token = "0x6003768")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F84C", Offset = "0x141F84C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnPlayerUpdate(Player player)
		{
			throw null;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0002AFD7 File Offset: 0x000291D7
		[global::Cpp2ILInjected.Token(Token = "0x6003769")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F850", Offset = "0x141F850", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "BasicOpenCloseInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsOccupied(int id, out int interactingPlayer)
		{
			throw null;
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x0002AFDA File Offset: 0x000291DA
		[global::Cpp2ILInjected.Token(Token = "0x600376A")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F908", Offset = "0x141F908", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnInventoryDraw(Player player, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x0002AFDD File Offset: 0x000291DD
		[global::Cpp2ILInjected.Token(Token = "0x600376B")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F90C", Offset = "0x141F90C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual string GetItemGamepadInstructions(int slot = 0)
		{
			throw null;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0002AFE0 File Offset: 0x000291E0
		[global::Cpp2ILInjected.Token(Token = "0x600376C")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F94C", Offset = "0x141F94C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool TryGetItemGamepadOverrideInstructions(Item[] inv, int context, int slot, out string instruction)
		{
			throw null;
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0002AFE3 File Offset: 0x000291E3
		[global::Cpp2ILInjected.Token(Token = "0x600376D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F958", Offset = "0x141F958", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool OverrideItemSlotHover(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0002AFE6 File Offset: 0x000291E6
		[global::Cpp2ILInjected.Token(Token = "0x600376E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F960", Offset = "0x141F960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool OverrideItemSlotLeftClick(Item[] inv, int context = 0, int slot = 0)
		{
			throw null;
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0002AFE9 File Offset: 0x000291E9
		[global::Cpp2ILInjected.Token(Token = "0x600376F")]
		[global::Cpp2ILInjected.Address(RVA = "0x141F968", Offset = "0x141F968", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "OnPlayerInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "OnPlayerInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CloseSign", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_stackSplit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GamepadEnableGrappleCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "IsOccupied", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileEntity), Member = "SetInteractionAnchor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "GetTileEntity", ReturnType = typeof(TileEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
		{
			typeof(GUIPageIcons.Category),
			typeof(GUIPageIcons.Category)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void BasicOpenCloseInteraction(Player player, int x, int y, int id)
		{
			throw null;
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0002AFEC File Offset: 0x000291EC
		[global::Cpp2ILInjected.Token(Token = "0x6003770")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FC98", Offset = "0x141FC98", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "BasicOpenCloseInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SetTalkNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_playerInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "CloseMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "set_Grapple", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void SetInteractionAnchor(Player player, int x, int y, int id)
		{
			throw null;
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0002AFEF File Offset: 0x000291EF
		[global::Cpp2ILInjected.Token(Token = "0x6003771")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FDFC", Offset = "0x141FDFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void RegisterTileEntityID(int assignedID)
		{
			throw null;
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x0002AFF2 File Offset: 0x000291F2
		[global::Cpp2ILInjected.Token(Token = "0x6003772")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FE00", Offset = "0x141FE00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void NetPlaceEntityAttempt(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x0002AFF5 File Offset: 0x000291F5
		[global::Cpp2ILInjected.Token(Token = "0x6003773")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FE04", Offset = "0x141FE04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool IsTileValidForEntity(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x0002AFF8 File Offset: 0x000291F8
		[global::Cpp2ILInjected.Token(Token = "0x6003774")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FE0C", Offset = "0x141FE0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual TileEntity GenerateInstance()
		{
			throw null;
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x0002AFFB File Offset: 0x000291FB
		[global::Cpp2ILInjected.Token(Token = "0x6003775")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FE14", Offset = "0x141FE14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEFoodPlatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEItemFrame), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TELogicSensor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETeleportationPylon), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TETrainingDummy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEWeaponsRack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TileEntity()
		{
			throw null;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0002AFFE File Offset: 0x000291FE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003776")]
		[global::Cpp2ILInjected.Address(RVA = "0x141FE1C", Offset = "0x141FE1C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static TileEntity()
		{
			throw null;
		}

		// Token: 0x0400647A RID: 25722
		[global::Cpp2ILInjected.Token(Token = "0x4007876")]
		public static TileEntitiesManager manager;

		// Token: 0x0400647B RID: 25723
		[global::Cpp2ILInjected.Token(Token = "0x4007877")]
		public const int MaxEntitiesPerChunk = 1000;

		// Token: 0x0400647C RID: 25724
		[global::Cpp2ILInjected.Token(Token = "0x4007878")]
		public static object EntityCreationLock;

		// Token: 0x0400647D RID: 25725
		[global::Cpp2ILInjected.Token(Token = "0x4007879")]
		public static Dictionary<int, TileEntity> ByID;

		// Token: 0x0400647E RID: 25726
		[global::Cpp2ILInjected.Token(Token = "0x400787A")]
		public static Dictionary<int, TileEntity> ByPosition;

		// Token: 0x0400647F RID: 25727
		[global::Cpp2ILInjected.Token(Token = "0x400787B")]
		public static int TileEntitiesNextID;

		// Token: 0x04006480 RID: 25728
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400787C")]
		private static Action _UpdateStart;

		// Token: 0x04006481 RID: 25729
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400787D")]
		private static Action _UpdateEnd;

		// Token: 0x04006482 RID: 25730
		[global::Cpp2ILInjected.Token(Token = "0x400787E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04006483 RID: 25731
		[global::Cpp2ILInjected.Token(Token = "0x400787F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Point16 Position;

		// Token: 0x04006484 RID: 25732
		[global::Cpp2ILInjected.Token(Token = "0x4007880")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte type;
	}
}
