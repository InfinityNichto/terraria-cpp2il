using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000369 RID: 873
	[global::Cpp2ILInjected.Token(Token = "0x2000411")]
	internal sealed class ObjectNull
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x000198A1 File Offset: 0x00017AA1
		[global::Cpp2ILInjected.Token(Token = "0x600201C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E2F8", Offset = "0x1B5E2F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ObjectNull()
		{
			throw null;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000198A4 File Offset: 0x00017AA4
		[global::Cpp2ILInjected.Token(Token = "0x600201D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E300", Offset = "0x1B5E300", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetNullCount(int nullCount)
		{
			throw null;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000198A7 File Offset: 0x00017AA7
		[global::Cpp2ILInjected.Token(Token = "0x600201E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E308", Offset = "0x1B5E308", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteNullMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000198AA File Offset: 0x00017AAA
		[global::Cpp2ILInjected.Token(Token = "0x600201F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E388", Offset = "0x1B5E388", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadByte", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000198AD File Offset: 0x00017AAD
		[global::Cpp2ILInjected.Token(Token = "0x6002020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E3DC", Offset = "0x1B5E3DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000DAA RID: 3498
		[global::Cpp2ILInjected.Token(Token = "0x400109C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int nullCount;
	}
}
