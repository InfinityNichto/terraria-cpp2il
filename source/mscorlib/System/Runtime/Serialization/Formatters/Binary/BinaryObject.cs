using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035D RID: 861
	[global::Cpp2ILInjected.Token(Token = "0x2000405")]
	internal sealed class BinaryObject
	{
		// Token: 0x06001DA7 RID: 7591 RVA: 0x000197FC File Offset: 0x000179FC
		[global::Cpp2ILInjected.Token(Token = "0x6001FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D108", Offset = "0x1B5D108", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObject()
		{
			throw null;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000197FF File Offset: 0x000179FF
		[global::Cpp2ILInjected.Token(Token = "0x6001FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D110", Offset = "0x1B5D110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, int mapId)
		{
			throw null;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00019802 File Offset: 0x00017A02
		[global::Cpp2ILInjected.Token(Token = "0x6001FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D118", Offset = "0x1B5D118", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00019805 File Offset: 0x00017A05
		[global::Cpp2ILInjected.Token(Token = "0x6001FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D178", Offset = "0x1B5D178", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00019808 File Offset: 0x00017A08
		[global::Cpp2ILInjected.Token(Token = "0x6001FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D1B4", Offset = "0x1B5D1B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D77 RID: 3447
		[global::Cpp2ILInjected.Token(Token = "0x4001069")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04000D78 RID: 3448
		[global::Cpp2ILInjected.Token(Token = "0x400106A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int mapId;
	}
}
