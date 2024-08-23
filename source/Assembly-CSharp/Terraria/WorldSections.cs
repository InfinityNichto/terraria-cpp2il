using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;

namespace Terraria
{
	// Token: 0x02000353 RID: 851
	[global::Cpp2ILInjected.Token(Token = "0x2000489")]
	public class WorldSections
	{
		// Token: 0x06002C12 RID: 11282 RVA: 0x00029E6D File Offset: 0x0002806D
		[global::Cpp2ILInjected.Token(Token = "0x6002F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3158", Offset = "0x12F3158", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SetWorldSizeOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WorldSections(int numSectionsX, int numSectionsY)
		{
			throw null;
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x00029E70 File Offset: 0x00028070
		[global::Cpp2ILInjected.Token(Token = "0x170005FD")]
		public bool AnyUnfinishedSections
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F78")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F3290", Offset = "0x12F3290", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SectionTileFrameWithCheck", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00029E73 File Offset: 0x00028073
		[global::Cpp2ILInjected.Token(Token = "0x170005FE")]
		public bool AnyNeedRefresh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F79")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F32A0", Offset = "0x12F32A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetScreenDrawArea", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x00029E76 File Offset: 0x00028076
		[global::Cpp2ILInjected.Token(Token = "0x170005FF")]
		public int TotalMapSections
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F32B0", Offset = "0x12F32B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "joinLocalWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00029E79 File Offset: 0x00028079
		[global::Cpp2ILInjected.Token(Token = "0x6002F7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F32BC", Offset = "0x12F32BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshSection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetSectionAsRefreshed(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00029E7C File Offset: 0x0002807C
		[global::Cpp2ILInjected.Token(Token = "0x6002F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3330", Offset = "0x12F3330", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RefreshSections", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public bool SectionNeedsRefresh(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00029E7F File Offset: 0x0002807F
		[global::Cpp2ILInjected.Token(Token = "0x6002F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3374", Offset = "0x12F3374", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetAllFramedSectionsAsNeedingRefresh()
		{
			throw null;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00029E82 File Offset: 0x00028082
		[global::Cpp2ILInjected.Token(Token = "0x6002F7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F33F0", Offset = "0x12F33F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SectionTileFrameWithCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public bool SectionLoaded(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x00029E85 File Offset: 0x00028085
		[global::Cpp2ILInjected.Token(Token = "0x6002F7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3434", Offset = "0x12F3434", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SectionTileFrameWithCheck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public bool SectionFramed(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00029E88 File Offset: 0x00028088
		[global::Cpp2ILInjected.Token(Token = "0x6002F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3478", Offset = "0x12F3478", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public bool MapSectionDrawn(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00029E8B File Offset: 0x0002808B
		[global::Cpp2ILInjected.Token(Token = "0x6002F81")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F34BC", Offset = "0x12F34BC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void ClearMapDraw()
		{
			throw null;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00029E8E File Offset: 0x0002808E
		[global::Cpp2ILInjected.Token(Token = "0x6002F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3554", Offset = "0x12F3554", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SectionTileFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void SetSectionFramed(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00029E91 File Offset: 0x00028091
		[global::Cpp2ILInjected.Token(Token = "0x6002F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3614", Offset = "0x12F3614", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldSections), Member = "SetTilesLoaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetSectionLoaded(int x, int y)
		{
			throw null;
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00029E94 File Offset: 0x00028094
		[global::Cpp2ILInjected.Token(Token = "0x6002F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F364C", Offset = "0x12F364C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldSections), Member = "SetAllSectionsLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void SetSectionLoaded(ref BitsByte section)
		{
			throw null;
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00029E97 File Offset: 0x00028097
		[global::Cpp2ILInjected.Token(Token = "0x6002F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F36C0", Offset = "0x12F36C0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RenameWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = "SetSectionLoaded", MemberParameters = new object[] { typeof(ref BitsByte) }, ReturnType = typeof(void))]
		public void SetAllSectionsLoaded()
		{
			throw null;
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00029E9A File Offset: 0x0002809A
		[global::Cpp2ILInjected.Token(Token = "0x6002F86")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3710", Offset = "0x12F3710", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "DecompressTileBlock_Inner", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldSections), Member = "SetSectionLoaded", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetTilesLoaded(int startX, int startY, int endXInclusive, int endYInclusive)
		{
			throw null;
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00029E9D File Offset: 0x0002809D
		[global::Cpp2ILInjected.Token(Token = "0x6002F87")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F37FC", Offset = "0x12F37FC", Length = "0x60C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "GetSectionY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool GetNextMapDraw(Vector2 playerPos, out int x, out int y)
		{
			throw null;
		}

		// Token: 0x040030B0 RID: 12464
		[global::Cpp2ILInjected.Token(Token = "0x4003960")]
		public const int BitIndex_SectionLoaded = 0;

		// Token: 0x040030B1 RID: 12465
		[global::Cpp2ILInjected.Token(Token = "0x4003961")]
		public const int BitIndex_SectionFramed = 1;

		// Token: 0x040030B2 RID: 12466
		[global::Cpp2ILInjected.Token(Token = "0x4003962")]
		public const int BitIndex_SectionMapDrawn = 2;

		// Token: 0x040030B3 RID: 12467
		[global::Cpp2ILInjected.Token(Token = "0x4003963")]
		public const int BitIndex_SectionNeedsRefresh = 3;

		// Token: 0x040030B4 RID: 12468
		[global::Cpp2ILInjected.Token(Token = "0x4003964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int width;

		// Token: 0x040030B5 RID: 12469
		[global::Cpp2ILInjected.Token(Token = "0x4003965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int height;

		// Token: 0x040030B6 RID: 12470
		[global::Cpp2ILInjected.Token(Token = "0x4003966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitsByte[] data;

		// Token: 0x040030B7 RID: 12471
		[global::Cpp2ILInjected.Token(Token = "0x4003967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int mapSectionsLeft;

		// Token: 0x040030B8 RID: 12472
		[global::Cpp2ILInjected.Token(Token = "0x4003968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int frameSectionsLeft;

		// Token: 0x040030B9 RID: 12473
		[global::Cpp2ILInjected.Token(Token = "0x4003969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _sectionsNeedingRefresh;

		// Token: 0x040030BA RID: 12474
		[global::Cpp2ILInjected.Token(Token = "0x400396A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IEnumerator CurrentMapSection;

		// Token: 0x040030BB RID: 12475
		[global::Cpp2ILInjected.Token(Token = "0x400396B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WorldSections.IterationState prevFrame;

		// Token: 0x040030BC RID: 12476
		[global::Cpp2ILInjected.Token(Token = "0x400396C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private WorldSections.IterationState prevMap;

		// Token: 0x02000889 RID: 2185
		[global::Cpp2ILInjected.Token(Token = "0x200048A")]
		private struct IterationState
		{
			// Token: 0x06004B16 RID: 19222 RVA: 0x0002F4E3 File Offset: 0x0002D6E3
			[global::Cpp2ILInjected.Token(Token = "0x6002F88")]
			[global::Cpp2ILInjected.Address(RVA = "0x12F3248", Offset = "0x12F3248", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0400805A RID: 32858
			[global::Cpp2ILInjected.Token(Token = "0x400396D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 centerPos;

			// Token: 0x0400805B RID: 32859
			[global::Cpp2ILInjected.Token(Token = "0x400396E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int X;

			// Token: 0x0400805C RID: 32860
			[global::Cpp2ILInjected.Token(Token = "0x400396F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int Y;

			// Token: 0x0400805D RID: 32861
			[global::Cpp2ILInjected.Token(Token = "0x4003970")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int leg;

			// Token: 0x0400805E RID: 32862
			[global::Cpp2ILInjected.Token(Token = "0x4003971")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int xDir;

			// Token: 0x0400805F RID: 32863
			[global::Cpp2ILInjected.Token(Token = "0x4003972")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int yDir;
		}
	}
}
