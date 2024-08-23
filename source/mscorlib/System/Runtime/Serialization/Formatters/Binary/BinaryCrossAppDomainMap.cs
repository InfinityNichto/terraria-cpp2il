using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000362 RID: 866
	[global::Cpp2ILInjected.Token(Token = "0x200040A")]
	internal sealed class BinaryCrossAppDomainMap
	{
		// Token: 0x06001DBB RID: 7611 RVA: 0x00019838 File Offset: 0x00017A38
		[global::Cpp2ILInjected.Token(Token = "0x6001FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5B4", Offset = "0x1B5D5B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryCrossAppDomainMap()
		{
			throw null;
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0001983B File Offset: 0x00017A3B
		[global::Cpp2ILInjected.Token(Token = "0x6001FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5BC", Offset = "0x1B5D5BC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0001983E File Offset: 0x00017A3E
		[global::Cpp2ILInjected.Token(Token = "0x6001FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5DC", Offset = "0x1B5D5DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D8C RID: 3468
		[global::Cpp2ILInjected.Token(Token = "0x400107E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int crossAppDomainArrayIndex;
	}
}
