using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A7")]
	[global::System.Serializable]
	internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001E07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A34C", Offset = "0x1B4A34C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int arg_num)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000F22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _uri;
	}
}
