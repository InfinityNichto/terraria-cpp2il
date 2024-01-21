using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000040")]
public class StackTraceSnapshot : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public string StackTrace;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1063728", Offset = "0x1063728", VA = "0x1063728")]
	public void UpdateStackTrace()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x10637A4", Offset = "0x10637A4", VA = "0x10637A4")]
	public StackTraceSnapshot()
	{
	}
}
