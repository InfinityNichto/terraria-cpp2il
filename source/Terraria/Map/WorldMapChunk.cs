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
	[global::Cpp2ILInjected.Token(Token = "0x20006C2")]
	public class WorldMapChunk
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40079C4")]
		public const int InitialChunkCompressedSize = 2048;

		[global::Cpp2ILInjected.Token(Token = "0x40079C5")]
		public const int MapChunkSize = 64;

		[global::Cpp2ILInjected.Token(Token = "0x40079C6")]
		public static int MapChunkTileSize;

		[global::Cpp2ILInjected.Token(Token = "0x40079C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly WorldMap Map;

		[global::Cpp2ILInjected.Token(Token = "0x40079C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public unsafe MapTile* TileData;

		[global::Cpp2ILInjected.Token(Token = "0x40079C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public byte[] CompressedData;

		[global::Cpp2ILInjected.Token(Token = "0x40079CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public long CompressedDataLength;

		[global::Cpp2ILInjected.Token(Token = "0x40079CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public DateTime LastUsed;

		[global::Cpp2ILInjected.Token(Token = "0x40079CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int X;

		[global::Cpp2ILInjected.Token(Token = "0x40079CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int Y;

		[global::Cpp2ILInjected.Token(Token = "0x40079CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool dirty;

		[global::Cpp2ILInjected.Token(Token = "0x40079CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int frameAge;

		[global::Cpp2ILInjected.Token(Token = "0x40079D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int referenceCount;

		[global::Cpp2ILInjected.Token(Token = "0x40079D1")]
		private static byte[] ClearData;

		[global::Cpp2ILInjected.Token(Token = "0x40079D2")]
		private static byte[] resetData;

		[global::Cpp2ILInjected.Token(Token = "0x40079D3")]
		private static byte[] CopyBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40079D4")]
		private static byte[] CompressBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40079D5")]
		private static byte[] BlockBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x40079D6")]
		private static ZlibCodec zlibCompress;

		[global::Cpp2ILInjected.Token(Token = "0x40079D7")]
		private static ZlibCodec zlibDecompress;

		[global::Cpp2ILInjected.Token(Token = "0x40079D8")]
		private static long biggestChunk;
	}
}
