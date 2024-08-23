using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000538 RID: 1336
	[global::Cpp2ILInjected.Token(Token = "0x2000656")]
	[global::System.Serializable]
	internal class GenericEqualityComparer<T> : EqualityComparer<T> where T : global::System.IEquatable<T>
	{
		// Token: 0x06002CF5 RID: 11509 RVA: 0x0001C238 File Offset: 0x0001A438
		[global::Cpp2ILInjected.Token(Token = "0x6003186")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9ACC", Offset = "0x16A9ACC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		public override bool Equals(T x, T y)
		{
			throw null;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0001C23B File Offset: 0x0001A43B
		[global::Cpp2ILInjected.Token(Token = "0x6003187")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9AFC", Offset = "0x16A9AFC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode(T obj)
		{
			throw null;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0001C23E File Offset: 0x0001A43E
		[global::Cpp2ILInjected.Token(Token = "0x6003188")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9B20", Offset = "0x16A9B20", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0001C241 File Offset: 0x0001A441
		[global::Cpp2ILInjected.Token(Token = "0x6003189")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9B98", Offset = "0x16A9B98", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0001C244 File Offset: 0x0001A444
		[global::Cpp2ILInjected.Token(Token = "0x600318A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C08", Offset = "0x16A9C08", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0001C247 File Offset: 0x0001A447
		[global::Cpp2ILInjected.Token(Token = "0x600318B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C64", Offset = "0x16A9C64", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0001C24A File Offset: 0x0001A44A
		[global::Cpp2ILInjected.Token(Token = "0x600318C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C8C", Offset = "0x16A9C8C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GenericEqualityComparer()
		{
			throw null;
		}
	}
}
