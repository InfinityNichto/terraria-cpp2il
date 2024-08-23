using System;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000101 RID: 257
	[global::Cpp2ILInjected.Token(Token = "0x2000133")]
	[global::System.Serializable]
	public class OutOfMemoryException : global::System.SystemException
	{
		// Token: 0x06000B3C RID: 2876 RVA: 0x000165A7 File Offset: 0x000147A7
		[global::Cpp2ILInjected.Token(Token = "0x6000BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56CF0", Offset = "0x1C56CF0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(global::System.ReadOnlySpan<int>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ExpandByABlock", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public unsafe OutOfMemoryException()
		{
			throw null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000165AA File Offset: 0x000147AA
		[global::Cpp2ILInjected.Token(Token = "0x6000BE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56D48", Offset = "0x1C56D48", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public OutOfMemoryException(string message)
		{
			throw null;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000165AD File Offset: 0x000147AD
		[global::Cpp2ILInjected.Token(Token = "0x6000BE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56D68", Offset = "0x1C56D68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected OutOfMemoryException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
