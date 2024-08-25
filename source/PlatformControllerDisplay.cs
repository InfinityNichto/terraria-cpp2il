using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[ResourceLocation("Managers/PlatformControllerDisplay")]
[global::Cpp2ILInjected.Token(Token = "0x2000041")]
public class PlatformControllerDisplay : Singleton<PlatformControllerDisplay>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000177")]
	[global::Cpp2ILInjected.Address(RVA = "0x705504", Offset = "0x705504", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(object[]),
		typeof(object)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlatformControllerDisplay.ControllerDisplayState DisplayedController()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000178")]
	[global::Cpp2ILInjected.Address(RVA = "0x7055EC", Offset = "0x7055EC", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public PlatformControllerDisplay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400010A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string[] Controller_XBO;

	[global::Cpp2ILInjected.Token(Token = "0x400010B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string[] Controller_PS4;

	[global::Cpp2ILInjected.Token(Token = "0x2000042")]
	public enum ControllerDisplayState
	{
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		Controller_None,
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		Controller_XBO,
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		Controller_PS4
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	[Serializable]
	public class PlatformControllerDisplayState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x705670", Offset = "0x705670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlatformControllerDisplayState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string ControllerId;

		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public PlatformControllerDisplay.ControllerDisplayState DisplayState;
	}
}
