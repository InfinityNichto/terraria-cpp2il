using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x200039A")]
public class WorkshopIssueReporter : IProvideReports
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031E0")]
	private int _maxReports;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40031E1")]
	private List<IssueReport> _reports;

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event Action OnNeedToOpenUI
	{
		[Cpp2IlInjected.Token(Token = "0x6002DEA")]
		[Cpp2IlInjected.Address(RVA = "0x14E0C74", Offset = "0x14E0C74", VA = "0x14E0C74")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DEB")]
		[Cpp2IlInjected.Address(RVA = "0x14E0D24", Offset = "0x14E0D24", VA = "0x14E0D24")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action OnNeedToNotifyUI
	{
		[Cpp2IlInjected.Token(Token = "0x6002DEC")]
		[Cpp2IlInjected.Address(RVA = "0x14E0DD4", Offset = "0x14E0DD4", VA = "0x14E0DD4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DED")]
		[Cpp2IlInjected.Address(RVA = "0x14E0E84", Offset = "0x14E0E84", VA = "0x14E0E84")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002DEE")]
	[Cpp2IlInjected.Address(RVA = "0x14E0F34", Offset = "0x14E0F34", VA = "0x14E0F34")]
	private void AddReport(string reportText)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DEF")]
	[Cpp2IlInjected.Address(RVA = "0x14E0FFC", Offset = "0x14E0FFC", VA = "0x14E0FFC", Slot = "4")]
	public List<IssueReport> GetReports()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF0")]
	[Cpp2IlInjected.Address(RVA = "0x14E1004", Offset = "0x14E1004", VA = "0x14E1004")]
	private void OpenReportsScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF1")]
	[Cpp2IlInjected.Address(RVA = "0x14E1018", Offset = "0x14E1018", VA = "0x14E1018")]
	private void NotifyReportsScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF2")]
	[Cpp2IlInjected.Address(RVA = "0x14E102C", Offset = "0x14E102C", VA = "0x14E102C")]
	public void ReportInstantUploadProblem(string textKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF3")]
	[Cpp2IlInjected.Address(RVA = "0x14E106C", Offset = "0x14E106C", VA = "0x14E106C")]
	public void ReportInstantUploadProblemFromValue(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF4")]
	[Cpp2IlInjected.Address(RVA = "0x14E1098", Offset = "0x14E1098", VA = "0x14E1098")]
	public void ReportDelayedUploadProblem(string textKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF5")]
	[Cpp2IlInjected.Address(RVA = "0x14E10D8", Offset = "0x14E10D8", VA = "0x14E10D8")]
	public void ReportDelayedUploadProblemWithoutKnownReason(string textKey, string reasonValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF6")]
	[Cpp2IlInjected.Address(RVA = "0x14E118C", Offset = "0x14E118C", VA = "0x14E118C")]
	public void ReportDownloadProblem(string textKey, string path, Exception exception)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF7")]
	[Cpp2IlInjected.Address(RVA = "0x14E1260", Offset = "0x14E1260", VA = "0x14E1260")]
	public void ReportManifestCreationProblem(string textKey, Exception exception)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DF8")]
	[Cpp2IlInjected.Address(RVA = "0x14E132C", Offset = "0x14E132C", VA = "0x14E132C")]
	public WorkshopIssueReporter()
	{
	}
}
