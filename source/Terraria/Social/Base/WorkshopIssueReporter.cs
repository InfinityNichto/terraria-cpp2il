using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000534")]
	public class WorkshopIssueReporter : IProvideReports
	{
		[global::Cpp2ILInjected.Token(Token = "0x14000033")]
		public event Action OnNeedToOpenUI
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600320E")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B624", Offset = "0x132B624", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600320F")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B6C0", Offset = "0x132B6C0", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000034")]
		public event Action OnNeedToNotifyUI
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003210")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B75C", Offset = "0x132B75C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003211")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B7F8", Offset = "0x132B7F8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003212")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B894", Offset = "0x132B894", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportInstantUploadProblem", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportInstantUploadProblemFromValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportDelayedUploadProblem", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportDelayedUploadProblemWithoutKnownReason", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportDownloadProblem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorkshopIssueReporter), Member = "ReportManifestCreationProblem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IssueReport), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddReport(string reportText)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003213")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B9B4", Offset = "0x132B9B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public List<IssueReport> GetReports()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003214")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B9BC", Offset = "0x132B9BC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OpenReportsScreen()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003215")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B9D8", Offset = "0x132B9D8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void NotifyReportsScreen()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003216")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B9F4", Offset = "0x132B9F4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReportInstantUploadProblem(string textKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003217")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BA34", Offset = "0x132BA34", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReportInstantUploadProblemFromValue(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003218")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BA64", Offset = "0x132BA64", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReportDelayedUploadProblem(string textKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003219")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BAA4", Offset = "0x132BAA4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType8<>), Member = ".ctor", MemberParameters = new object[] { "<Reason>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ReportDelayedUploadProblemWithoutKnownReason(string textKey, string reasonValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600321A")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BBDC", Offset = "0x132BBDC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType9<, >), Member = ".ctor", MemberParameters = new object[] { "<FilePath>j__TPar", "<Reason>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ReportDownloadProblem(string textKey, string path, Exception exception)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600321B")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BCC0", Offset = "0x132BCC0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType8<>), Member = ".ctor", MemberParameters = new object[] { "<Reason>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorkshopIssueReporter), Member = "AddReport", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ReportManifestCreationProblem(string textKey, Exception exception)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600321C")]
		[global::Cpp2ILInjected.Address(RVA = "0x132BD9C", Offset = "0x132BD9C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WorkshopIssueReporter()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Action OnNeedToOpenUI;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Action OnNeedToNotifyUI;

		[global::Cpp2ILInjected.Token(Token = "0x4003B72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _maxReports;

		[global::Cpp2ILInjected.Token(Token = "0x4003B73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<IssueReport> _reports;
	}
}
