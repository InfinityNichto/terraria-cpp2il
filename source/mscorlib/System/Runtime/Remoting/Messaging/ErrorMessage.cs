using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000302 RID: 770
	[global::Cpp2ILInjected.Token(Token = "0x20003A7")]
	[global::System.Serializable]
	internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001BCC RID: 7116 RVA: 0x000192E3 File Offset: 0x000174E3
		[global::Cpp2ILInjected.Token(Token = "0x6001DFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B407E4", Offset = "0x1B407E4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CADMethodCallMessage)
		}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink.ProcessMessageRes")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ErrorMessage()
		{
			throw null;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x000192E6 File Offset: 0x000174E6
		[global::Cpp2ILInjected.Token(Token = "0x170003AD")]
		public int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A29C", Offset = "0x1B4A29C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x000192E9 File Offset: 0x000174E9
		[global::Cpp2ILInjected.Token(Token = "0x170003AE")]
		public object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A2A4", Offset = "0x1B4A2A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x000192EC File Offset: 0x000174EC
		[global::Cpp2ILInjected.Token(Token = "0x170003AF")]
		public global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A2AC", Offset = "0x1B4A2AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000192EF File Offset: 0x000174EF
		[global::Cpp2ILInjected.Token(Token = "0x170003B0")]
		public string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A2B4", Offset = "0x1B4A2B4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000192F2 File Offset: 0x000174F2
		[global::Cpp2ILInjected.Token(Token = "0x170003B1")]
		public object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A2F4", Offset = "0x1B4A2F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000192F5 File Offset: 0x000174F5
		[global::Cpp2ILInjected.Token(Token = "0x170003B2")]
		public virtual global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A2FC", Offset = "0x1B4A2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x000192F8 File Offset: 0x000174F8
		[global::Cpp2ILInjected.Token(Token = "0x170003B3")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A304", Offset = "0x1B4A304", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000192FB File Offset: 0x000174FB
		[global::Cpp2ILInjected.Token(Token = "0x170003B4")]
		public string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A344", Offset = "0x1B4A344", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000192FE File Offset: 0x000174FE
		[global::Cpp2ILInjected.Token(Token = "0x6001E07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A34C", Offset = "0x1B4A34C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int arg_num)
		{
			throw null;
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00019301 File Offset: 0x00017501
		[global::Cpp2ILInjected.Token(Token = "0x170003B5")]
		public LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A354", Offset = "0x1B4A354", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000C36 RID: 3126
		[global::Cpp2ILInjected.Token(Token = "0x4000F22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _uri;
	}
}
