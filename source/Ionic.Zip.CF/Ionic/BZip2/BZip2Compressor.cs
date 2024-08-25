using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.BZip2
{
	[global::Cpp2ILInjected.Token(Token = "0x2000035")]
	internal class BZip2Compressor
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A627EC", Offset = "0x1A627EC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BZip2Compressor(BitWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6285C", Offset = "0x1A6285C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor.CompressionState), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public BZip2Compressor(BitWriter writer, int blockSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62CD4", Offset = "0x1A62CD4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		public int BlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D18", Offset = "0x1A62D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		public uint Crc32
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D20", Offset = "0x1A62D20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D28", Offset = "0x1A62D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
		public int AvailableBytesOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D30", Offset = "0x1A62D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D38", Offset = "0x1A62D38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public int UncompressedBytes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62D40", Offset = "0x1A62D40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62D4C", Offset = "0x1A62D4C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "write0", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
		public int Fill(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62DC0", Offset = "0x1A62DC0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "Fill", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "AddRunToOutputBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		private int write0(byte b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62E68", Offset = "0x1A62E68", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "write0", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "UpdateCRC", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private bool AddRunToOutputBlock(bool final)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6304C", Offset = "0x1A6304C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "AddRunToOutputBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "blockSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "get_Crc32Result", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteInt", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "moveToFrontCodeAndSend", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CompressAndWrite()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6327C", Offset = "0x1A6327C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "blockSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rand), Member = "Rnums", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void randomiseBlock()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A633D0", Offset = "0x1A633D0", Length = "0x688")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "blockSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "mainQSort3", MemberParameters = new object[]
		{
			typeof(BZip2Compressor.CompressionState),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void mainSort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A63168", Offset = "0x1A63168", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "mainSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "randomiseBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void blockSort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A63E6C", Offset = "0x1A63E6C", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "mainQSort3", MemberParameters = new object[]
		{
			typeof(BZip2Compressor.CompressionState),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool mainSimpleSort(BZip2Compressor.CompressionState dataShadow, int lo, int hi, int d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6428C", Offset = "0x1A6428C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void vswap(int[] fmap, int p1, int p2, int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A642CC", Offset = "0x1A642CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static byte med3(byte a, byte b, byte c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A63A58", Offset = "0x1A63A58", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "mainSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "mainSimpleSort", MemberParameters = new object[]
		{
			typeof(BZip2Compressor.CompressionState),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void mainQSort3(BZip2Compressor.CompressionState dataShadow, int loSt, int hiSt, int dSt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A64318", Offset = "0x1A64318", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "moveToFrontCodeAndSend", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void generateMTFValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A645B8", Offset = "0x1A645B8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6461C", Offset = "0x1A6461C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "moveToFrontCodeAndSend", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues1", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues3", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues4", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues5", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues6", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues7", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void sendMTFValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A647BC", Offset = "0x1A647BC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void sendMTFValues0(int nGroups, int alphaSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65444", Offset = "0x1A65444", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues1", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static void hbMakeCodeLengths(byte[] len, int[] freq, BZip2Compressor.CompressionState state1, int alphaSize, int maxLen)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A64980", Offset = "0x1A64980", Length = "0x4B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "hbMakeCodeLengths", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int[]),
			typeof(BZip2Compressor.CompressionState),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private int sendMTFValues1(int nGroups, int alphaSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A64E38", Offset = "0x1A64E38", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void sendMTFValues2(int nGroups, int nSelectors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A64ED4", Offset = "0x1A64ED4", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void sendMTFValues3(int nGroups, int alphaSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65048", Offset = "0x1A65048", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		private void sendMTFValues4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65154", Offset = "0x1A65154", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		private void sendMTFValues5(int nGroups, int nSelectors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A651F0", Offset = "0x1A651F0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		private void sendMTFValues6(int nGroups, int alphaSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A652F0", Offset = "0x1A652F0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void sendMTFValues7(int nSelectors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A63250", Offset = "0x1A63250", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "generateMTFValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "sendMTFValues", ReturnType = typeof(void))]
		private void moveToFrontCodeAndSend()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A657F8", Offset = "0x1A657F8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BZip2Compressor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int blockSize100k;

		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int currentByte;

		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int runLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int last;

		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int outBlockFillThreshold;

		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BZip2Compressor.CompressionState cstate;

		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly CRC32 crc;

		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BitWriter bw;

		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int runs;

		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int workDone;

		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int workLimit;

		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private bool firstAttempt;

		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		private bool blockRandomised;

		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int origPtr;

		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int nInUse;

		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int nMTF;

		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		private static readonly int SETMASK;

		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		private static readonly int CLEARMASK;

		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		private static readonly byte GREATER_ICOST;

		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		private static readonly byte LESSER_ICOST;

		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		private static readonly int SMALL_THRESH;

		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		private static readonly int DEPTH_THRESH;

		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		private static readonly int WORK_FACTOR;

		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		private static readonly int[] increments;

		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private uint <Crc32>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int <AvailableBytesOut>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000036")]
		private class CompressionState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62980", Offset = "0x1A62980", Length = "0x354")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(BitWriter),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2), Member = "InitRectangularArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = "T[][]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2[]), Member = "InitRectangularArray", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = "T[][]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
			public CompressionState(int blockSize100k)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000169")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			[global::Cpp2ILInjected.Token(Token = "0x400016A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly byte[] unseqToSeq;

			[global::Cpp2ILInjected.Token(Token = "0x400016B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly int[] mtfFreq;

			[global::Cpp2ILInjected.Token(Token = "0x400016C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly byte[] selector;

			[global::Cpp2ILInjected.Token(Token = "0x400016D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public readonly byte[] selectorMtf;

			[global::Cpp2ILInjected.Token(Token = "0x400016E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public readonly byte[] generateMTFValues_yy;

			[global::Cpp2ILInjected.Token(Token = "0x400016F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public byte[][] sendMTFValues_len;

			[global::Cpp2ILInjected.Token(Token = "0x4000170")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public int[][] sendMTFValues_rfreq;

			[global::Cpp2ILInjected.Token(Token = "0x4000171")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public readonly int[] sendMTFValues_fave;

			[global::Cpp2ILInjected.Token(Token = "0x4000172")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public readonly short[] sendMTFValues_cost;

			[global::Cpp2ILInjected.Token(Token = "0x4000173")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public int[][] sendMTFValues_code;

			[global::Cpp2ILInjected.Token(Token = "0x4000174")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public readonly byte[] sendMTFValues2_pos;

			[global::Cpp2ILInjected.Token(Token = "0x4000175")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			public readonly bool[] sentMTFValues4_inUse16;

			[global::Cpp2ILInjected.Token(Token = "0x4000176")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			public readonly int[] stack_ll;

			[global::Cpp2ILInjected.Token(Token = "0x4000177")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			public readonly int[] stack_hh;

			[global::Cpp2ILInjected.Token(Token = "0x4000178")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public readonly int[] stack_dd;

			[global::Cpp2ILInjected.Token(Token = "0x4000179")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public readonly int[] mainSort_runningOrder;

			[global::Cpp2ILInjected.Token(Token = "0x400017A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public readonly int[] mainSort_copy;

			[global::Cpp2ILInjected.Token(Token = "0x400017B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public readonly bool[] mainSort_bigDone;

			[global::Cpp2ILInjected.Token(Token = "0x400017C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public int[] heap;

			[global::Cpp2ILInjected.Token(Token = "0x400017D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public int[] weight;

			[global::Cpp2ILInjected.Token(Token = "0x400017E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public int[] parent;

			[global::Cpp2ILInjected.Token(Token = "0x400017F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public readonly int[] ftab;

			[global::Cpp2ILInjected.Token(Token = "0x4000180")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public byte[] block;

			[global::Cpp2ILInjected.Token(Token = "0x4000181")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public int[] fmap;

			[global::Cpp2ILInjected.Token(Token = "0x4000182")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public char[] sfmap;

			[global::Cpp2ILInjected.Token(Token = "0x4000183")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public char[] quadrant;
		}
	}
}
