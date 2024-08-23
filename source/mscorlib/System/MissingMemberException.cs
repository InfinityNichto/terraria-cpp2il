using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000100 RID: 256
	[global::Cpp2ILInjected.Token(Token = "0x2000132")]
	[global::System.Serializable]
	public class MissingMemberException : global::System.MemberAccessException
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00016595 File Offset: 0x00014795
		[global::Cpp2ILInjected.Token(Token = "0x6000BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56720", Offset = "0x1C56720", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingFieldException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingMemberException()
		{
			throw null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00016598 File Offset: 0x00014798
		[global::Cpp2ILInjected.Token(Token = "0x6000BDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C566B0", Offset = "0x1C566B0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.FieldInfo[])
		}, ReturnType = typeof(global::System.TypedReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingMemberException(string message)
		{
			throw null;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001659B File Offset: 0x0001479B
		[global::Cpp2ILInjected.Token(Token = "0x6000BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56780", Offset = "0x1C56780", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected MissingMemberException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001659E File Offset: 0x0001479E
		[global::Cpp2ILInjected.Token(Token = "0x6000BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56B44", Offset = "0x1C56B44", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000165A1 File Offset: 0x000147A1
		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C56A18", Offset = "0x1C56A18", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMethodException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000165A4 File Offset: 0x000147A4
		[global::Cpp2ILInjected.Token(Token = "0x6000BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56CA8", Offset = "0x1C56CA8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string FormatSignature(byte[] signature)
		{
			throw null;
		}

		// Token: 0x0400037C RID: 892
		[global::Cpp2ILInjected.Token(Token = "0x40004CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		protected string ClassName;

		// Token: 0x0400037D RID: 893
		[global::Cpp2ILInjected.Token(Token = "0x40004CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		protected string MemberName;

		// Token: 0x0400037E RID: 894
		[global::Cpp2ILInjected.Token(Token = "0x40004D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		protected byte[] Signature;
	}
}
