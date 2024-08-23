using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200042A RID: 1066
	[global::Cpp2ILInjected.Token(Token = "0x20004E9")]
	[global::System.Serializable]
	public sealed class ReflectionTypeLoadException : global::System.SystemException, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x0001A2BE File Offset: 0x000184BE
		[global::Cpp2ILInjected.Token(Token = "0x600242C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83FBC", Offset = "0x1B83FBC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ReflectionTypeLoadException(global::System.Type[] classes, global::System.Exception[] exceptions)
		{
			throw null;
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x0001A2C1 File Offset: 0x000184C1
		[global::Cpp2ILInjected.Token(Token = "0x600242D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83FF8", Offset = "0x1B83FF8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private ReflectionTypeLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x0001A2C4 File Offset: 0x000184C4
		[global::Cpp2ILInjected.Token(Token = "0x600242E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84128", Offset = "0x1B84128", Length = "0x128")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x0001A2C7 File Offset: 0x000184C7
		[global::Cpp2ILInjected.Token(Token = "0x170004D1")]
		public global::System.Exception[] LoaderExceptions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600242F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84250", Offset = "0x1B84250", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0001A2CA File Offset: 0x000184CA
		[global::Cpp2ILInjected.Token(Token = "0x170004D2")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002430")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84258", Offset = "0x1B84258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0001A2CD File Offset: 0x000184CD
		[global::Cpp2ILInjected.Token(Token = "0x6002431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84380", Offset = "0x1B84380", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0001A2D0 File Offset: 0x000184D0
		[global::Cpp2ILInjected.Token(Token = "0x6002432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84260", Offset = "0x1B84260", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "get_Message", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendLine", ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string CreateString(bool isMessage)
		{
			throw null;
		}

		// Token: 0x040010F8 RID: 4344
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly global::System.Type[] <Types>k__BackingField;

		// Token: 0x040010F9 RID: 4345
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly global::System.Exception[] <LoaderExceptions>k__BackingField;
	}
}
