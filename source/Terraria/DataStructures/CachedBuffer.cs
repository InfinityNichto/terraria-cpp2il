using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200061B")]
	public class CachedBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000689")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DB6DC", Offset = "0x13DB6DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700068A")]
		public bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DBA44", Offset = "0x13DBA44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB36C", Offset = "0x13DB36C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferPool), Member = "Request", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CachedBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CachedBuffer(byte[] data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB458", Offset = "0x13DB458", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal CachedBuffer Activate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBA4C", Offset = "0x13DBA4C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPacket), Member = "Recycle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferPool), Member = "Recycle", MemberParameters = new object[] { typeof(CachedBuffer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Recycle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400769A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly byte[] Data;

		[global::Cpp2ILInjected.Token(Token = "0x400769B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly BinaryWriter Writer;

		[global::Cpp2ILInjected.Token(Token = "0x400769C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly BinaryReader Reader;

		[global::Cpp2ILInjected.Token(Token = "0x400769D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly MemoryStream _memoryStream;

		[global::Cpp2ILInjected.Token(Token = "0x400769E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _isActive;
	}
}
