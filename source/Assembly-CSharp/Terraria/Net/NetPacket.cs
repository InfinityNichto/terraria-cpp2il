using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.Net
{
	// Token: 0x0200049A RID: 1178
	[global::Cpp2ILInjected.Token(Token = "0x20006A7")]
	public struct NetPacket
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x0002B2EC File Offset: 0x000294EC
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x0002B2EF File Offset: 0x000294EF
		[global::Cpp2ILInjected.Token(Token = "0x170006D5")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60038A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D448", Offset = "0x143D448", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60038A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D450", Offset = "0x143D450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x0002B2F2 File Offset: 0x000294F2
		[global::Cpp2ILInjected.Token(Token = "0x170006D6")]
		public BinaryWriter Writer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x143D458", Offset = "0x143D458", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x0002B2F5 File Offset: 0x000294F5
		[global::Cpp2ILInjected.Token(Token = "0x170006D7")]
		public BinaryReader Reader
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x143B914", Offset = "0x143B914", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0002B2F8 File Offset: 0x000294F8
		[global::Cpp2ILInjected.Token(Token = "0x60038A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D464", Offset = "0x143D464", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferPool), Member = "Request", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CachedBuffer))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public NetPacket(ushort id, int size)
		{
			throw null;
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0002B2FB File Offset: 0x000294FB
		[global::Cpp2ILInjected.Token(Token = "0x60038A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BCA8", Offset = "0x143BCA8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedBuffer), Member = "Recycle", ReturnType = typeof(void))]
		public void Recycle()
		{
			throw null;
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x0002B2FE File Offset: 0x000294FE
		[global::Cpp2ILInjected.Token(Token = "0x60038A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x143BBE4", Offset = "0x143BBE4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ShrinkToFit()
		{
			throw null;
		}

		// Token: 0x0400654C RID: 25932
		[global::Cpp2ILInjected.Token(Token = "0x400794E")]
		private const int HEADER_SIZE = 5;

		// Token: 0x0400654D RID: 25933
		[global::Cpp2ILInjected.Token(Token = "0x400794F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly ushort Id;

		// Token: 0x0400654E RID: 25934
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007950")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int <Length>k__BackingField;

		// Token: 0x0400654F RID: 25935
		[global::Cpp2ILInjected.Token(Token = "0x4007951")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly CachedBuffer Buffer;
	}
}
