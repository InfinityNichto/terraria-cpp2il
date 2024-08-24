using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200019C RID: 412
[global::Cpp2ILInjected.Token(Token = "0x200022B")]
public class PageControllerLayoutDefinition<T> : LayoutDefinition where T : PageControllerLayoutDefinition<T>
{
	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00023EB8 File Offset: 0x000220B8
	[global::Cpp2ILInjected.Token(Token = "0x17000164")]
	public static T Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1818CB0", Offset = "0x1818CB0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 708)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00023EBB File Offset: 0x000220BB
	[global::Cpp2ILInjected.Token(Token = "0x17000165")]
	public bool RightPageController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1818D74", Offset = "0x1818D74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00023EBE File Offset: 0x000220BE
	[global::Cpp2ILInjected.Token(Token = "0x6000CED")]
	[global::Cpp2ILInjected.Address(RVA = "0x1818D7C", Offset = "0x1818D7C", Length = "0x37C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
	protected void Awake()
	{
		throw null;
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00023EC1 File Offset: 0x000220C1
	[global::Cpp2ILInjected.Token(Token = "0x6000CEE")]
	[global::Cpp2ILInjected.Address(RVA = "0x18190F8", Offset = "0x18190F8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PageControllerLayoutDefinition()
	{
		throw null;
	}

	// Token: 0x04001143 RID: 4419
	[global::Cpp2ILInjected.Token(Token = "0x40015F8")]
	public static T InstanceNormal;

	// Token: 0x04001144 RID: 4420
	[global::Cpp2ILInjected.Token(Token = "0x40015F9")]
	public static T InstanceConsoleLeft;

	// Token: 0x04001145 RID: 4421
	[global::Cpp2ILInjected.Token(Token = "0x40015FA")]
	public static T InstanceConsoleRight;

	// Token: 0x04001146 RID: 4422
	[global::Cpp2ILInjected.Token(Token = "0x40015FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private bool _rightPageController;
}
