using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000418 RID: 1048
	[global::Cpp2ILInjected.Token(Token = "0x20004D7")]
	[global::System.Serializable]
	public class InvalidFilterCriteriaException : global::System.ApplicationException
	{
		// Token: 0x06002114 RID: 8468 RVA: 0x0001A189 File Offset: 0x00018389
		[global::Cpp2ILInjected.Token(Token = "0x60023AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81DA4", Offset = "0x1B81DA4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InvalidFilterCriteriaException()
		{
			throw null;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0001A18C File Offset: 0x0001838C
		[global::Cpp2ILInjected.Token(Token = "0x60023AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81E04", Offset = "0x1B81E04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterAttributeImpl", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterNameImpl", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterNameIgnoreCaseImpl", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Module), Member = "FilterTypeNameImpl", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Module), Member = "FilterTypeNameIgnoreCaseImpl", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public InvalidFilterCriteriaException(string message)
		{
			throw null;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0001A18F File Offset: 0x0001838F
		[global::Cpp2ILInjected.Token(Token = "0x60023B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81E2C", Offset = "0x1B81E2C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public InvalidFilterCriteriaException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0001A192 File Offset: 0x00018392
		[global::Cpp2ILInjected.Token(Token = "0x60023B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81E50", Offset = "0x1B81E50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected InvalidFilterCriteriaException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
