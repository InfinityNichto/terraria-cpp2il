using Cpp2IlInjected;
using UnityEngine;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x2000757")]
public class ControllerActionVector
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007391")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007392")]
	public ControllerActionAxis X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007393")]
	public ControllerActionAxis Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007394")]
	public int DisplayPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007395")]
	public ControllerActionVector LinkedAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007396")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4007397")]
	public bool DisabledUntilClear;

	[Cpp2IlInjected.Token(Token = "0x1700082F")]
	public ControllerActionAxis MappedX
	{
		[Cpp2IlInjected.Token(Token = "0x60047F7")]
		[Cpp2IlInjected.Address(RVA = "0x120B330", Offset = "0x120B330", VA = "0x120B330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000830")]
	public ControllerActionAxis MappedY
	{
		[Cpp2IlInjected.Token(Token = "0x60047F8")]
		[Cpp2IlInjected.Address(RVA = "0x120B458", Offset = "0x120B458", VA = "0x120B458")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000831")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x60047F9")]
		[Cpp2IlInjected.Address(RVA = "0x120B3B4", Offset = "0x120B3B4", VA = "0x120B3B4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000832")]
	public ControllerActionButton.RequiredButtonState RequiredState
	{
		[Cpp2IlInjected.Token(Token = "0x60047FA")]
		[Cpp2IlInjected.Address(RVA = "0x120B4DC", Offset = "0x120B4DC", VA = "0x120B4DC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000833")]
	public bool HasMappingExcludeLinked
	{
		[Cpp2IlInjected.Token(Token = "0x60047FB")]
		[Cpp2IlInjected.Address(RVA = "0x120B568", Offset = "0x120B568", VA = "0x120B568")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000834")]
	public ControllerActionButton.RequiredButtonState RequiredStateExcludeLinked
	{
		[Cpp2IlInjected.Token(Token = "0x60047FC")]
		[Cpp2IlInjected.Address(RVA = "0x120B5E0", Offset = "0x120B5E0", VA = "0x120B5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047FD")]
	[Cpp2IlInjected.Address(RVA = "0x120B648", Offset = "0x120B648", VA = "0x120B648")]
	public bool Active(ControllerDevice device)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047FE")]
	[Cpp2IlInjected.Address(RVA = "0x120B69C", Offset = "0x120B69C", VA = "0x120B69C")]
	public bool RequiredStateValid(ControllerDevice device)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047FF")]
	[Cpp2IlInjected.Address(RVA = "0x120B6D4", Offset = "0x120B6D4", VA = "0x120B6D4")]
	public Vector2 GetValue(ControllerDevice controller)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6004800")]
	[Cpp2IlInjected.Address(RVA = "0x120AADC", Offset = "0x120AADC", VA = "0x120AADC")]
	public ControllerActionVector()
	{
	}
}
