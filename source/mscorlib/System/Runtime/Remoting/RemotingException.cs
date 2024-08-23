using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x020002AA RID: 682
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000348")]
	[global::System.Serializable]
	public class RemotingException : global::System.SystemException
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x00018DFD File Offset: 0x00016FFD
		[global::Cpp2ILInjected.Token(Token = "0x6001C1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CEA0", Offset = "0x1B2CEA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		public RemotingException()
		{
			throw null;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00018E00 File Offset: 0x00017000
		[global::Cpp2ILInjected.Token(Token = "0x6001C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24BBC", Offset = "0x1B24BBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public RemotingException(string message)
		{
			throw null;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00018E03 File Offset: 0x00017003
		[global::Cpp2ILInjected.Token(Token = "0x6001C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2CEA8", Offset = "0x1B2CEA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected RemotingException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00018E06 File Offset: 0x00017006
		[global::Cpp2ILInjected.Token(Token = "0x6001C1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2AE38", Offset = "0x1B2AE38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "OnStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public RemotingException(string message, global::System.Exception InnerException)
		{
			throw null;
		}
	}
}
