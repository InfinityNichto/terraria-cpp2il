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
	[global::Cpp2ILInjected.Token(Token = "0x2000489")]
	public class WorldSections
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002F80")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3478", Offset = "0x12F3478", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public bool MapSectionDrawn(int x, int y)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4003960")]
		public const int BitIndex_SectionLoaded = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4003961")]
		public const int BitIndex_SectionFramed = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4003962")]
		public const int BitIndex_SectionMapDrawn = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4003963")]
		public const int BitIndex_SectionNeedsRefresh = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4003964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int width;

		[global::Cpp2ILInjected.Token(Token = "0x4003965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int height;

		[global::Cpp2ILInjected.Token(Token = "0x4003966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitsByte[] data;

		[global::Cpp2ILInjected.Token(Token = "0x4003967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int mapSectionsLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int frameSectionsLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4003969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _sectionsNeedingRefresh;

		[global::Cpp2ILInjected.Token(Token = "0x400396A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public IEnumerator CurrentMapSection;

		[global::Cpp2ILInjected.Token(Token = "0x400396B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WorldSections.IterationState prevFrame;

		[global::Cpp2ILInjected.Token(Token = "0x400396C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private WorldSections.IterationState prevMap;

		[global::Cpp2ILInjected.Token(Token = "0x200048A")]
		private struct IterationState
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x400396D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 centerPos;

			[global::Cpp2ILInjected.Token(Token = "0x400396E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int X;

			[global::Cpp2ILInjected.Token(Token = "0x400396F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int Y;

			[global::Cpp2ILInjected.Token(Token = "0x4003970")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int leg;

			[global::Cpp2ILInjected.Token(Token = "0x4003971")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int xDir;

			[global::Cpp2ILInjected.Token(Token = "0x4003972")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int yDir;
		}
	}
}
