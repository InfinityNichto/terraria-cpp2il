using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000471")]
	public static class FormattableStringFactory
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73464", Offset = "0x1B73464", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref global::System.Threading.ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			"System.Net.NetworkCredential",
			typeof(string),
			"System.Net.ContextFlagsPal",
			"System.Security.Authentication.ExtendedProtection.ChannelBinding"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(bool),
			"System.Net.SecurityStatusPal&"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "GetClientSpecifiedSpn", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CommandStream", Member = "ContinueCommandPipeline", ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CommandStream", Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			"System.Net.ReceiveState",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new object[]
		{
			"System.Net.CommandStream.PipelineEntry",
			"System.Net.ResponseDescription",
			typeof(bool),
			typeof(ref global::System.IO.Stream)
		}, ReturnType = "System.Net.CommandStream.PipelineInstruction")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new object[]
		{
			"System.Net.ResponseDescription",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpDataStream", Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new object[] { "System.Net.CloseExState" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetRequestStream", ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "AttemptedRecovery", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "FinishRequestStage", MemberParameters = new object[] { "System.Net.FtpWebRequest.RequestStage" }, ReturnType = "System.Net.FtpWebRequest.RequestStage")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest", Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SecurityBuffer", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			"System.Net.Security.SecurityBufferType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormattableString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.FormattableString Create(string format, params object[] arguments)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000472")]
		private sealed class ConcreteFormattableString : global::System.FormattableString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73534", Offset = "0x1B73534", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormattableString), Member = ".ctor", ReturnType = typeof(void))]
			internal ConcreteFormattableString(string format, object[] arguments)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700046A")]
			public override string Format
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002213")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B73560", Offset = "0x1B73560", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73568", Offset = "0x1B73568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override object[] GetArguments()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700046B")]
			public override int ArgumentCount
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002215")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B73570", Offset = "0x1B73570", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7357C", Offset = "0x1B7357C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override object GetArgument(int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7358C", Offset = "0x1B7358C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(global::System.IFormatProvider),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			public override string ToString(global::System.IFormatProvider formatProvider)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40012B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly string _format;

			[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly object[] _arguments;
		}
	}
}
