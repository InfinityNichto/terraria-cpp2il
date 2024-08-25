using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D5")]
	public class AsyncCompletedEventArgs : EventArgs
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x60019DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60884", Offset = "0x1E60884", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsyncCompletedEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E608DC", Offset = "0x1E608DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass164_0", Member = "<OpenReadAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass167_0", Member = "<OpenWriteAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass182_0", Member = "<UploadDataAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass185_0", Member = "<UploadFileAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass188_0", Member = "<UploadValuesAsync>b__0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenReadAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWriteAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFileAsyncCallback", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFileAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "<UploadStringAsync>b__179_0", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(AsyncOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OpenReadCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OpenWriteCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DownloadStringCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DownloadDataCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadStringCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadDataCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadFileCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadValuesCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Exception),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RunWorkerCompletedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
			throw null;
		}

		[SRDescription("True if operation was cancelled.")]
		[global::Cpp2ILInjected.Token(Token = "0x170005E3")]
		public bool Cancelled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60960", Offset = "0x1E60960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[SRDescription("Exception that occurred during operation.  Null if no error.")]
		[global::Cpp2ILInjected.Token(Token = "0x170005E4")]
		public Exception Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60968", Offset = "0x1E60968", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[SRDescription("User-supplied state to identify operation.")]
		[global::Cpp2ILInjected.Token(Token = "0x170005E5")]
		public object UserState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60970", Offset = "0x1E60970", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60978", Offset = "0x1E60978", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<DownloadStringTaskAsync>b__192_1", MemberParameters = new object[] { typeof(DownloadStringCompletedEventArgs) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<OpenReadTaskAsync>b__194_1", MemberParameters = new object[] { typeof(OpenReadCompletedEventArgs) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<OpenWriteTaskAsync>b__198_1", MemberParameters = new object[] { typeof(OpenWriteCompletedEventArgs) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<UploadStringTaskAsync>b__202_1", MemberParameters = new object[] { typeof(UploadStringCompletedEventArgs) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<DownloadDataTaskAsync>b__204_1", MemberParameters = new object[] { typeof(DownloadDataCompletedEventArgs) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<UploadDataTaskAsync>b__210_1", MemberParameters = new object[] { typeof(UploadDataCompletedEventArgs) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<UploadFileTaskAsync>b__214_1", MemberParameters = new object[] { typeof(UploadFileCompletedEventArgs) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c", Member = "<UploadValuesTaskAsync>b__218_1", MemberParameters = new object[] { typeof(UploadValuesCompletedEventArgs) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OpenReadCompletedEventArgs), Member = "get_Result", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OpenWriteCompletedEventArgs), Member = "get_Result", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DownloadStringCompletedEventArgs), Member = "get_Result", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DownloadDataCompletedEventArgs), Member = "get_Result", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadStringCompletedEventArgs), Member = "get_Result", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadDataCompletedEventArgs), Member = "get_Result", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadFileCompletedEventArgs), Member = "get_Result", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadValuesCompletedEventArgs), Member = "get_Result", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RunWorkerCompletedEventArgs), Member = "get_Result", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected void RaiseExceptionIfNecessary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Exception error;

		[global::Cpp2ILInjected.Token(Token = "0x40012E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool cancelled;

		[global::Cpp2ILInjected.Token(Token = "0x40012E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly object userState;
	}
}
