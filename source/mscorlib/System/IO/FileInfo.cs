using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000483 RID: 1155
	[global::Cpp2ILInjected.Token(Token = "0x200054E")]
	[global::System.Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x0001ADD1 File Offset: 0x00018FD1
		[global::Cpp2ILInjected.Token(Token = "0x600286C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA3E54", Offset = "0x1BA3E54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = ".ctor", ReturnType = typeof(void))]
		private FileInfo()
		{
			throw null;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		[global::Cpp2ILInjected.Token(Token = "0x600286D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA3E58", Offset = "0x1BA3E58", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public FileInfo(string fileName)
		{
			throw null;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0001ADD7 File Offset: 0x00018FD7
		[global::Cpp2ILInjected.Token(Token = "0x600286E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA3E68", Offset = "0x1BA3E68", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileAttributes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystem), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
			throw null;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0001ADDA File Offset: 0x00018FDA
		[global::Cpp2ILInjected.Token(Token = "0x600286F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA3F78", Offset = "0x1BA3F78", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StreamWriter CreateText()
		{
			throw null;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0001ADDD File Offset: 0x00018FDD
		[global::Cpp2ILInjected.Token(Token = "0x6002870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA3FD8", Offset = "0x1BA3FD8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = "WriteLogFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StreamWriter AppendText()
		{
			throw null;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0001ADE0 File Offset: 0x00018FE0
		[global::Cpp2ILInjected.Token(Token = "0x6002871")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA4038", Offset = "0x1BA4038", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		private FileInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0001ADE3 File Offset: 0x00018FE3
		[global::Cpp2ILInjected.Token(Token = "0x170005CF")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002872")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA403C", Offset = "0x1BA403C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
