using System;
using System.Runtime.Serialization;
using System.Security.Util;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x02000201 RID: 513
	[global::Cpp2ILInjected.Token(Token = "0x2000293")]
	[global::System.Serializable]
	public sealed class XmlSyntaxException : global::System.SystemException
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00017F4B File Offset: 0x0001614B
		[global::Cpp2ILInjected.Token(Token = "0x60016BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9DA4", Offset = "0x1AE9DA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "AppendString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSyntaxException()
		{
			throw null;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00017F4E File Offset: 0x0001614E
		[global::Cpp2ILInjected.Token(Token = "0x60016BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9DAC", Offset = "0x1AE9DAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSyntaxException(int lineNumber)
		{
			throw null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00017F51 File Offset: 0x00016151
		[global::Cpp2ILInjected.Token(Token = "0x60016C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9DB4", Offset = "0x1AE9DB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSyntaxException(int lineNumber, string message)
		{
			throw null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00017F54 File Offset: 0x00016154
		[global::Cpp2ILInjected.Token(Token = "0x60016C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9DBC", Offset = "0x1AE9DBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		private XmlSyntaxException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
