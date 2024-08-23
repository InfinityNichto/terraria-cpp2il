using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E7 RID: 743
	[global::Cpp2ILInjected.Token(Token = "0x20003E7")]
	public class ProgressChangedEventArgs : EventArgs
	{
		// Token: 0x0600180A RID: 6154 RVA: 0x000071C0 File Offset: 0x000053C0
		[global::Cpp2ILInjected.Token(Token = "0x6001A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E698FC", Offset = "0x1E698FC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "PostProgressChanged", MemberParameters = new object[]
		{
			typeof(AsyncOperation),
			"System.Net.WebClient.ProgressData"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DownloadProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UploadProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object),
			typeof(long),
			typeof(long),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundWorker), Member = "ReportProgress", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
			throw null;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x000071C3 File Offset: 0x000053C3
		[SRDescription("Percentage progress made in operation.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000615")]
		public int ProgressPercentage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E69970", Offset = "0x1E69970", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000071C6 File Offset: 0x000053C6
		[SRDescription("User-supplied state to identify operation.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000616")]
		public object UserState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E69978", Offset = "0x1E69978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EF8 RID: 3832
		[global::Cpp2ILInjected.Token(Token = "0x4001319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly int progressPercentage;

		// Token: 0x04000EF9 RID: 3833
		[global::Cpp2ILInjected.Token(Token = "0x400131A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object userState;
	}
}
