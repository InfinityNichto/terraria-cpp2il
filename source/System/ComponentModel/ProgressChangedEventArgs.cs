using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003E7")]
	public class ProgressChangedEventArgs : EventArgs
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4001319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly int progressPercentage;

		[global::Cpp2ILInjected.Token(Token = "0x400131A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object userState;
	}
}
