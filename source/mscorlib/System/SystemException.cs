using System;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Util;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000D2 RID: 210
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	[global::System.Serializable]
	public class SystemException : global::System.Exception
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x00015F53 File Offset: 0x00014153
		[global::Cpp2ILInjected.Token(Token = "0x60009A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B4C4", Offset = "0x1C4B4C4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.XmlSyntaxException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.XmlSyntaxException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "GetRequiredSizes", MemberParameters = new object[]
		{
			typeof(global::System.Security.Util.TokenizerStream),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(global::System.Security.Util.TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(global::System.Security.Util.TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.InternalException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public SystemException()
		{
			throw null;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00015F56 File Offset: 0x00014156
		[global::Cpp2ILInjected.Token(Token = "0x60009A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C440F0", Offset = "0x1C440F0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 141)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SystemException(string message)
		{
			throw null;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00015F59 File Offset: 0x00014159
		[global::Cpp2ILInjected.Token(Token = "0x60009A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B544", Offset = "0x1C4B544", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SystemException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00015F5C File Offset: 0x0001415C
		[global::Cpp2ILInjected.Token(Token = "0x60009A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C441BC", Offset = "0x1C441BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SystemException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
