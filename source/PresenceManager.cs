using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20002B7")]
public class PresenceManager
{
	[global::Cpp2ILInjected.Token(Token = "0x6001017")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3CD38", Offset = "0xA3CD38", Length = "0x350")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LookForNewUsers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	public static void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001018")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D088", Offset = "0xA3D088", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static void SetState(string state)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001019")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D110", Offset = "0xA3D110", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public PresenceManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600101A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D118", Offset = "0xA3D118", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static PresenceManager()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001D9E")]
	private static string currentUser;

	[global::Cpp2ILInjected.Token(Token = "0x4001D9F")]
	private static string currentState;
}
