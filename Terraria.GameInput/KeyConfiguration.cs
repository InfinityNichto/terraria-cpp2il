using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B4")]
public class KeyConfiguration
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40065F4")]
	public Dictionary<TriggerNames, List<string>> KeyStatus;

	[Cpp2IlInjected.Token(Token = "0x17000685")]
	public bool DoGrappleAndInteractShareTheSameKey
	{
		[Cpp2IlInjected.Token(Token = "0x60034B4")]
		[Cpp2IlInjected.Address(RVA = "0xE17624", Offset = "0xE17624", VA = "0xE17624")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60034B5")]
	[Cpp2IlInjected.Address(RVA = "0xE17710", Offset = "0xE17710", VA = "0xE17710")]
	public void SetupKeys()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B6")]
	[Cpp2IlInjected.Address(RVA = "0xE177D4", Offset = "0xE177D4", VA = "0xE177D4")]
	public void Processkey(TriggersSet set, string newKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B7")]
	[Cpp2IlInjected.Address(RVA = "0xE17A80", Offset = "0xE17A80", VA = "0xE17A80")]
	public void CopyKeyState(TriggersSet oldSet, TriggersSet newSet, string newKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B8")]
	[Cpp2IlInjected.Address(RVA = "0xE17BE4", Offset = "0xE17BE4", VA = "0xE17BE4")]
	public void ReadPreferences(Dictionary<TriggerNames, List<string>> dict)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B9")]
	[Cpp2IlInjected.Address(RVA = "0xE17EE0", Offset = "0xE17EE0", VA = "0xE17EE0")]
	public Dictionary<TriggerNames, List<string>> WritePreferences()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60034BA")]
	[Cpp2IlInjected.Address(RVA = "0xE181EC", Offset = "0xE181EC", VA = "0xE181EC")]
	public KeyConfiguration()
	{
	}
}
