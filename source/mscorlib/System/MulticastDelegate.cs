﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200013E RID: 318
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000185")]
	[global::System.Serializable]
	[StructLayout(0)]
	public abstract class MulticastDelegate : global::System.Delegate
	{
		// Token: 0x06000E3B RID: 3643 RVA: 0x00016D90 File Offset: 0x00014F90
		[global::Cpp2ILInjected.Token(Token = "0x6000F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81964", Offset = "0x1C81964", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DelegateSerializationHolder), Member = "GetDelegateData", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00016D93 File Offset: 0x00014F93
		[global::Cpp2ILInjected.Token(Token = "0x6000F27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81968", Offset = "0x1C81968", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00016D96 File Offset: 0x00014F96
		[global::Cpp2ILInjected.Token(Token = "0x6000F28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81A94", Offset = "0x1C81A94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "GetHashCode", ReturnType = typeof(int))]
		public sealed override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00016D99 File Offset: 0x00014F99
		[global::Cpp2ILInjected.Token(Token = "0x6000F29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81A98", Offset = "0x1C81A98", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "GetMethodImpl", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override global::System.Reflection.MethodInfo GetMethodImpl()
		{
			throw null;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00016D9C File Offset: 0x00014F9C
		[global::Cpp2ILInjected.Token(Token = "0x6000F2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81AC4", Offset = "0x1C81AC4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public sealed override global::System.Delegate[] GetInvocationList()
		{
			throw null;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00016D9F File Offset: 0x00014F9F
		[global::Cpp2ILInjected.Token(Token = "0x6000F2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81B7C", Offset = "0x1C81B7C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected sealed override global::System.Delegate CombineImpl(global::System.Delegate follow)
		{
			throw null;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00016DA2 File Offset: 0x00014FA2
		[global::Cpp2ILInjected.Token(Token = "0x6000F2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81D88", Offset = "0x1C81D88", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "RemoveImpl", MemberParameters = new object[] { typeof(global::System.Delegate) }, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private int LastIndexOf(global::System.Delegate[] haystack, global::System.Delegate[] needle)
		{
			throw null;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00016DA5 File Offset: 0x00014FA5
		[global::Cpp2ILInjected.Token(Token = "0x6000F2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81E98", Offset = "0x1C81E98", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MulticastDelegate), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Delegate[]),
			typeof(global::System.Delegate[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "LastIndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected sealed override global::System.Delegate RemoveImpl(global::System.Delegate value)
		{
			throw null;
		}

		// Token: 0x040004B9 RID: 1209
		[global::Cpp2ILInjected.Token(Token = "0x400068A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Delegate[] delegates;
	}
}