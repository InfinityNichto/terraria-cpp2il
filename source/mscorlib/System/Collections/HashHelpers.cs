using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004EE RID: 1262
	[global::Cpp2ILInjected.Token(Token = "0x20005E2")]
	internal static class HashHelpers
	{
		// Token: 0x06002A3A RID: 10810 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		[global::Cpp2ILInjected.Token(Token = "0x6002D9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06ECC", Offset = "0x1C06ECC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsPrime(int candidate)
		{
			throw null;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x0001BAEB File Offset: 0x00019CEB
		[global::Cpp2ILInjected.Token(Token = "0x6002D9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06F7C", Offset = "0x1C06F7C", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "Initialize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "TrimExcess", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "Initialize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "IsPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int GetPrime(int min)
		{
			throw null;
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x0001BAEE File Offset: 0x00019CEE
		[global::Cpp2ILInjected.Token(Token = "0x6002DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C070EC", Offset = "0x1C070EC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "expand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "Resize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "CopyFrom", MemberParameters = new object[] { "System.Collections.Generic.HashSet`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "IncreaseCapacity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ExpandPrime(int oldSize)
		{
			throw null;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x0001BAF1 File Offset: 0x00019CF1
		[global::Cpp2ILInjected.Token(Token = "0x170006F5")]
		internal static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo> SerializationInfoTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C07170", Offset = "0x1C07170", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0001BAF4 File Offset: 0x00019CF4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002DA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C07248", Offset = "0x1C07248", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static HashHelpers()
		{
			throw null;
		}

		// Token: 0x040015B1 RID: 5553
		[global::Cpp2ILInjected.Token(Token = "0x40019A1")]
		public static readonly int[] primes;

		// Token: 0x040015B2 RID: 5554
		[global::Cpp2ILInjected.Token(Token = "0x40019A2")]
		private static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;
	}
}
