using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zlib;
using UnityEngine;

namespace Terraria.Map
{
	// Token: 0x020004AE RID: 1198
	[global::Cpp2ILInjected.Token(Token = "0x20006C2")]
	public class WorldMapChunk
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x0002B433 File Offset: 0x00029633
		[global::Cpp2ILInjected.Token(Token = "0x600393E")]
		[global::Cpp2ILInjected.Address(RVA = "0x144A4F0", Offset = "0x144A4F0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Allocate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe WorldMapChunk(WorldMap map, byte* compressedData)
		{
			throw null;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x0002B436 File Offset: 0x00029636
		[global::Cpp2ILInjected.Token(Token = "0x170006DD")]
		public bool Loaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x600393F")]
			[global::Cpp2ILInjected.Address(RVA = "0x144B728", Offset = "0x144B728", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x0002B439 File Offset: 0x00029639
		[global::Cpp2ILInjected.Token(Token = "0x6003940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1449764", Offset = "0x1449764", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersionCompressed", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "UnloadChunk", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "GetTileStorage", MemberParameters = new object[]
		{
			typeof(WorldMapChunk),
			typeof(bool)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "Compress", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe void SaveCompressed()
		{
			throw null;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0002B43C File Offset: 0x0002963C
		[global::Cpp2ILInjected.Token(Token = "0x6003941")]
		[global::Cpp2ILInjected.Address(RVA = "0x1449190", Offset = "0x1449190", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "LoadMapVersionCompressed", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ref WorldMapChunk)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetTileStorage", MemberParameters = new object[]
		{
			typeof(WorldMapChunk),
			typeof(bool)
		}, ReturnType = typeof(MapTile*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMapChunk), Member = "Decompress", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(long),
			typeof(byte*),
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe void LoadTiles(bool utilLoad = false)
		{
			throw null;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0002B43F File Offset: 0x0002963F
		[global::Cpp2ILInjected.Token(Token = "0x6003942")]
		[global::Cpp2ILInjected.Address(RVA = "0x144B524", Offset = "0x144B524", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "ReleaseTileStorage", MemberParameters = new object[] { typeof(WorldMapChunk) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0002B442 File Offset: 0x00029642
		[global::Cpp2ILInjected.Token(Token = "0x6003943")]
		[global::Cpp2ILInjected.Address(RVA = "0x144B738", Offset = "0x144B738", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMapChunk), Member = "SaveCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "ResetDeflate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public unsafe void Compress(byte* srcData, long srcLength, out long resultLength)
		{
			throw null;
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x0002B445 File Offset: 0x00029645
		[global::Cpp2ILInjected.Token(Token = "0x6003944")]
		[global::Cpp2ILInjected.Address(RVA = "0x144BA00", Offset = "0x144BA00", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMapChunk), Member = "LoadTiles", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public unsafe void Decompress(byte[] srcData, long srcLength, byte* dstData, long dstLength, out long resultLength)
		{
			throw null;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x0002B448 File Offset: 0x00029648
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003945")]
		[global::Cpp2ILInjected.Address(RVA = "0x144BDA4", Offset = "0x144BDA4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = ".ctor", MemberParameters = new object[] { typeof(CompressionMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static WorldMapChunk()
		{
			throw null;
		}

		// Token: 0x040065B3 RID: 26035
		[global::Cpp2ILInjected.Token(Token = "0x40079C4")]
		public const int InitialChunkCompressedSize = 2048;

		// Token: 0x040065B4 RID: 26036
		[global::Cpp2ILInjected.Token(Token = "0x40079C5")]
		public const int MapChunkSize = 64;

		// Token: 0x040065B5 RID: 26037
		[global::Cpp2ILInjected.Token(Token = "0x40079C6")]
		public static int MapChunkTileSize;

		// Token: 0x040065B6 RID: 26038
		[global::Cpp2ILInjected.Token(Token = "0x40079C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly WorldMap Map;

		// Token: 0x040065B7 RID: 26039
		[global::Cpp2ILInjected.Token(Token = "0x40079C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public unsafe MapTile* TileData;

		// Token: 0x040065B8 RID: 26040
		[global::Cpp2ILInjected.Token(Token = "0x40079C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public byte[] CompressedData;

		// Token: 0x040065B9 RID: 26041
		[global::Cpp2ILInjected.Token(Token = "0x40079CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public long CompressedDataLength;

		// Token: 0x040065BA RID: 26042
		[global::Cpp2ILInjected.Token(Token = "0x40079CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public DateTime LastUsed;

		// Token: 0x040065BB RID: 26043
		[global::Cpp2ILInjected.Token(Token = "0x40079CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int X;

		// Token: 0x040065BC RID: 26044
		[global::Cpp2ILInjected.Token(Token = "0x40079CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int Y;

		// Token: 0x040065BD RID: 26045
		[global::Cpp2ILInjected.Token(Token = "0x40079CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool dirty;

		// Token: 0x040065BE RID: 26046
		[global::Cpp2ILInjected.Token(Token = "0x40079CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int frameAge;

		// Token: 0x040065BF RID: 26047
		[global::Cpp2ILInjected.Token(Token = "0x40079D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int referenceCount;

		// Token: 0x040065C0 RID: 26048
		[global::Cpp2ILInjected.Token(Token = "0x40079D1")]
		private static byte[] ClearData;

		// Token: 0x040065C1 RID: 26049
		[global::Cpp2ILInjected.Token(Token = "0x40079D2")]
		private static byte[] resetData;

		// Token: 0x040065C2 RID: 26050
		[global::Cpp2ILInjected.Token(Token = "0x40079D3")]
		private static byte[] CopyBuffer;

		// Token: 0x040065C3 RID: 26051
		[global::Cpp2ILInjected.Token(Token = "0x40079D4")]
		private static byte[] CompressBuffer;

		// Token: 0x040065C4 RID: 26052
		[global::Cpp2ILInjected.Token(Token = "0x40079D5")]
		private static byte[] BlockBuffer;

		// Token: 0x040065C5 RID: 26053
		[global::Cpp2ILInjected.Token(Token = "0x40079D6")]
		private static ZlibCodec zlibCompress;

		// Token: 0x040065C6 RID: 26054
		[global::Cpp2ILInjected.Token(Token = "0x40079D7")]
		private static ZlibCodec zlibDecompress;

		// Token: 0x040065C7 RID: 26055
		[global::Cpp2ILInjected.Token(Token = "0x40079D8")]
		private static long biggestChunk;
	}
}
