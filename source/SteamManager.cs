using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200022A")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public static bool Initialized
	{
		[Cpp2IlInjected.Token(Token = "0x6000F93")]
		[Cpp2IlInjected.Address(RVA = "0x1063884", Offset = "0x1063884", VA = "0x1063884")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000F94")]
	[Cpp2IlInjected.Address(RVA = "0x106388C", Offset = "0x106388C", VA = "0x106388C")]
	public SteamManager()
	{
	}
}
