using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000025")]
[Cpp2IlInjected.Attribute(Name = "ResourceLocationAttribute", RVA = "0x384A28", Offset = "0x384A28")]
public class PlatformControllerDisplay : Singleton<PlatformControllerDisplay>
{
	[Cpp2IlInjected.Token(Token = "0x2000773")]
	public enum ControllerDisplayState
	{
		[Cpp2IlInjected.Token(Token = "0x4007822")]
		Controller_None,
		[Cpp2IlInjected.Token(Token = "0x4007823")]
		Controller_XBO,
		[Cpp2IlInjected.Token(Token = "0x4007824")]
		Controller_PS4
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000774")]
	public class PlatformControllerDisplayState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007825")]
		public string ControllerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007826")]
		public ControllerDisplayState DisplayState;

		[Cpp2IlInjected.Token(Token = "0x6004882")]
		[Cpp2IlInjected.Address(RVA = "0x10B685C", Offset = "0x10B685C", VA = "0x10B685C")]
		public PlatformControllerDisplayState()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public string[] Controller_XBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public string[] Controller_PS4;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x10B66BC", Offset = "0x10B66BC", VA = "0x10B66BC")]
	public ControllerDisplayState DisplayedController()
	{
		return default(ControllerDisplayState);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x10B67A8", Offset = "0x10B67A8", VA = "0x10B67A8")]
	public PlatformControllerDisplay()
	{
	}
}
