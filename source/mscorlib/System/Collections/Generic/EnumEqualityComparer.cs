using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x0200053C RID: 1340
	[global::Cpp2ILInjected.Token(Token = "0x200065A")]
	[global::System.Serializable]
	internal class EnumEqualityComparer<T> : EqualityComparer<T>, global::System.Runtime.Serialization.ISerializable where T : struct
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x0001C28C File Offset: 0x0001A48C
		[global::Cpp2ILInjected.Token(Token = "0x60031A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641E0C", Offset = "0x1641E0C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(T x, T y)
		{
			throw null;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0001C28F File Offset: 0x0001A48F
		[global::Cpp2ILInjected.Token(Token = "0x60031A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641E68", Offset = "0x1641E68", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode(T obj)
		{
			throw null;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0001C292 File Offset: 0x0001A492
		[global::Cpp2ILInjected.Token(Token = "0x60031A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641EA0", Offset = "0x1641EA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EnumEqualityComparer()
		{
			throw null;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x0001C295 File Offset: 0x0001A495
		[global::Cpp2ILInjected.Token(Token = "0x60031A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641EB4", Offset = "0x1641EB4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected EnumEqualityComparer(global::System.Runtime.Serialization.SerializationInfo information, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x0001C298 File Offset: 0x0001A498
		[global::Cpp2ILInjected.Token(Token = "0x60031A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641EC8", Offset = "0x1641EC8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x0001C29B File Offset: 0x0001A49B
		[global::Cpp2ILInjected.Token(Token = "0x60031A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641FC8", Offset = "0x1641FC8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0001C29E File Offset: 0x0001A49E
		[global::Cpp2ILInjected.Token(Token = "0x60031A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1642024", Offset = "0x1642024", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}
	}
}
