using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000027 RID: 39
[ResourceLocation("Managers/PlatformControllerDisplay")]
[global::Cpp2ILInjected.Token(Token = "0x2000041")]
public class PlatformControllerDisplay : Singleton<PlatformControllerDisplay>
{
	// Token: 0x060000FE RID: 254 RVA: 0x00021E72 File Offset: 0x00020072
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

	// Token: 0x060000FF RID: 255 RVA: 0x00021E75 File Offset: 0x00020075
	[global::Cpp2ILInjected.Token(Token = "0x6000178")]
	[global::Cpp2ILInjected.Address(RVA = "0x7055EC", Offset = "0x7055EC", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public PlatformControllerDisplay()
	{
		throw null;
	}

	// Token: 0x040000BB RID: 187
	[global::Cpp2ILInjected.Token(Token = "0x400010A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string[] Controller_XBO;

	// Token: 0x040000BC RID: 188
	[global::Cpp2ILInjected.Token(Token = "0x400010B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string[] Controller_PS4;

	// Token: 0x0200077C RID: 1916
	[global::Cpp2ILInjected.Token(Token = "0x2000042")]
	public enum ControllerDisplayState
	{
		// Token: 0x04007835 RID: 30773
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		Controller_None,
		// Token: 0x04007836 RID: 30774
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		Controller_XBO,
		// Token: 0x04007837 RID: 30775
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		Controller_PS4
	}

	// Token: 0x0200077D RID: 1917
	[global::Cpp2ILInjected.Token(Token = "0x2000043")]
	[Serializable]
	public class PlatformControllerDisplayState
	{
		// Token: 0x0600484C RID: 18508 RVA: 0x0002EE59 File Offset: 0x0002D059
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x705670", Offset = "0x705670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlatformControllerDisplayState()
		{
			throw null;
		}

		// Token: 0x04007838 RID: 30776
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string ControllerId;

		// Token: 0x04007839 RID: 30777
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public PlatformControllerDisplay.ControllerDisplayState DisplayState;
	}
}
