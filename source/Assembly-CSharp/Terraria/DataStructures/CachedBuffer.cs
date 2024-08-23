using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;

namespace Terraria.DataStructures
{
	// Token: 0x02000420 RID: 1056
	[global::Cpp2ILInjected.Token(Token = "0x200061B")]
	public class CachedBuffer
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0002AB36 File Offset: 0x00028D36
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0002AB39 File Offset: 0x00028D39
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

		// Token: 0x060030A6 RID: 12454 RVA: 0x0002AB3C File Offset: 0x00028D3C
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

		// Token: 0x060030A7 RID: 12455 RVA: 0x0002AB3F File Offset: 0x00028D3F
		[global::Cpp2ILInjected.Token(Token = "0x60035C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DB458", Offset = "0x13DB458", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal CachedBuffer Activate()
		{
			throw null;
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0002AB42 File Offset: 0x00028D42
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

		// Token: 0x040062B0 RID: 25264
		[global::Cpp2ILInjected.Token(Token = "0x400769A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly byte[] Data;

		// Token: 0x040062B1 RID: 25265
		[global::Cpp2ILInjected.Token(Token = "0x400769B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly BinaryWriter Writer;

		// Token: 0x040062B2 RID: 25266
		[global::Cpp2ILInjected.Token(Token = "0x400769C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly BinaryReader Reader;

		// Token: 0x040062B3 RID: 25267
		[global::Cpp2ILInjected.Token(Token = "0x400769D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly MemoryStream _memoryStream;

		// Token: 0x040062B4 RID: 25268
		[global::Cpp2ILInjected.Token(Token = "0x400769E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _isActive;
	}
}
