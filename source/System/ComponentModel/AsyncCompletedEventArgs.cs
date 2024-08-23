using System;
using System.IO;
using System.Net;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002D6 RID: 726
	[global::Cpp2ILInjected.Token(Token = "0x20003D5")]
	public class AsyncCompletedEventArgs : EventArgs
	{
		// Token: 0x0600177C RID: 6012 RVA: 0x0000703A File Offset: 0x0000523A
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

		// Token: 0x0600177D RID: 6013 RVA: 0x0000703D File Offset: 0x0000523D
		[global::Cpp2ILInjected.Token(Token = "0x60019DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E608DC", Offset = "0x1E608DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
			throw null;
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00007040 File Offset: 0x00005240
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00007043 File Offset: 0x00005243
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00007046 File Offset: 0x00005246
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

		// Token: 0x06001781 RID: 6017 RVA: 0x00007049 File Offset: 0x00005249
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

		// Token: 0x04000EC5 RID: 3781
		[global::Cpp2ILInjected.Token(Token = "0x40012E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Exception error;

		// Token: 0x04000EC6 RID: 3782
		[global::Cpp2ILInjected.Token(Token = "0x40012E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool cancelled;

		// Token: 0x04000EC7 RID: 3783
		[global::Cpp2ILInjected.Token(Token = "0x40012E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly object userState;
	}
}
